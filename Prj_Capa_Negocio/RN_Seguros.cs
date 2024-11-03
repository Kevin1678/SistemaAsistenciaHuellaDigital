using Prj_Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Negocio
{
    public class RN_Seguros
    {
        public DataTable RN_Buscar_Todos_Seguros()
        {

            BD_Seguro obj = new BD_Seguro();
            return obj.BD_Buscar_Todos_Seguros();
        }
    }
}
