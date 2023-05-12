using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtDado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int n = int.Parse(TxtDado.Text);
                    if (n < 1 || n > 6)
                    {
                        MessageBox.Show("Número incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LblDado.Text = "";
                        TxtDado.Clear();
                    }
                    else
                    {
                        switch (n)
                        {
                            case 1: LblDado.Text = "Número ingresado: Uno \nCara opuesta: Seis"; break;
                            case 2: LblDado.Text = "Número ingresado: Dos \nCara opuesta: Cinco"; break;
                            case 3: LblDado.Text = "Número ingresado: Tres \nCara opuesta: Cuatro"; break;
                            case 4: LblDado.Text = "Número ingresado: Cuatro \nCara opuesta: Tres"; break;
                            case 5: LblDado.Text = "Número ingresado: Cinco \nCara opuesta: Dos"; break;
                            case 6: LblDado.Text = "Número ingresado: Seis \nCara opuesta: Uno"; break;
                        }
                        TxtDado.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LblDado.Text = "";
                    TxtDado.Clear();
                }
            }
        }

        private void TxtDado_Click(object sender, EventArgs e)
        {
            LblDado.Text = "";
            TxtDado.Clear();
        }
    }
}
