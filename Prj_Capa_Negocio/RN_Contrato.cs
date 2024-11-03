using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;

namespace Prj_Capa_Negocio
{
    public class RN_Contrato
    {
        public bool RN_Checar_SitieneContrato(string xidPerso)
        {
            BD_Contrato obj = new BD_Contrato();
            return obj.BD_Checar_SitieneContrato(xidPerso);

        }

        public void RN_Registrar_Contrato(EN_Contrato per)
        {
            BD_Contrato obj = new BD_Contrato();
            obj.BD_Registrar_Contrato(per);
        }

        public void RN_Editar_Contrato(EN_Contrato per)
        {
            BD_Contrato obj = new BD_Contrato();
            obj.BD_Editar_Contrato(per);
        }

        public DataTable RN_Buscar_Contrato(string valor)
        {
            BD_Contrato obj = new BD_Contrato();
            return obj.BD_Buscar_ContratoxIDPersonal(valor);
        }
    }
}
