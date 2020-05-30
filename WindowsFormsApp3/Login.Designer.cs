namespace WindowsFormsApp3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txb_psw = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbx_eadm = new System.Windows.Forms.CheckBox();
            this.cbx_ejef = new System.Windows.Forms.CheckBox();
            this.cbx_eaux = new System.Windows.Forms.CheckBox();
            this.cbx_edti = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_psw
            // 
            this.txb_psw.Location = new System.Drawing.Point(60, 289);
            this.txb_psw.Name = "txb_psw";
            this.txb_psw.Size = new System.Drawing.Size(176, 20);
            this.txb_psw.TabIndex = 11;
            this.txb_psw.UseSystemPasswordChar = true;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(60, 230);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(176, 20);
            this.txb_name.TabIndex = 10;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(60, 412);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(176, 23);
            this.btn_iniciar.TabIndex = 8;
            this.btn_iniciar.Text = "INICIAR";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cbx_eadm
            // 
            this.cbx_eadm.AutoSize = true;
            this.cbx_eadm.Location = new System.Drawing.Point(74, 366);
            this.cbx_eadm.Name = "cbx_eadm";
            this.cbx_eadm.Size = new System.Drawing.Size(117, 17);
            this.cbx_eadm.TabIndex = 22;
            this.cbx_eadm.Text = "ADMINISTRADOR";
            this.cbx_eadm.UseVisualStyleBackColor = true;
            this.cbx_eadm.CheckedChanged += new System.EventHandler(this.cbx_adm_CheckedChanged);
            // 
            // cbx_ejef
            // 
            this.cbx_ejef.AutoSize = true;
            this.cbx_ejef.Location = new System.Drawing.Point(74, 343);
            this.cbx_ejef.Name = "cbx_ejef";
            this.cbx_ejef.Size = new System.Drawing.Size(102, 17);
            this.cbx_ejef.TabIndex = 21;
            this.cbx_ejef.Text = "JEFE CRÉDITO";
            this.cbx_ejef.UseVisualStyleBackColor = true;
            this.cbx_ejef.CheckedChanged += new System.EventHandler(this.cbx_jef_CheckedChanged);
            // 
            // cbx_eaux
            // 
            this.cbx_eaux.AutoSize = true;
            this.cbx_eaux.Location = new System.Drawing.Point(74, 320);
            this.cbx_eaux.Name = "cbx_eaux";
            this.cbx_eaux.Size = new System.Drawing.Size(126, 17);
            this.cbx_eaux.TabIndex = 20;
            this.cbx_eaux.Text = "AUXILIAR CRÉDITO";
            this.cbx_eaux.UseVisualStyleBackColor = true;
            this.cbx_eaux.CheckedChanged += new System.EventHandler(this.cbx_aux_CheckedChanged);
            // 
            // cbx_edti
            // 
            this.cbx_edti.AutoSize = true;
            this.cbx_edti.Location = new System.Drawing.Point(74, 389);
            this.cbx_edti.Name = "cbx_edti";
            this.cbx_edti.Size = new System.Drawing.Size(95, 17);
            this.cbx_edti.TabIndex = 23;
            this.cbx_edti.Text = "DIRECTOR TI";
            this.cbx_edti.UseVisualStyleBackColor = true;
            this.cbx_edti.CheckedChanged += new System.EventHandler(this.cbx_dti_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 451);
            this.Controls.Add(this.cbx_edti);
            this.Controls.Add(this.cbx_eadm);
            this.Controls.Add(this.cbx_ejef);
            this.Controls.Add(this.cbx_eaux);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_psw);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(320, 490);
            this.MinimumSize = new System.Drawing.Size(320, 490);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_psw;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbx_eadm;
        private System.Windows.Forms.CheckBox cbx_ejef;
        private System.Windows.Forms.CheckBox cbx_eaux;
        private System.Windows.Forms.CheckBox cbx_edti;
    }
}