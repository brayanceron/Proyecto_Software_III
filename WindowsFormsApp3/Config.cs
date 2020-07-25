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
            pnl_actualizar.Visible = true;
            pnl_actualizar.Enabled = true;
            pnl_registrar.Visible = false;

            pnl_actualizar.Location = new Point(125, 225);
        }

        private void btn_regusuario_Click(object sender, EventArgs e)
        {
            pnl_registrar.Visible = true;
            pnl_registrar.Enabled = true;
            pnl_actualizar.Visible = false;

            pnl_registrar.Location = new Point(125, 225);
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
            string n = txb_name.Text;
            string p = txb_psw.Text;


            if (cbx_aux.Checked == false && cbx_adm.Checked == false && cbx_jef.Checked == false)
            {
                MessageBox.Show("Campos vacíos"); return;
            }
            if (txb_name.Text == "" || txb_psw.Text == "")
            {
                MessageBox.Show("Campos vacíos"); return;
            }


            //verificando que el usuario no existe
            if (cbx_aux.Checked == true)
            {
                string consulta2 = "SELECT nombre,cargo FROM usuarios WHERE nombre like '" + n + "' and cargo  like 'AUXILIAR';";
                NpgsqlDataReader r2 = metodos.resultados_consulta(consulta2);
                r2.Read();
                try
                {
                    object _nombre = r2.GetValue(0);
                    object _cargo = r2.GetValue(1);

                    if (_nombre.Equals(n) && _cargo.Equals("AUXILIAR"))
                    {
                        MessageBox.Show("Usuario YA EXISTENTE");
                        return;
                    }
                    else
                    {

                    }


                }
                catch
                {

                    string consulta = "INSERT INTO usuarios (nombre, password,cargo) VALUES ('" + n + "', PGP_SYM_ENCRYPT('" + p + "','AES_KEY'),'AUXILIAR');";
                    NpgsqlDataReader r = metodos.resultados_consulta(consulta);
                    MessageBox.Show("Usuario registrado exitosamente");
                    pnl_registrar.Visible = false;
                    pnl_registrar.Enabled = false;
                    lbl_today.Visible = false;
                }





            }
            if (cbx_jef.Checked == true)
            {
                string consulta2 = "SELECT nombre,cargo FROM usuarios WHERE nombre like '" + n + "' and cargo  like 'JEFE';";
                NpgsqlDataReader r2 = metodos.resultados_consulta(consulta2);
                r2.Read();
                try
                {
                    object _nombre = r2.GetValue(0);
                    object _cargo = r2.GetValue(1);

                    if (_nombre.Equals(n) && _cargo.Equals("JEFE"))
                    {
                        MessageBox.Show("Usuario YA EXISTENTE");
                        return;
                    }
                    else
                    {

                    }


                }
                catch
                {

                    string consulta = "INSERT INTO usuarios (nombre, password,cargo) VALUES ('" + n + "', PGP_SYM_ENCRYPT('" + p + "','AES_KEY'),'JEFE');";
                    NpgsqlDataReader r = metodos.resultados_consulta(consulta);
                    pnl_registrar.Visible = false;
                    pnl_registrar.Enabled = false;
                    lbl_today.Visible = false;
                    MessageBox.Show("Usuario registrado exitosamente");
                }

                txb_name.Text = "";
                txb_psw.Text = "";
                cbx_jef.Checked = false;
                cbx_aux.Checked = false;
                cbx_adm.Checked = false;


            }
            if (cbx_adm.Checked == true)
            {
                string consulta2 = "SELECT nombre,cargo FROM usuarios WHERE nombre like '" + n + "' and cargo  like 'ADMINISTRADOR';";
                NpgsqlDataReader r2 = metodos.resultados_consulta(consulta2);
                r2.Read();
                try
                {
                    object _nombre = r2.GetValue(0);
                    object _cargo = r2.GetValue(1);

                    if (_nombre.Equals(n) && _cargo.Equals("ADMINISTRADOR"))
                    {
                        MessageBox.Show("Usuario YA EXISTENTE ");
                        return;
                    }
                    else
                    {

                    }


                }
                catch
                {

                    string consulta = "INSERT INTO usuarios (nombre, password,cargo) VALUES ('" + n + "', PGP_SYM_ENCRYPT('" + p + "','AES_KEY'),'ADMINISTRADOR');";
                    NpgsqlDataReader r = metodos.resultados_consulta(consulta);
                    pnl_registrar.Visible = false;
                    pnl_registrar.Enabled = false;
                    lbl_today.Visible = false;
                    MessageBox.Show("Usuario registrado exitosamente");
                }



            }

        }

        private void button2_Click(object sender, EventArgs e) {
            string nn = txb_nnombre.Text;
            string nc = txb_ncontrasena.Text;
            string uc = txb_ultimacontrasena.Text;

            if (uc.Equals(password)) { }
            else { MessageBox.Show("La ultima contraseña no coincide con la última contraseña registrada"); return; }

            //verificando que el usuario ya no hay

            string consulta = "UPDATE usuarios SET nombre= '" + nn + "' ,password=(PGP_SYM_ENCRYPT('" + nc + "', 'AES_KEY')) where nombre like '" + name + "'";
            NpgsqlDataReader r = metodos.resultados_consulta(consulta);

            pnl_actualizar.Visible = false;
            pnl_actualizar.Enabled = false;

            lbl_today.Visible = false;







            MessageBox.Show("Información actualizada correctamente");
            name = nn;
            lbl_name.Text = name;
            txb_nnombre.Text = "";
            txb_ncontrasena.Text = "";
            txb_ultimacontrasena.Text = "";
        }
    }
}
