using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    public partial class Informacion_Clientes : Form
    {
        static DataTable tabla;
        private static string user;

        public Informacion_Clientes(int boton, string _user)
        {
            InitializeComponent();

            user = _user;
            if (boton == 1) { tabControl1.SelectedTab = tabPage1; }
            if (boton == 2) { tabControl1.SelectedTab = tabPage2; }
            if (boton == 3) { tabControl1.SelectedTab = tabPage3; }
            //tabControl1.SelectedTab = tabPage3;

            /*
            tabla = new DataTable();
            pnl_consultar.Enabled = false;
            tabla.Columns.Add("FCH SOLICITUD");
            tabla.Columns.Add("MONTO");
            tabla.Columns.Add("TASA");
            tabla.Columns.Add("COD TRANSACCION");
            tabla.Columns.Add("TIPO");
            tabla.Columns.Add("ESTADO");
            tbl_screen.DataSource = tabla;
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Main ventana = new Main();
            //ventana.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void Informacion_Clientes_Load(object sender, EventArgs e)
        {
            pnl_modificardatos.Enabled = false;
            pnl_modificartransacciones.Enabled = false;
            pnl_modificardatostransaccion.Enabled = false;
            pnl_modificarfechas.Enabled = false;

            /*
            tabla.Rows.Add("XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXXX", "APROBADO");
            tabla.Rows.Add("XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXXX", "REPROVADO");
            tabla.Rows.Add("XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXXX", "ESTUDIO");
            */
        }

        private void chbx_inver_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbx_inver.Checked == true)
            {
                pnl_inversionista.Enabled = true;
                chbx_prest.Checked = false;
                chbx_fiad.Checked = false;
            }
            
        }

        private void chbx_prest_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbx_prest.Checked == true)
            {
                pnl_inversionista.Enabled = false;
                chbx_inver.Checked = false;
                chbx_fiad.Checked = false;
            }
            
        }

        private void chbx_fiad_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbx_fiad.Checked == true)
            {
                pnl_inversionista.Enabled = false;
                chbx_inver.Checked = false;
                chbx_prest.Checked = false;
            }
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ///--validando que los campos esten llenos
            if (txb_cedula.Text.Equals("") ||
                txb_nombres.Text.Equals("") ||
                txb_direccion.Text.Equals("") ||
                txb_telefono.Text.Equals("") ||
                cbx_modalidad.Text.Equals("")
                )
            {
                MessageBox.Show("Debe digitar todos los campos"); return;
            }
            if (chbx_prest.Checked == false &&
               chbx_inver.Checked == false &&
               chbx_fiad.Checked == false)
            {
                MessageBox.Show("Debe Definir el tipo de cliente"); return;
            }




            long cedula = long.Parse(txb_cedula.Text);
            //int codigo = metodos.generar_codigo();
            string nombre = txb_nombres.Text;
            string direccion = txb_direccion.Text;
            long telefono = long.Parse(txb_telefono.Text);
            string modalidad = cbx_modalidad.Text;
            ArrayList transacciones = new ArrayList();

            string tipo_cliente;


            if (chbx_prest.Checked)
            {
                if (metodos.buscar("prestatario", "cedulaprestatario", Convert.ToString(cedula)) == true) { MessageBox.Show("Este cliente ya se encuentra registrado"); return; }
                string codigo = metodos.generar_codigo(1, "prestatario", "codprestatario");
                string sql = "insert into prestatario values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "')";
                metodos.tabla_consulta(sql);

            }

            if (chbx_inver.Checked)
            {
                if (metodos.buscar("inversionista", "cedulainversionista", Convert.ToString(cedula)) == true) { MessageBox.Show("Este cliente ya se encuentra registrado"); return; }
                tipo_cliente = chbx_inver.Text;
                string codigo = metodos.generar_codigo(2, "inversionista", "codinversionista");
                string numcuenta;
                string banco = null;
                string tipocuenta = null;
                string sql = "insert into inversionista values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "',";

                if (txb_numcuenta.Text.Equals("")) { numcuenta = null; sql += "null" + ","; }
                else { numcuenta = (txb_numcuenta.Text); sql += "'" + numcuenta + "',"; }

                if (txb_banco.Text.Equals("")) { banco = null; sql += "null" + ","; }
                else { banco = txb_banco.Text; sql += "'" + banco + "',"; }

                if (txb_tipocuenta.Text.Equals("")) { tipocuenta = null; sql += "null" + ")"; }
                else { tipocuenta = (txb_tipocuenta.Text); sql += "'" + tipocuenta + "')"; }

                //string sql = "insert into inversionista values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "','" + numcuenta +"','" + banco + "','" +  tipocuenta+"')";

                metodos.tabla_consulta(sql);
            }

            if (chbx_fiad.Checked)
            {
                if (metodos.buscar("fiador", "cedulafiador", Convert.ToString(cedula)) == true) { MessageBox.Show("Este cliente ya se encuentra regsitrado"); return; }
                string codigo = metodos.generar_codigo(3, "prestatario", "codprestatario");
                string sql = "insert into fiador values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "')";
                metodos.tabla_consulta(sql);
            }



            MessageBox.Show("Cliente registrado exitosamente");
            txb_cedula.Text = ("");
            txb_nombres.Text = ("");
            txb_direccion.Text = ("");
            txb_telefono.Text = ("");
            cbx_modalidad.Text = null;

            txb_numcuenta.Text = "";
            txb_banco.Text = "";
            txb_tipocuenta.Text = "";




        }









        //=====================================================================



        //======================================================================






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        static ArrayList datosviejos = new ArrayList();
        static string b = ""; //0jito::: aqui esta la variable b y la lista de datos viejos



        ArrayList datos_viejos;
        private void cajas_modificar(string consulta,Boolean es_inver,Boolean es_pres,Boolean es_fiad)
        {
            datosviejos.Clear();


            chb_inver.Checked = false;
            chb_fiad.Checked = false;
            chb_pres.Checked = false;

            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();

            pnl_modificardatos.Enabled = true;
            pnl_modificarinvercionista.Enabled = false;
            txb_nombresmodificar.Text = resultados.GetString(0);      datosviejos.Add(resultados.GetString(0));
            txb_direccionmodificar.Text= resultados.GetString(1);     datosviejos.Add(resultados.GetString(1));
            txb_telefonomodificar.Text= resultados.GetString(2);      datosviejos.Add(resultados.GetString(2));


            if (es_fiad == true)
            {
                //chb_inver.Checked = false;
                chb_fiad.Checked = true;
                //chb_pres.Checked = false;
                pnl_modificartransacciones.Enabled = false;

            }
            if (es_pres == true) {
                //chb_inver.Checked =false;
                //chb_fiad.Checked = false;
                chb_pres.Checked = true;
                pnl_modificartransacciones.Enabled = true;
            }

            
            
            if (es_inver == true) {
                chb_inver.Checked = true;
                object nc = resultados.GetValue(3);
                object bn = resultados.GetValue(4);

                pnl_modificarinvercionista.Enabled = true;
                pnl_modificartransacciones.Enabled = true;
                if ("" + bn.GetType() == "System.DBNull") {
                    txb_bancomodificar.Text = null; datosviejos.Add("");

                }
                else
                {
                    txb_bancomodificar.Text = resultados.GetString(4); datosviejos.Add(resultados.GetString(4));

                }

                if ("" + nc.GetType() == "System.DBNull") {
                    txb_numcuentamodificar.Text = null; datosviejos.Add("");

                }
                else
                {
                    txb_numcuentamodificar.Text = resultados.GetString(3); datosviejos.Add(resultados.GetString(3));
                }



            }



        }

        
        


        string buscar_mod = "";
        string tipo_clie = "";
        Boolean es_prest = false;
        Boolean es_inver = false;
        Boolean es_fiad = false;
        private void btn_buscarmodificar_Click(object sender, EventArgs e)
        {

        }


        ///-------------------------------------
        ///

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        static string codigos = "";
        //btn_buscarconsultar_Click
        private void btn_buscarconsultar_Click_1(object sender, EventArgs e)
        {
            string cc = txb_cedulaconsultar.Text;
            string cd = txb_codigoconsultar.Text;
            string b = "";
            codigos = "";
            Boolean flag = false;



            ///--verifica si no estan llenos los dos campos
            if (txb_codigoconsultar.Text.Equals("") && txb_cedulaconsultar.Text.Equals(""))
            {
                MessageBox.Show("Debe  digitar alguno de los campos");
                return;
            }



            ///--verifi si esta lleno alguno de los 2 campos y
            ///--busca por codigo si estan llenos los 2 y si encontro el cliente
            ///
            tbl_screen.DataSource = null; //corregir porque hay que limpiar la tabla

            DataTable mytabla = new DataTable();
            mytabla = null;

            if (!txb_cedulaconsultar.Text.Equals("") &&
              (metodos.buscar("fiador", "cedulafiador", cc) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from fiador where cedulafiador like '" + cc + "'";
                codigos += " Fiador: ";
                viz(consulta);
                string consulta2 = "select * from fiador join transacciones_prestamo on (codfiador=fiador)where cedulafiador like '" + cc + "'";
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }

            if (!txb_codigoconsultar.Text.Equals("") &&
              (metodos.buscar("fiador", "codfiador", cd) == true))
            {
                b = cd; flag = true;
                codigos += " Fiador: ";
                string consulta = "select * from fiador where codfiador like '" + cd + "'";
                viz(consulta);
                string consulta2 = "select * from fiador join transacciones_prestamo on (codfiador=fiador)where codfiador like '" + cd + "'";
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);

                //tbl_screen.Rows.Add (metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }


            if (!txb_cedulaconsultar.Text.Equals("") &&
              (metodos.buscar("prestatario", "cedulaprestatario", cc) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from prestatario where cedulaprestatario like '" + cc + "'";
                codigos += "   Prestatario: ";
                viz(consulta);
                string consulta2 = "select * from prestatario join transacciones_prestamo on (codprestatario=prestatario)where cedulaprestatario like '" + cc + "'";
                //if (metodos.tabla_consulta(consulta2) != null)
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                //tbl_screen.Rows.Add(metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }
            if (!txb_codigoconsultar.Text.Equals("") &&
              (metodos.buscar("prestatario", "codprestatario", cd) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from prestatario where codprestatario like '" + cd + "'";
                codigos += "   Prestatario: ";
                viz(consulta);
                string consulta2 = "select * from prestatario join transacciones_prestamo on (codprestatario=prestatario)where codprestatario like '" + cd + "'";
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                //tbl_screen.Rows.Add ( metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }


            if (!txb_cedulaconsultar.Text.Equals("") &&
               (metodos.buscar("inversionista", "cedulainversionista", cc) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from inversionista where cedulainversionista like '" + cc + "'";
                codigos += "   Inversionista: ";
                viz(consulta);
                string consulta2 = "select * from inversionista join transacciones_inversion on (codinversionista=inversionista)where cedulainversionista like '" + cc + "'";
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                //tbl_screen.Rows.Add( metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }
            if (!txb_codigoconsultar.Text.Equals("") &&
               (metodos.buscar("inversionista", "codinversionista", cd) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from inversionista where codinversionista like '" + cd + "'";
                codigos += "   Inversionista: ";
                viz(consulta);
                string consulta2 = "select * from inversionista join transacciones_inversion on (codinversionista=inversionista)where codinversionista like '" + cd + "'";
                //tbl_screen.Rows.Add(metodos.tabla_consulta(consulta2));
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }

            tbl_screen.DataSource = mytabla;




            if (flag == false)
            {
                MessageBox.Show("No se encontró el Cliente");
                lbl_nombres.Text = "";
                lbl_codigo.Text = "";
                lbl_cedula.Text = "";
                lbl_telefono.Text = "";
                lbl_direccion.Text = "";

                tbl_screen.DataSource = null;
                return;
            }



            ///--si no encuentra el cliente con ninguno de los 2 campos termina

        }

        private void viz(string consulta)
        {
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();
            lbl_nombres.Text = resultados.GetString(2);
            codigos += resultados.GetString(0);
            //lbl_codigo.Text = resultados.GetString(0);
            lbl_codigo.Text = codigos;
            lbl_cedula.Text = resultados.GetString(1);

            lbl_direccion.Text= resultados.GetString(3);
            lbl_telefono.Text = resultados.GetString(4);
        }





        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txb_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_numcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_cedulaconsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_codigoconsultar.Text = "";
            pnl_consultar.Enabled = false;
            lbl_nombres.Text = "";
            lbl_codigo.Text = "";
            lbl_cedula.Text = "";
            lbl_direccion.Text = "";
            lbl_telefono.Text = "";

            tbl_screen.DataSource = null;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_codigoconsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_cedulaconsultar.Text = "";
            pnl_consultar.Enabled = false;
            lbl_nombres.Text = "";
            lbl_codigo.Text = "";
            lbl_cedula.Text = "";
            lbl_direccion.Text = "";
            lbl_telefono.Text = "";

            tbl_screen.DataSource = null;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_cedulamodificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_codigomodificar.Text = "";
        
        pnl_modificardatos.Enabled = false;
            pnl_modificartransacciones.Enabled = false;

            ///--vaciando cajas
            txb_nombresmodificar.Text = ("");
            txb_direccionmodificar.Text = ("");
            txb_telefonomodificar.Text = ("");

            txb_numcuentamodificar.Text = ("");
            txb_bancomodificar.Text = ("");
            txb_tipocuentamodificar.Text = ("");
            ///--vaciando cajas
            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = ("");
            cbx_modificarestado.Text = ("");

            txb_modificar_fechaaprobacion.Text = ("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");
            txb_codigotransaccionmodificar.Text = "";


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_codigomodificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_cedulamodificar.Text = "";
            pnl_modificardatos.Enabled = false;
            pnl_modificartransacciones.Enabled = false;


            ///--vaciando cajas
            txb_nombresmodificar.Text = ("");
            txb_direccionmodificar.Text = ("");
            txb_telefonomodificar.Text = ("");

            txb_numcuentamodificar.Text = ("");
            txb_bancomodificar.Text = ("");
            txb_tipocuentamodificar.Text = ("");
            ///--vaciando cajas
            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = ("");
            cbx_modificarestado.Text = ("");

            txb_modificar_fechaaprobacion.Text = ("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");
            txb_codigotransaccionmodificar.Text = "";

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///--vaciando cajas
            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = null;
            cbx_modificarestado.Text = null;
            pnl_modificardatostransaccion.Enabled = false;
            if(pnl_modificardatostransaccion.Enabled == false) { btn_modificar_transaccion.Enabled = false; }

            

            txb_modificar_fechaaprobacion.Text = ("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbx_modalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                //e.Handled = true;
            
        }

        private void txb_cedulaconsultar_TextChanged(object sender, EventArgs e)
        {
            txb_codigoconsultar.Text = "";
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
        Boolean flagprest = false;
        Boolean flaginver = false;
        static ArrayList datosviejos_transacciones=new ArrayList();

        public void limpiar_campostransacciones()
        {
            txb_modificarmonto.Text = null;
            txb_modificartasa.Text = null;
            cbx_modificartiempo.Text=(null);
            cbx_modificarestado.Text = null;
            txb_mcodfiador.Text = null;
            txb_modificar_fechaaprobacion.Text = null;
            txb_modificar_fechainicio.Text = null;
            txb_modificar_fechafinalizacion.Text = null;

            chbx_mgar.Checked = false;
            chbx_mfiador.Checked = false;

        }
        public static void reiniciando_var()
        {
            codgarantia = null;
            valorgarantia = null;
            ubicaciongarantia = null;
        }
        private static string valorgarantia = null;
        private static string ubicaciongarantia = null;
        private static string codgarantia = null;

        private void btn_buscartransaccionmodificar_Click(object sender, EventArgs e)
        {

        }






        private void cbx_modificarestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_modificarestado.Text.Equals("ESTUDIO"))
            {
                pnl_modificarfechas.Enabled = false;
                txb_modificar_fechaaprobacion.Text = "";
                txb_modificar_fechafinalizacion.Text = "";
                txb_modificar_fechainicio.Text = "";

            }
            if (cbx_modificarestado.Text.Equals("APROBADO"))
            {
                pnl_modificarfechas.Enabled = true;
                txb_modificar_fechaaprobacion.Text = metodos.fecha_hoy();
                txb_modificar_fechainicio.Text = metodos.fecha_hoy();
            }
            if (cbx_modificarestado.Text.Equals("REPROBADO"))
            {
                pnl_modificarfechas.Enabled = false;
                txb_modificar_fechaaprobacion.Text = "";
                txb_modificar_fechafinalizacion.Text = "";
                txb_modificar_fechainicio.Text = "";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_transaccion_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void txb_modificar_fechafinalizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscartransaccionmodificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_modificarmonto.Text = "";
            txb_modificartasa.Text = "";
            cbx_modificartiempo.Text = "";
            cbx_modificartiempo.SelectedText = "";
            cbx_modificartiempo.SelectedValue = "";
            cbx_modificartiempo.SelectedItem = "";

            cbx_modificarestado.Text = "";
            cbx_modificarestado.SelectedText = "";
            cbx_modificarestado.SelectedValue = "";
            cbx_modificarestado.SelectedItem = "";

            txb_modificar_fechaaprobacion.Text = "";
            txb_modificar_fechainicio.Text = "";
            txb_modificar_fechafinalizacion.Text = "";
        }

        private void chb_fiad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_pres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_codigoconsultar_TextChanged(object sender, EventArgs e)
        {
            txb_cedulaconsultar.Text = "";
        }

        private void txb_codigomodificar_TextChanged(object sender, EventArgs e)
        {
            txb_cedulamodificar.Text = "";
        }

        private void txb_cedulamodificar_TextChanged(object sender, EventArgs e)
        {
            txb_codigomodificar.Text = "";
        }

        private void chbx_mfiador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_mfiador.Checked == true)
            {
                chbx_mgar.Checked = false;
                //chbx_mgar.Enabled = false;
                //pnl_mcodfiador.Enabled = true;
                pnl_mcodfiador.Enabled = true;
            }
            else if(chbx_mgar.Checked == true)
            {
                chbx_mfiador.Checked = false;
                pnl_mcodfiador.Enabled = false;
            }
        }

        private void chbx_mgar_CheckedChanged(object sender, EventArgs e)
        {
            //chbx_gar.Checked = true;
            
            if (chbx_mgar.Checked == true)
            {
                txb_mcodfiador.Text = null;
                chbx_mfiador.Checked = false;
                //MessageBox.Show("" + codgarantia.GetType());
                if(codgarantia == null)
                {
                    string codigogarantiag = metodos.generar_codigo(4, "garantia", "codgarantia");
                    Administrar_Garantia nuevo = new Administrar_Garantia(Convert.ToInt32(codigogarantiag),null,null);
                    nuevo.ShowDialog();


                    ///ojo aqui hay un problema, que pasa si no registra ninguna garantia

                    string cod = txb_codigotransaccionmodificar.Text;
                    string consulta = "update  transacciones_prestamo set garantia = '" + codigogarantiag + "' , fiador=null where codprestamo like '"+cod+"'";
                    //metodos.ejecutar_consulta(consulta);
                    metodos.tabla_consulta(consulta);


                }
                if(codgarantia != null)
                {                    
                    Administrar_Garantia nuevo = new Administrar_Garantia(Convert.ToInt32(codgarantia), valorgarantia, ubicaciongarantia);
                    nuevo.Show();
                   
                }
                
                pnl_mcodfiador.Enabled = false;
                

            }
            else if (chbx_mfiador.Checked == true)
            {
                chbx_mgar.Checked = false;
                pnl_mcodfiador.Enabled = true;
            }
        }

        private void txb_modificarmonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_modificardatostransaccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txb_codigotransaccionmodificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            limpiar_campostransacciones();
            pnl_modificardatostransaccion.Enabled = false;
        }

        private void chb_inver_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}
