using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    public partial class Generar_Cronogramas : Form
    {
        static DataTable tablacuotascred;
        static DataTable tablacuotasinver;



        public Generar_Cronogramas(int boton)
        {
            InitializeComponent();
            if (boton == 1) { tabControl1.SelectedTab = tabPage1; }
            if (boton == 2) { tabControl1.SelectedTab = tabPage2; }


            tablacuotascred = new DataTable();
            
            /*tablacuotascred.Columns.Add("CRONOGRAMA");
            tablacuotascred.Columns.Add("FCH. PLANEADA");
            tablacuotascred.Columns.Add("FCH. EFECTIVA");
            tablacuotascred.Columns.Add("COD TRANSACCION");
            tablacuotascred.Columns.Add("MONTO");
            tablacuotascred.Columns.Add("TASA");
            tablacuotascred.Columns.Add("COMPROBANTE");
            tablacuotascred.Columns.Add("MODALIDAD");
            tablacuotascred.Columns.Add("TIPO");
            tablacuotascred.Columns.Add("ESTADO");
            */
            tbl_screencredito.DataSource = tablacuotascred;
            /*
            tablacuotascred.Rows.Add("XXXX","XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX", "PAGADA"  );
            tablacuotascred.Rows.Add("XXXX","XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX", "PENDIENTE");
            */




            tablacuotasinver = new DataTable();
            /*
            tablacuotasinver.Columns.Add("CRONOGRAMA");
            tablacuotasinver.Columns.Add("FCH. PLANEADA");
            tablacuotasinver.Columns.Add("FCH. EFECTIVA");
            tablacuotasinver.Columns.Add("COD TRANSACCION");
            tablacuotasinver.Columns.Add("MONTO");
            tablacuotasinver.Columns.Add("TASA");
            tablacuotasinver.Columns.Add("COMPROBANTE");
            tablacuotasinver.Columns.Add("MODALIDAD");
            tablacuotasinver.Columns.Add("TIPO");
            tablacuotasinver.Columns.Add("NUM CUENTA");
            tablacuotasinver.Columns.Add("BANCO");
            tablacuotasinver.Columns.Add("ESTADO");
            tbl_screeninver.DataSource = tablacuotasinver;

            tablacuotasinver.Rows.Add("XXXX", "XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX",  "XXXXX", "XXXXX", "PAGADA");
            tablacuotasinver.Rows.Add("XXXX", "XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX",  "XXXXX", "XXXXX", "PENDIENTE");

    */

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        Boolean es_generadopres = false;
        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        ///=========================================================================000

        private void generarcroprestamo_CLICK(object sender, EventArgs e)
        {

        }
        
        private void Generar_Cronogramas_Load(object sender, EventArgs e)
        {
            pnl_generar.Enabled = false;
            pnl_generar2.Enabled = false;


        }

        private void txb_codigotransaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            lbl_nombre.Text = "";
            lbl_codigocliente.Text = "";
            lbl_codcredito.Text = "";
            pnl_generar.Enabled = false;
            tbl_screencredito.DataSource = null;


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            lbl_nombre2.Text = "";
            lbl_codigocliente2.Text = "";
            lbl_codinver.Text = "";
            pnl_generar2.Enabled = false;
            tbl_screeninver.DataSource = null;
        }

        Boolean es_generadoinver = false;
        private void btn_buscarinversion_Click(object sender, EventArgs e)
        {

        }

        private void btn_generarcronogramainver_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void txb_codigotransaccion_TextChanged(object sender, EventArgs e)
        {
            pnl_generar.Enabled = false;
        }

        private void txb_codigotransaccioninver_TextChanged(object sender, EventArgs e)
        {
            pnl_generar2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_cancelarpres_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelarinver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imprimirpres_Click(object sender, EventArgs e)
        {

        }
    }
}
