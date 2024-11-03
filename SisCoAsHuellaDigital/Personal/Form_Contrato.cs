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
using System.IO;
using Prj_Capa_Datos;
using MicroSisPlani.Msm_Forms;
using Prj_Capa_Entidad;
using DPFP.Gui.Verification;
using DevComponents.DotNetBar;

namespace MicroSisPlani.Personal
{
    public partial class Form_Contrato : Form
    {
        public Form_Contrato()
        {
            InitializeComponent();
        }
        public bool saveeditar = false;
        private void Form_Contrato_Load(object sender, EventArgs e)
        {
            if (saveeditar == false)
            {
                Cargar_Seguro();
                
            }
        }


        public void Cargar_Seguro()
        {
            RN_Seguros obj = new RN_Seguros();
            DataTable dt = new DataTable();
            try
            {
                dt = obj.RN_Buscar_Todos_Seguros();
                if (dt.Rows.Count > 0)
                {
                    var cbo = comboBoxSeguro;
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "Nombre_Seguro";
                    cbo.ValueMember = "Id_Seg";
                }
                comboBoxSeguro.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Revisa el Error.  " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Buscar_Personal_ParaEditar(string doc)
        {


            string xFotoruta;
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable data = new DataTable();

                data = obj.RN_Buscar_Personal_xValor(doc);
                if (data.Rows.Count == 0) return;
                {
                    lbl_nroDoc.Text = Convert.ToString(data.Rows[0]["DOC"]);
                    lbl_nomPersona.Text = Convert.ToString(data.Rows[0]["Nombre_Completo"]);
                    xFotoruta = Convert.ToString(data.Rows[0]["Foto"]);
                    lbl_idperso.Text = doc;

                }

                if (File.Exists(xFotoruta) == true)
                {
                    Pic_persona.Load(xFotoruta);
                }
                else
                {
                    Pic_persona.Load(Application.StartupPath + @"\user.png");
                }


            }
            catch (Exception ex)
            {
                Pic_persona.Load(Application.StartupPath + @"\user.png");
                MessageBox.Show("Error al Buscar los datos: " + ex.Message, "Avertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



        private void Guardar_Contrato()
        {
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Contrato obj = new RN_Contrato();
            EN_Contrato per = new EN_Contrato();
            try
            {
                txt_IdContrato.Text = RN_Utilitario.RN_NroDoc(7);

                per.IdContrato = txt_IdContrato.Text;
                per.Id_Prsonal = lbl_idperso.Text;
                per.Fecha_emi = dtp_fechaEmi.Value;
                per.FechaIni = dtp_fechaIni.Value;
                per.FechaFin = dtp_fechaFin.Value;
                per.Tipo_contrato = cbo_tipoContra.Text;
                per.Days_worked = cbo_Diastraba.Text;
                per.Day_toRest = cbo_Descanso.Text;
                per.Has_Vacation = comboBoxVaca.Text;
                per.Has_AsigFamily = comboBoxFami.Text;
                per.Has_Gratifi = comboBoxGra.Text;
                per.Pay_Rent_5ta_Catg =comboBox5taCat.Text;
                per.Sueldo_Fijo = Convert.ToDouble(txt_Sueldo.Text);
                per.Acept_termn = comboBoxAcepto.Text;
                per.State_Deal = comboBoxEstado.Text;
                per.Id_Security = Convert.ToString(comboBoxSeguro.SelectedValue);

                obj.RN_Registrar_Contrato(per);

                if (BD_Contrato.save == true)
                {

                    RN_Utilitario.RN_Actualiza_Tipo_Doc(7);
                    fil.Show();
                    ok.Lbl_msm1.Text = "Los Datos del Contrato se han guardado correctamente";
                    ok.ShowDialog();
                    fil.Hide();

                    this.Tag = "A";
                    this.Close();


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Revisa el Error.  " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
        public bool xedit = false;
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia ok = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Contrato objper = new RN_Contrato();

            if (xedit == false)
            {
                if (objper.RN_Checar_SitieneContrato(lbl_idperso.Text) == true) { MessageBox.Show("El Nro de Contrato ya Existe en la Base de Datos, Verifica ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

                if (ValidarCajasTexto() == false) return;
                Guardar_Contrato();
            }
            else
            {
                Editar_Personal();
            }
        }

        private void Editar_Personal()
        {
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Contrato obj = new RN_Contrato();
            EN_Contrato per = new EN_Contrato();
            try
            {               

                per.IdContrato = txt_IdContrato.Text;
                per.Id_Prsonal = lbl_idperso.Text;
                per.Fecha_emi = dtp_fechaEmi.Value;
                per.FechaIni = dtp_fechaIni.Value;
                per.FechaFin = dtp_fechaFin.Value;
                per.Tipo_contrato = cbo_tipoContra.Text;
                per.Days_worked = cbo_Diastraba.Text;
                per.Day_toRest = cbo_Descanso.Text;
                per.Has_Vacation = comboBoxVaca.Text;
                per.Has_AsigFamily = comboBoxFami.Text;
                per.Has_Gratifi = comboBoxGra.Text;
                per.Pay_Rent_5ta_Catg = comboBox5taCat.Text;
                per.Sueldo_Fijo = Convert.ToDouble(txt_Sueldo.Text);
                per.Acept_termn = comboBoxAcepto.Text;
                per.State_Deal = comboBoxEstado.Text;
                per.Id_Security = Convert.ToString(comboBoxSeguro.SelectedValue);

                obj.RN_Editar_Contrato(per);

                if (BD_Contrato.edit == true)
                {
                    
                    fil.Show();
                    ok.Lbl_msm1.Text = "Los Datos del Personal se han Editado correctamente";
                    ok.ShowDialog();
                    fil.Hide();

                    this.Tag = "A";
                    this.Close();


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Revisa el Error.  " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


            private bool ValidarCajasTexto()
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

        
            if (txt_Sueldo.Text.Trim().Length < 1) { fil.Show(); adv.Lbl_Msm1.Text = "Ingrese el Sueldo Por Hora"; adv.ShowDialog(); fil.Hide(); txt_Sueldo.Focus(); return false; }
           
            if (cbo_tipoContra.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Tipo de Contrato"; adv.ShowDialog(); fil.Hide(); cbo_tipoContra.Focus(); return false; }
            if (cbo_Diastraba.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Dias de Trabajo"; adv.ShowDialog(); fil.Hide(); cbo_Diastraba.Focus(); return false; }
            if (cbo_Descanso.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Dia de Descanso"; adv.ShowDialog(); fil.Hide(); cbo_Descanso.Focus(); return false; }
            if (comboBoxVaca.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Vacaciones"; adv.ShowDialog(); fil.Hide(); comboBoxVaca.Focus(); return false; }
            if (comboBoxFami.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Asignacion Familiar"; adv.ShowDialog(); fil.Hide(); comboBoxFami.Focus(); return false; }           
            if (comboBox5taCat.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione 5ta Categoria"; adv.ShowDialog(); fil.Hide(); comboBox5taCat.Focus(); return false; }
            if (comboBoxGra.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Gratificacion"; adv.ShowDialog(); fil.Hide(); comboBoxGra.Focus(); return false; }
            if (comboBoxAcepto.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Acepto Termino"; adv.ShowDialog(); fil.Hide(); comboBoxAcepto.Focus(); return false; }
            if (comboBoxEstado.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Estado"; adv.ShowDialog(); fil.Hide(); comboBoxEstado.Focus(); return false; }
            if (comboBoxSeguro.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Seleccione Seguro"; adv.ShowDialog(); fil.Hide(); comboBoxSeguro.Focus(); return false; }
            return true;
        }

        public void buscarPersonalContratoEditar(string idpersonal)
        {
            try
            {
                RN_Contrato obj = new RN_Contrato();
                DataTable data = new DataTable();

                Cargar_Seguro();
      

                data = obj.RN_Buscar_Contrato(idpersonal);
                if (data.Rows.Count == 0) return;
                {
                    txt_IdContrato.Text = Convert.ToString(data.Rows[0]["Id_Contrato"]);
                    lbl_idperso.Text = Convert.ToString(data.Rows[0]["Id_Pernl"]);
                    dtp_fechaEmi.Value = Convert.ToDateTime(data.Rows[0]["Fecha_EmiCon"]);
                    dtp_fechaIni.Value = Convert.ToDateTime(data.Rows[0]["Fecha_Inicio"]);
                    dtp_fechaFin.Value = Convert.ToDateTime(data.Rows[0]["Fecha_Cese"]);
                    cbo_tipoContra.Text = Convert.ToString(data.Rows[0]["Tipo_Contrato"]);
                    cbo_Diastraba.Text = Convert.ToString(data.Rows[0]["Days_toWork"]);
                    cbo_Descanso.Text = Convert.ToString(data.Rows[0]["Day_toRest"]);
                    comboBoxVaca.Text = Convert.ToString(data.Rows[0]["Has_Vacation"]);
                    comboBoxFami.Text = Convert.ToString(data.Rows[0]["Has_AsigFami"]);
                    comboBoxGra.Text = Convert.ToString(data.Rows[0]["Has_Gratifi"]);
                    comboBox5taCat.Text = Convert.ToString(data.Rows[0]["Pay_5ta_Catg"]);
                    txt_Sueldo.Text = Convert.ToString(data.Rows[0]["Sueldo_Fijo"]);
                    comboBoxAcepto.Text = Convert.ToString(data.Rows[0]["Acept_Terms"]);
                    comboBoxEstado.Text = Convert.ToString(data.Rows[0]["Estado_contrato"]);
                    comboBoxSeguro.SelectedValue = Convert.ToString(data.Rows[0]["Id_Seg"]);
                }

                xedit = true;
                btn_aceptar.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa el Error.  " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
