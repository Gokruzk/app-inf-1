using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCantCifras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();    //cerrar app
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblCifra.Visible = false;   //ocultar label al ejecutar
            TxtNum.Text = "0";          //iniciar textbox en 0
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = 0;
                numero = int.Parse(TxtNum.Text);
                LblCifra.Visible = true;
                ClNumCifra obj = new ClNumCifra(numero);
                LblCifra.Text = obj.CalCifra().ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
