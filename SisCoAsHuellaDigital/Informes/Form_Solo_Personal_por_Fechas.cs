using Prj_Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroSisPlani.Informes
{
    public partial class Form_Solo_Personal_por_Fechas : Form
    {
        public Form_Solo_Personal_por_Fechas()
        {
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (cbo_person.SelectedIndex == -1)
            {
                cbo_person.Focus();
                return;
            }
            this.Tag = "A";
            this.Close();
        }

        private void Form_Solo_Personal_por_Fechas_Load(object sender, EventArgs e)
        {
            Cargar_Personal();
            cbo_person.Focus();
        }
        private void Cargar_Personal()
        {
            RN_Personal obj = new RN_Personal();
            DataTable datos = new DataTable();

            datos = obj.RN_Leer_todoPersona();

            var cbo = cbo_person;
            cbo.DataSource = datos;
            cbo.ValueMember = "Id_Pernl";
            cbo.DisplayMember = "Nombre_Completo";

            cbo_person.SelectedIndex = -1;

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {          
            this.Tag = "";
            this.Close();
        }
    }
}
