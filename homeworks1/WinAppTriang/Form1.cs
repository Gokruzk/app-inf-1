using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTriang
{
    public partial class Form1 : Form
    {
        double a, b, c;

        private void TxtS2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    b = double.Parse(TxtS2.Text);
                    TxtS3.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtS3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    c = double.Parse(TxtS3.Text);
                    ClTriang obj = new ClTriang(a, b, c);
                    int type = obj.TypeTriangle();
                    Console.WriteLine(type);
                    switch (type)
                    {
                        case 1: LblTriang.Text = "El tipo de triángulo es: escaleno"; break;
                        case 2: LblTriang.Text = "El tipo de triángulo es: isósceles "; break;
                        case 3: LblTriang.Text = "El tipo de triángulo es: equilátero "; break;
                    }
                    TxtS1.Clear();
                    TxtS2.Clear();
                    TxtS3.Clear();
                    a = 0; b = 0; c = 0;
                    TxtS1.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    a = double.Parse(TxtS1.Text);
                    TxtS2.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
