namespace MicroSisPlani.Informes
{
    partial class Form_Solo_Personal_por_Fechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Solo_Personal_por_Fechas));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.cbo_person = new System.Windows.Forms.ComboBox();
            this.btn_no = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaIni = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            resources.ApplyResources(this.lbl_titulo, "lbl_titulo");
            this.lbl_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_titulo.Name = "lbl_titulo";
            // 
            // BunifuElipse1
            // 
            this.BunifuElipse1.ElipseRadius = 25;
            this.BunifuElipse1.TargetControl = this;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_cancelar.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.SolidColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_cancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_cancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            resources.ApplyResources(this.btn_cancelar, "btn_cancelar");
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.TextStyle.Text = resources.GetString("resource.Text");
            this.btn_cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cbo_person
            // 
            this.cbo_person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cbo_person, "cbo_person");
            this.cbo_person.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_person.FormattingEnabled = true;
            this.cbo_person.Name = "cbo_person";
            // 
            // btn_no
            // 
            resources.ApplyResources(this.btn_no, "btn_no");
            this.btn_no.BackgroundStyle.GradientAngle = 0F;
            this.btn_no.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.BackgroundStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_no.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_no.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_no.EnableThemes = false;
            this.btn_no.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no.Name = "btn_no";
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_no.TextStyle.Text = resources.GetString("resource.Text1");
            this.btn_no.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_no.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // dtp_fechaFin
            // 
            resources.ApplyResources(this.dtp_fechaFin, "dtp_fechaFin");
            this.dtp_fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            // 
            // dtp_fechaIni
            // 
            resources.ApplyResources(this.dtp_fechaIni, "dtp_fechaIni");
            this.dtp_fechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaIni.Name = "dtp_fechaIni";
            this.dtp_fechaIni.Tag = "";
            // 
            // Form_Solo_Personal_por_Fechas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtp_fechaIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_fechaFin);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_person);
            this.Controls.Add(this.btn_no);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Solo_Personal_por_Fechas";
            this.Load += new System.EventHandler(this.Form_Solo_Personal_por_Fechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_titulo;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbo_person;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_no;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtp_fechaFin;
        public System.Windows.Forms.DateTimePicker dtp_fechaIni;
    }
}