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
            string user = txb_name.Text;
            string password = txb_psw.Text;

            metodos.buscar("usuarios", "nombre", user);


            if (txb_name.Text == "" || txb_psw.Text == "")
            {
                MessageBox.Show("Campos Vacíos"); return;
            }
            if (cbx_eaux.Checked == false && cbx_edti.Checked == false && cbx_eadm.Checked == false && cbx_ejef.Checked == false)
            {
                MessageBox.Show("Campos Vacíos"); return;
            }


            //-----------------------

            if (cbx_eaux.Checked == true)
            {
                string consulta = "SELECT nombre, pgp_sym_decrypt(password::bytea,'AES_KEY') as password,cargo FROM usuarios WHERE nombre like '" + user + "' and cargo  like 'AUXILIAR';";
                NpgsqlDataReader r = metodos.resultados_consulta(consulta);
                r.Read();
                try
                {
                    object _user = r.GetValue(0);
                    object _password = r.GetValue(1);
                    object _cargo = r.GetValue(2);


                    if ("" + _user.GetType() == "System.DBNull" ||
                        "" + _password.GetType() == "System.DBNull" ||
                        "" + _cargo.GetType() == "System.DBNull")
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return;
                    }


                    if (user.Equals(_user) && password.Equals(_password))
                    {
                        Main init = new Main(Convert.ToString(_user), Convert.ToString(_cargo), Convert.ToString(_password));
                        init.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return; ;
                    }

                    this.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez.");

                    txb_name.Text = "";
                    txb_psw.Text = "";
                    cbx_eadm.Checked = false;
                    cbx_eaux.Checked = false;
                    cbx_ejef.Checked = false;
                    cbx_edti.Checked = false;
                    return;
                }
            }


            if (cbx_eadm.Checked == true)
            {
                string consulta = "SELECT nombre, pgp_sym_decrypt(password::bytea,'AES_KEY') as password,cargo FROM usuarios WHERE nombre like '" + user + "' and cargo  like 'ADMINISTRADOR';";
                NpgsqlDataReader r = metodos.resultados_consulta(consulta);
                r.Read();
                try
                {
                    object _user = r.GetValue(0);
                    object _password = r.GetValue(1);
                    object _cargo = r.GetValue(2);


                    if ("" + _user.GetType() == "System.DBNull" ||
                        "" + _password.GetType() == "System.DBNull" ||
                        "" + _cargo.GetType() == "System.DBNull")
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return;
                    }


                    if (user.Equals(_user) && password.Equals(_password))
                    {
                        Main init = new Main(Convert.ToString(_user), Convert.ToString(_cargo), Convert.ToString(_password));
                        init.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return; ;
                    }

                    this.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez.");

                    txb_name.Text = "";
                    txb_psw.Text = "";
                    cbx_eadm.Checked = false;
                    cbx_eaux.Checked = false;
                    cbx_ejef.Checked = false;
                    cbx_edti.Checked = false;
                    return;
                }
            }

            if (cbx_ejef.Checked == true)
            {
                string consulta = "SELECT nombre, pgp_sym_decrypt(password::bytea,'AES_KEY') as password,cargo FROM usuarios WHERE nombre like '" + user + "' and cargo  like 'JEFE';";
                NpgsqlDataReader r = metodos.resultados_consulta(consulta);
                r.Read();
                try
                {
                    object _user = r.GetValue(0);
                    object _password = r.GetValue(1);
                    object _cargo = r.GetValue(2);


                    if ("" + _user.GetType() == "System.DBNull" ||
                        "" + _password.GetType() == "System.DBNull" ||
                        "" + _cargo.GetType() == "System.DBNull")
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return;
                    }


                    if (user.Equals(_user) && password.Equals(_password))
                    {
                        Main init = new Main(Convert.ToString(_user), Convert.ToString(_cargo), Convert.ToString(_password));
                        init.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return; ;
                    }

                    this.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez.");

                    txb_name.Text = "";
                    txb_psw.Text = "";
                    cbx_eadm.Checked = false;
                    cbx_eaux.Checked = false;
                    cbx_ejef.Checked = false;
                    cbx_edti.Checked = false;
                    return;
                }
            }


            if (cbx_edti.Checked == true)
            {
                string consulta = "SELECT nombre, pgp_sym_decrypt(password::bytea,'AES_KEY') as password,cargo FROM usuarios WHERE nombre like '" + user + "' and cargo  like 'DIRECTOR_TI';";
                NpgsqlDataReader r = metodos.resultados_consulta(consulta);
                r.Read();
                try
                {
                    object _user = r.GetValue(0);
                    object _password = r.GetValue(1);
                    object _cargo = r.GetValue(2);


                    if ("" + _user.GetType() == "System.DBNull" ||
                        "" + _password.GetType() == "System.DBNull" ||
                        "" + _cargo.GetType() == "System.DBNull")
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return;
                    }


                    if (user.Equals(_user) && password.Equals(_password))
                    {
                        Main init = new Main(Convert.ToString(_user), Convert.ToString(_cargo), Convert.ToString(_password));
                        init.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez."); return; ;
                    }

                    this.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez.");

                    txb_name.Text = "";
                    txb_psw.Text = "";
                    cbx_eadm.Checked = false;
                    cbx_eaux.Checked = false;
                    cbx_ejef.Checked = false;
                    cbx_edti.Checked = false;
                    return;
                }
            }
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
