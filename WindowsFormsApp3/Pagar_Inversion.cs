using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Pagar_Inversion : Form
    {
        private static string user;
        public Pagar_Inversion(string _user)
        {
            InitializeComponent();
            user = _user;
            if (user.Equals("Auxiliar"))
            {
                pnl_pagar.Enabled = false;
            }
            if (user.Equals("Jefe"))
            {
                //ojo preguntar si el jefe tambie puede registrar

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //validar que se haya pasado por codigo de transaccion y no por otro dato
        //ArrayList cuota;
        Boolean es_inversion=false;
        Boolean flagprest = false;
        Boolean flaginver = false;
        string codigocuota;
        private void btn_buscarpagar_cLICK(object sender, EventArgs e)
        {

        }


        string numcuenta, tipocuenta, banco;


        static string ct = null;
        static string ccu=null;
        public static void variables(string ct2, string ccu2)
        {
            ct = ct2;
            ccu = ccu2;
        }
        

        private void Pagar_Inversion_Load(object sender, EventArgs e)
        {
            pnl_pagar.Enabled = false;
            if (ct != null) { txb_codigotransaccionpagar.Text = ct; }
        }

        private void btn_pagartransaccion_Click(object sender, EventArgs e)
        {

        }

        private void txb_codigotransaccionpagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_numerocuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbx_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
               
            if (flaginver == true && cbx_modalidad.Text.Equals("BANCARIA"))
            {
                pnl_pagobancario.Enabled = true;
                txb_comprobante.Enabled = false;

                txb_numerocuenta.Text = numcuenta;
                txb_banco.Text = banco;
                cbx_tipocuenta.Text = tipocuenta;
                //cbx_tipocuenta.SelectedText = tipocuenta;
                cbx_tipocuenta.SelectedValue = tipocuenta;
                //cbx_tipocuenta.SelectedItem = tipocuenta;
            }
            else
            {
                pnl_pagobancario.Enabled = false;
                txb_comprobante.Enabled = true;

                txb_numerocuenta.Text = "";
                txb_banco.Text = "";
                cbx_tipocuenta.Text = "";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
