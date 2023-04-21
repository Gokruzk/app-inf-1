using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinAppAreaTerrreno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, area;

        private void TxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                b = double.Parse(TxtB.Text);
                TxtC.Focus();
            }
        }

        private void TxtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                c = double.Parse(TxtC.Text);
                CalcAreaTerreno obj = new CalcAreaTerreno(a, b, c);
                area = obj.CalcTriangle() + obj.CalcRectangle();
                LblRespuesta.Text += area + " m^2";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                a = double.Parse(TxtA.Text);
                TxtB.Focus();
            }
        }
    }
}
