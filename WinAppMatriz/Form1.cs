using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMatriz
{
    public partial class Form1 : Form
    {
        int f = 0, c = 0;
        int[,] Matriz_Ent = new int[2, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Matriz_Ent[f,c] = int .Parse(textBox1.Text);
                    textBox1.Clear();
                    c++;
                    if (c == 3)
                    {
                        f++;
                        c = 0;
                    }
                    if (f == 2)
                    {
                        MessageBox.Show("Matriz llena", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Enabled = false;
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j <= 2; j++)
                                listBox1.Items.Add(Matriz_Ent[i, j]);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ingrese un número", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
