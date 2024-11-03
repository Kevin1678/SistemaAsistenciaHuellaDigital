using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;

namespace MicroSisPlani.Informes
{
    public partial class Form_Print_Fechas : Form
    {
        public Form_Print_Fechas()
        {
            InitializeComponent();
        }

        public DateTime FechaInicio;
        public DateTime FechaFin;

        public string CualImprimir = "";
      
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            Vsr_Asis.PrintReport();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            Vsr_Asis.ExportReport();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Vsr_Asis.RefreshReport();
        }
  

        private void Form_Print_Fechas_Load(object sender, EventArgs e)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable data = new DataTable();

            data = obj.RN_Ver_Asistencia_porPersona_Fechas(Convert.ToString(this.CualImprimir), Convert.ToDateTime(this.FechaInicio), Convert.ToDateTime(this.FechaFin));
            if (data.Rows.Count > 0)
            { 
                Rpte_Asistencia_porPersonaFecha rpte = new Rpte_Asistencia_porPersonaFecha();
                Vsr_Asis.ReportSource = rpte;
                rpte.SetDataSource(data);                
                rpte.Refresh();
                Vsr_Asis.ReportSource = rpte;
              
            }
        }
    }
}
