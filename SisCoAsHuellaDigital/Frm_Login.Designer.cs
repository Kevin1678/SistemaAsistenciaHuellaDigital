namespace MicroSisPlani
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.ElDivider1 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_pass = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btn_Aceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Asis_With_Huella = new System.Windows.Forms.Button();
            this.txt_usu = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider1)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(28, 115);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(294, 33);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Control de Asistencia";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ElDivider1
            // 
            this.ElDivider1.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.ElDivider1.LineColor = System.Drawing.Color.Silver;
            this.ElDivider1.LineSize = 1;
            this.ElDivider1.Location = new System.Drawing.Point(10, 126);
            this.ElDivider1.Name = "ElDivider1";
            this.ElDivider1.Size = new System.Drawing.Size(321, 23);
            this.ElDivider1.TabIndex = 22;
            this.ElDivider1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titulo.Controls.Add(this.btn_Salir);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(357, 42);
            this.pnl_titulo.TabIndex = 23;
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(313, 7);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(32, 32);
            this.btn_Salir.TabIndex = 464;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_pass.CaptionStyle.CaptionSize = 0;
            this.txt_pass.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_pass.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txt_pass.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_pass.CaptionStyle.StateStyles.DisabledStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_pass.CaptionStyle.StateStyles.FocusStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_pass.CaptionStyle.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_pass.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txt_pass.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.txt_pass.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txt_pass.EditBoxStyle.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txt_pass.EditBoxStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.EditBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_pass.EditBoxStyle.StateStyles.DisabledStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_pass.EditBoxStyle.StateStyles.FocusStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_pass.EditBoxStyle.StateStyles.HoverStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_pass.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_pass.Location = new System.Drawing.Point(34, 238);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(288, 38);
            this.txt_pass.TabIndex = 453;
            this.txt_pass.ValidationStyle.PasswordChar = '\0';
            this.txt_pass.ValidationStyle.UseSystemPasswordChar = true;
            this.txt_pass.Value = "";
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundStyle.GradientAngle = 0F;
            this.btn_Aceptar.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_Aceptar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Aceptar.BackgroundStyle.SolidColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Aceptar.BorderStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_Aceptar.EnableThemes = false;
            this.btn_Aceptar.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Aceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_Aceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aceptar.Location = new System.Drawing.Point(68, 291);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(224, 42);
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.TabIndex = 458;
            this.btn_Aceptar.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.TextStyle.Text = "Iniciar Sesion";
            this.btn_Aceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_estado.Location = new System.Drawing.Point(7, 392);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(330, 17);
            this.lbl_estado.TabIndex = 463;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btn_Asis_With_Huella
            // 
            this.btn_Asis_With_Huella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Asis_With_Huella.BackColor = System.Drawing.Color.White;
            this.btn_Asis_With_Huella.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Asis_With_Huella.FlatAppearance.BorderSize = 0;
            this.btn_Asis_With_Huella.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Asis_With_Huella.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Asis_With_Huella.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Asis_With_Huella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Asis_With_Huella.Image = ((System.Drawing.Image)(resources.GetObject("btn_Asis_With_Huella.Image")));
            this.btn_Asis_With_Huella.Location = new System.Drawing.Point(141, 350);
            this.btn_Asis_With_Huella.Name = "btn_Asis_With_Huella";
            this.btn_Asis_With_Huella.Size = new System.Drawing.Size(71, 59);
            this.btn_Asis_With_Huella.TabIndex = 467;
            this.toolTip1.SetToolTip(this.btn_Asis_With_Huella, "Registrar Asistencia por Huella Digital");
            this.btn_Asis_With_Huella.UseVisualStyleBackColor = false;
            this.btn_Asis_With_Huella.Click += new System.EventHandler(this.btn_Asis_With_Huella_Click);
            // 
            // txt_usu
            // 
            this.txt_usu.CaptionStyle.CaptionSize = 0;
            this.txt_usu.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_usu.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.Red;
            this.txt_usu.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_usu.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txt_usu.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txt_usu.EditBoxStyle.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_usu.EditBoxStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usu.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_usu.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_usu.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_usu.Location = new System.Drawing.Point(34, 185);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(288, 38);
            this.txt_usu.TabIndex = 450;
            this.txt_usu.ValidationStyle.PasswordChar = '\0';
            this.txt_usu.Value = "";
            this.txt_usu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usu_KeyDown);
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label12.Image = ((System.Drawing.Image)(resources.GetObject("Label12.Image")));
            this.Label12.Location = new System.Drawing.Point(42, 194);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(20, 20);
            this.Label12.TabIndex = 452;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label13.Image = ((System.Drawing.Image)(resources.GetObject("Label13.Image")));
            this.Label13.Location = new System.Drawing.Point(42, 247);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(20, 20);
            this.Label13.TabIndex = 454;
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.ForeColor = System.Drawing.Color.Black;
            this.PicLogo.Image = global::MicroSisPlani.Properties.Resources.image;
            this.PicLogo.Location = new System.Drawing.Point(139, 48);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(67, 60);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 21;
            this.PicLogo.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 414);
            this.Controls.Add(this.btn_Asis_With_Huella);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ElDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider1)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_Aceptar;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_pass;
        internal System.Windows.Forms.Panel pnl_titulo;
        internal System.Windows.Forms.Label Label1;
        internal Klik.Windows.Forms.v1.EntryLib.ELDivider ElDivider1;
        internal System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_Salir;
        internal System.Windows.Forms.Button btn_Asis_With_Huella;
        internal System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.ToolTip toolTip1;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_usu;
    }
}