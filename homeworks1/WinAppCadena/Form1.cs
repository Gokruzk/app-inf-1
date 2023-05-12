using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string cadena = TxtString.Text;
                if (cadena == "")
                {
                    MessageBox.Show("Ingrese una cadena", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cadena guardada", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnCVOp.Enabled = true;
                    BtnInvertir.Enabled = true;
                    BtnDSpaces.Enabled = true;
                    BtnL.Enabled = true;
                }
            }
        }

        private void BtnInvertir_Click(object sender, EventArgs e)
        {
            TxtCI.Visible = true;
            TxtCI.Text = "";
            for (int i = TxtString.Text.Length - 1; i >= 0; i--)
            {
                TxtCI.Text += TxtString.Text[i];
            }
        }

        private void BtnCVOp_Click(object sender, EventArgs e)
        {
            int cont = 0;
            TxtCI.Visible = true;
            for (int i = 0; i < TxtString.Text.Length; i++)
            {
                string a = "";
                a += TxtString.Text[i];
                if (a == "a" || a == "e" || a == "o" || a == "á" || a == "é" || a == "ó")
                {
                    cont++;
                }
            }
            if (cont == 0 || cont > 1)
                TxtCI.Text = "La cadena tiene " + cont + " vocales abiertas.";
            else if (cont == 1)
                TxtCI.Text = "La cadena tiene " + cont + " vocal abierta.";
        }

        private void TxtString_Click(object sender, EventArgs e)
        {
            TxtCI.Clear();
            TxtCI.Visible = false;
        }

        private void BtnDSpaces_Click(object sender, EventArgs e)
        {
            TxtCI.Visible = true;
            TxtCI.Text = "";
            for (int i = 0; i < TxtString.Text.Length; i++)
            {
                string a = "";
                a += TxtString.Text[i];
                if (a != " ")
                    TxtCI.Text += TxtString.Text[i];
            }
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            TxtCI.Visible = true;
            TxtCI.Text = "";
            for (int i = 0; i < TxtString.Text.Length; i++)
            {
                string a = "";
                a += TxtString.Text[i];
                if (a != " ")
                    MessageBox.Show(a,"Letras");
            }
        }
    }
}
