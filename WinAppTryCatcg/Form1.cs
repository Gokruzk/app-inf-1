using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTryCatcg
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    char letra = TxtAlt.Text[0];
                    if (letra == 'a' || letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'h' || letra == 'i' || letra == 'j' || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 's' || letra == 't' || letra == 'u' || letra == 'v' || letra == 'w' || letra == 'x' || letra == 'y' || letra == 'z')
                    {
                        MessageBox.Show("Soy letra");
                        button1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Solo ingrese letras");
                        TxtAlt.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese una letra");
                    TxtAlt.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A VER DÓNDE SALGO", "Yo dónde saldré", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    a = int.Parse(TxtBase.Text);
                    if (a >= 100 && a <= 999)
                    {
                        TxtAlt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Solo ingrese números de 3 cifras");
                        TxtBase.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Solo ingrese números enteros");
                    TxtBase.Clear();
                }
            }
        }
    }
}
