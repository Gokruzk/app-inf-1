using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppHipoTrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtAdy.Text = "0";
            TxtOpuesto.Text = "0";
            LblHipotenusa.Visible = false;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            LblHipotenusa.Visible = true;
            double opuesto = double.Parse(TxtOpuesto.Text);
            double adyacente = double.Parse(TxtAdy.Text);
            ClHipoTrian obj = new ClHipoTrian(opuesto, adyacente);
            LblHipotenusa.Text = "La hipotenusa del triángulo es: " + obj.CalcHipo();
        }
    }
}
