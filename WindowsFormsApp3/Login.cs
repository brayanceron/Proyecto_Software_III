using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.clases;
using Npgsql;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cbx_aux_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_eaux.Checked == true)
            {
                cbx_eadm.Checked = false;
                cbx_ejef.Checked = false;
                cbx_edti.Checked = false;
            }
        }

        private void cbx_jef_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ejef.Checked == true)
            {
                cbx_eadm.Checked = false;
                cbx_eaux.Checked = false;
                cbx_edti.Checked = false;
            }
        }

        private void cbx_adm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_eadm.Checked == true)
            {
                cbx_eaux.Checked = false;
                cbx_ejef.Checked = false;
                cbx_edti.Checked = false;
            }
        }

        private void cbx_dti_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_edti.Checked == true)
            {
                cbx_eadm.Checked = false;
                cbx_ejef.Checked = false;
                cbx_eaux.Checked = false;
            }
        }
    }


   
}
