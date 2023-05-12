using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinAppAreaTerrreno
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath;
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, area;

        private void TxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    b = double.Parse(TxtB.Text);
                    TxtC.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    c = double.Parse(TxtC.Text);
                    CalcAreaTerreno obj = new CalcAreaTerreno(a, b, c);
                    area = obj.CalcTriangle() + obj.CalcRectangle();
                    LblRespuesta.Text += area + " m^2";
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string file1 = "terreno.png";
            string path1 = Path.Combine(path, file1);
            PbxTerreno.Image = Image.FromFile(path1);
        }

        private void TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    a = double.Parse(TxtA.Text);
                    TxtB.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
