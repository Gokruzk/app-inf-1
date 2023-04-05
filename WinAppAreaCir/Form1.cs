using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAreaCir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtRadio.Text = "0";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double Radio = double.Parse(TxtRadio.Text);
            ClAreaCir obj = new ClAreaCir(Radio);
            //LblRadio.Text = "Área de la circunferencia = ";
            LblRes.Text = obj.CalcArea().ToString();
        }
    }
}
