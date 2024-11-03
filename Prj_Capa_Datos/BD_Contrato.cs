using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Entidad;

namespace Prj_Capa_Datos
{

    public class BD_Contrato : Cls_Conexion

    {

        //CHECAR si tiene contrato
        public bool BD_Checar_SitieneContrato(string xidPerso)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection Cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            Cn.ConnectionString = Conectar();

            var _With1 = Cmd;

            _With1.CommandText = "Sp_Validar_No_Tener2Contrato";
            _With1.Connection = Cn;
            _With1.CommandTimeout = 20;
            _With1.CommandType = CommandType.StoredProcedure;
            //Parametros de entrada
            _With1.Parameters.AddWithValue("@Id_Pernl", xidPerso);
            try
            {
                Cn.Open();
                xfil = (Int32)Cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                Cmd.Parameters.Clear();
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;
            }

            catch (Exception ex)
            {
                if (Cn.State == ConnectionState.Open)
                    Cn.Close();
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;
                MessageBox.Show("Algo malo paso: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return functionReturnValue;
        }


        public static bool save = false;
        public static bool edit = false;
  
        public void BD_Registrar_Contrato(EN_Contrato per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Contrato", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdContra", per.IdContrato);
                cmd.Parameters.AddWithValue("@Id_Pers", per.Id_Prsonal);
                cmd.Parameters.AddWithValue("@Fecha_emi", per.Fecha_emi);
                cmd.Parameters.AddWithValue("@FechaIni", per.FechaIni);
                cmd.Parameters.AddWithValue("@FechaFin", per.FechaFin);
                cmd.Parameters.AddWithValue("@TipoContra", per.Tipo_contrato);
                cmd.Parameters.AddWithValue("@Days_toWork", per.Days_worked);
                cmd.Parameters.AddWithValue("@Day_toRest", per.Day_toRest);
                cmd.Parameters.AddWithValue("@Has_Vacation", per.Has_Vacation);
                cmd.Parameters.AddWithValue("@Has_AsigFami", per.Has_AsigFamily);
                cmd.Parameters.AddWithValue("@Has_Gratifi", per.Has_Gratifi);
                cmd.Parameters.AddWithValue("@Pay_5ta_Catg", per.Pay_Rent_5ta_Catg);
                cmd.Parameters.AddWithValue("@Sueldo_Fijo", per.Sueldo_Fijo);
                cmd.Parameters.AddWithValue("@Acept_Terms", per.Acept_termn);
                cmd.Parameters.AddWithValue("@Estado_contrato", per.State_Deal);
                cmd.Parameters.AddWithValue("@Id_Seg", per.Id_Security);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                save = true;

            }
            catch (Exception ex)
            {
                save = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();

                }
                MessageBox.Show("Algo malo paso" + ex.Message, "Adevertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }   //FIN   

        //MEtodo para Editar contrato
        public void BD_Editar_Contrato(EN_Contrato per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Modificar_Contrato", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdContra", per.IdContrato);
                cmd.Parameters.AddWithValue("@Id_Pers", per.Id_Prsonal);
                cmd.Parameters.AddWithValue("@Fecha_emi", per.Fecha_emi);
                cmd.Parameters.AddWithValue("@FechaIni", per.FechaIni);
                cmd.Parameters.AddWithValue("@FechaFin", per.FechaFin);
                cmd.Parameters.AddWithValue("@TipoContra", per.Tipo_contrato);
                cmd.Parameters.AddWithValue("@Days_toWork", per.Days_worked);
                cmd.Parameters.AddWithValue("@Day_toRest", per.Day_toRest);
                cmd.Parameters.AddWithValue("@Has_Vacation", per.Has_Vacation);
                cmd.Parameters.AddWithValue("@Has_AsigFami", per.Has_AsigFamily);
                cmd.Parameters.AddWithValue("@Has_Gratifi", per.Has_Gratifi);
                cmd.Parameters.AddWithValue("@Pay_5ta_Catg", per.Pay_Rent_5ta_Catg);
                cmd.Parameters.AddWithValue("@Sueldo_Fijo", per.Sueldo_Fijo);
                cmd.Parameters.AddWithValue("@Acept_Terms", per.Acept_termn);
                cmd.Parameters.AddWithValue("@Estado_contrato", per.State_Deal);
                cmd.Parameters.AddWithValue("@Id_Seg", per.Id_Security);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                edit = true;

            }
            catch (Exception ex)
            {
                edit = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();

                }
                MessageBox.Show("Algo malo paso1" + ex.Message, "Adevertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }   //FIN   
        //BUscar contrato para editar
        public DataTable BD_Buscar_ContratoxIDPersonal(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Cargar_ContratoxIDPer", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Pernl", valor);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();

                }
                MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Adevertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return null;
        }

    }
}
