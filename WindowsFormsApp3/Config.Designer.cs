namespace WindowsFormsApp3
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pnl_actualizar = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txb_ultimacontrasena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_ncontrasena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_nnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_registrar = new System.Windows.Forms.Panel();
            this.cbx_adm = new System.Windows.Forms.CheckBox();
            this.cbx_jef = new System.Windows.Forms.CheckBox();
            this.cbx_aux = new System.Windows.Forms.CheckBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txb_psw = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_regusuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_today = new System.Windows.Forms.Label();
            this.pnl_actualizar.SuspendLayout();
            this.pnl_registrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(160, 149);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "lbl_name";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(160, 170);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(35, 13);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "label1";
            // 
            // pnl_actualizar
            // 
            this.pnl_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_actualizar.Controls.Add(this.btn_confirmar);
            this.pnl_actualizar.Controls.Add(this.txb_ultimacontrasena);
            this.pnl_actualizar.Controls.Add(this.label7);
            this.pnl_actualizar.Controls.Add(this.txb_ncontrasena);
            this.pnl_actualizar.Controls.Add(this.label6);
            this.pnl_actualizar.Controls.Add(this.txb_nnombre);
            this.pnl_actualizar.Controls.Add(this.label5);
            this.pnl_actualizar.Controls.Add(this.label1);
            this.pnl_actualizar.Location = new System.Drawing.Point(14, 233);
            this.pnl_actualizar.Name = "pnl_actualizar";
            this.pnl_actualizar.Size = new System.Drawing.Size(233, 225);
            this.pnl_actualizar.TabIndex = 2;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(69, 197);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(86, 23);
            this.btn_confirmar.TabIndex = 21;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_ultimacontrasena
            // 
            this.txb_ultimacontrasena.Location = new System.Drawing.Point(18, 162);
            this.txb_ultimacontrasena.Name = "txb_ultimacontrasena";
            this.txb_ultimacontrasena.Size = new System.Drawing.Size(176, 20);
            this.txb_ultimacontrasena.TabIndex = 20;
            this.txb_ultimacontrasena.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "CONTRASEÑA ACTUAL";
            // 
            // txb_ncontrasena
            // 
            this.txb_ncontrasena.Location = new System.Drawing.Point(18, 115);
            this.txb_ncontrasena.Name = "txb_ncontrasena";
            this.txb_ncontrasena.Size = new System.Drawing.Size(176, 20);
            this.txb_ncontrasena.TabIndex = 18;
            this.txb_ncontrasena.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "NUEVA CONTRASEÑA";
            // 
            // txb_nnombre
            // 
            this.txb_nnombre.Location = new System.Drawing.Point(18, 62);
            this.txb_nnombre.Name = "txb_nnombre";
            this.txb_nnombre.Size = new System.Drawing.Size(176, 20);
            this.txb_nnombre.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "NUEVO NOMBRE USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTUALIZAR INFORMACIÓN";
            // 
            // pnl_registrar
            // 
            this.pnl_registrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_registrar.Controls.Add(this.cbx_adm);
            this.pnl_registrar.Controls.Add(this.cbx_jef);
            this.pnl_registrar.Controls.Add(this.cbx_aux);
            this.pnl_registrar.Controls.Add(this.btn_registrar);
            this.pnl_registrar.Controls.Add(this.txb_psw);
            this.pnl_registrar.Controls.Add(this.txb_name);
            this.pnl_registrar.Controls.Add(this.label3);
            this.pnl_registrar.Controls.Add(this.label4);
            this.pnl_registrar.Controls.Add(this.label2);
            this.pnl_registrar.Location = new System.Drawing.Point(253, 233);
            this.pnl_registrar.Name = "pnl_registrar";
            this.pnl_registrar.Size = new System.Drawing.Size(233, 226);
            this.pnl_registrar.TabIndex = 3;
            // 
            // cbx_adm
            // 
            this.cbx_adm.AutoSize = true;
            this.cbx_adm.Location = new System.Drawing.Point(22, 174);
            this.cbx_adm.Name = "cbx_adm";
            this.cbx_adm.Size = new System.Drawing.Size(117, 17);
            this.cbx_adm.TabIndex = 19;
            this.cbx_adm.Text = "ADMINISTRADOR";
            this.cbx_adm.UseVisualStyleBackColor = true;
            this.cbx_adm.CheckedChanged += new System.EventHandler(this.cbx_adm_CheckedChanged);
            // 
            // cbx_jef
            // 
            this.cbx_jef.AutoSize = true;
            this.cbx_jef.Location = new System.Drawing.Point(22, 151);
            this.cbx_jef.Name = "cbx_jef";
            this.cbx_jef.Size = new System.Drawing.Size(102, 17);
            this.cbx_jef.TabIndex = 18;
            this.cbx_jef.Text = "JEFE CRÉDITO";
            this.cbx_jef.UseVisualStyleBackColor = true;
            this.cbx_jef.CheckedChanged += new System.EventHandler(this.cbx_jef_CheckedChanged);
            // 
            // cbx_aux
            // 
            this.cbx_aux.AutoSize = true;
            this.cbx_aux.Location = new System.Drawing.Point(22, 128);
            this.cbx_aux.Name = "cbx_aux";
            this.cbx_aux.Size = new System.Drawing.Size(126, 17);
            this.cbx_aux.TabIndex = 17;
            this.cbx_aux.Text = "AUXILIAR CRÉDITO";
            this.cbx_aux.UseVisualStyleBackColor = true;
            this.cbx_aux.CheckedChanged += new System.EventHandler(this.cbx_aux_CheckedChanged);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(73, 198);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(88, 23);
            this.btn_registrar.TabIndex = 16;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txb_psw
            // 
            this.txb_psw.Location = new System.Drawing.Point(26, 102);
            this.txb_psw.Name = "txb_psw";
            this.txb_psw.Size = new System.Drawing.Size(176, 20);
            this.txb_psw.TabIndex = 15;
            this.txb_psw.UseSystemPasswordChar = true;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(26, 53);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(176, 20);
            this.txb_name.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NOMBRE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRAR USUARIO";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(152, 195);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(85, 23);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_regusuario
            // 
            this.btn_regusuario.Location = new System.Drawing.Point(253, 195);
            this.btn_regusuario.Name = "btn_regusuario";
            this.btn_regusuario.Size = new System.Drawing.Size(81, 23);
            this.btn_regusuario.TabIndex = 5;
            this.btn_regusuario.Text = "REGISTRAR USUARIO";
            this.btn_regusuario.UseVisualStyleBackColor = true;
            this.btn_regusuario.Click += new System.EventHandler(this.btn_regusuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_today
            // 
            this.lbl_today.AutoSize = true;
            this.lbl_today.Location = new System.Drawing.Point(30, 219);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(37, 13);
            this.lbl_today.TabIndex = 7;
            this.lbl_today.Text = "Today";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_today);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_regusuario);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.pnl_registrar);
            this.Controls.Add(this.pnl_actualizar);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_name);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Config";
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.Config_Load);
            this.pnl_actualizar.ResumeLayout(false);
            this.pnl_actualizar.PerformLayout();
            this.pnl_registrar.ResumeLayout(false);
            this.pnl_registrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Panel pnl_actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_registrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txb_ultimacontrasena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_ncontrasena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_nnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbx_adm;
        private System.Windows.Forms.CheckBox cbx_jef;
        private System.Windows.Forms.CheckBox cbx_aux;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txb_psw;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_regusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_today;
    }
}