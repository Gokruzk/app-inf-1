using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRestoDividendo
{
    public partial class Form1 : Form
    {
        double dividendo, divisor, resto = 0, cociente = 0;

        private void TxtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    divisor = double.Parse(TxtN2.Text);
                    if(divisor == 0)
                    {
                        MessageBox.Show("No se puede dividir para 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ClDivision obj = new ClDivision(dividendo, divisor);
                        resto = dividendo;
                        obj.Division(ref resto, ref cociente);
                        LblCoc.Text = "Cociente: " + cociente;
                        LblRest.Text = "Resto: " + resto;
                        resto = 0;
                        cociente = 0;
                        TxtN1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtN1.Clear();
                    TxtN2.Clear();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    dividendo = double.Parse(TxtN1.Text);
                    TxtN2.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
