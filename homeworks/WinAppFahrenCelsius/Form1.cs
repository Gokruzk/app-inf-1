using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppFahrenCelsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblCels.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            LblCels.Visible = true;
            double grad = double.Parse(TxtFahr.Text);
            ClFahrenCelsi obj = new ClFahrenCelsi(grad);
            LblCels.Text = "El resultado de la conversión es: " + obj.CalCelsius().ToString() + " grados celsius.";
        }
    }
}
