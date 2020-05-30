using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    public partial class Config : Form
    {
        static string name;
        static string user;
        static string password;
        public Config(string _name, string _user,string _password,string _today)
        {
            InitializeComponent();
            name = _name;
            user = _user;
            password = _password;
            lbl_today.Text = _today;
        }

        private void Config_Load(object sender, EventArgs e)
        {
            lbl_name.Text = name;
            lbl_user.Text = user;

            pnl_actualizar.Visible = false;
            pnl_registrar.Visible = false;


            if (user.Equals("DIRECTOR_TI"))
            {
                btn_regusuario.Visible = true;
            }
            else
            {
                btn_regusuario.Visible = false;
            }

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_regusuario_Click(object sender, EventArgs e)
        {
            
        }

        private void cbx_aux_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_aux.Checked == true)
            {
                cbx_adm.Checked = false;
                cbx_jef.Checked = false;
            }
        }

        private void cbx_jef_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_jef.Checked == true)
            {
                cbx_adm.Checked = false;
                cbx_aux.Checked = false;
            }
        }

        private void cbx_adm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_adm.Checked == true)
            {
                cbx_aux.Checked = false;
                cbx_jef.Checked = false;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) {

        }
    }
}
