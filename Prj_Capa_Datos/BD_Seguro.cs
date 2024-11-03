using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Entidad;
using System.Data.SqlClient;


namespace Prj_Capa_Datos
{
    public class BD_Seguro:Cls_Conexion
    {

        public DataTable BD_Buscar_Todos_Seguros()
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Ver_Todo_Seguros", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;

            }
            catch (Exception ex)
            {

                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error" + ex.Message, ex);

                }

            }
            return null;
        }

    }


}
