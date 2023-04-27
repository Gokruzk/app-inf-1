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

namespace WinAppHab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TxtNum.Clear();
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dataGridView1.Rows.Clear();
                try
                {
                    int n = int.Parse(TxtNum.Text);
                    if (n < 1 || n >= 6)
                    {
                        MessageBox.Show("Ingrese un número entre 1 y 5", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNum.Clear();
                    }
                    else
                    {
                        TxtNum.Clear();
                        int filas = 0;
                        switch (n)
                        {
                            case 1:
                                dataGridView1.Rows.Add();
                                filas = dataGridView1.Rows.Count - 1;
                                dataGridView1[0, filas - 1].Value = "1. Azul";
                                dataGridView1[1, filas - 1].Value = "2";
                                dataGridView1[2, filas - 1].Value = "Primera";
                                break;
                            case 2:
                                dataGridView1.Rows.Add();
                                filas = dataGridView1.Rows.Count - 1;
                                dataGridView1[0, filas - 1].Value = "2. Roja";
                                dataGridView1[1, filas - 1].Value = "1";
                                dataGridView1[2, filas - 1].Value = "Primera";
                                break;
                            case 3:
                                dataGridView1.Rows.Add();
                                filas = dataGridView1.Rows.Count - 1;
                                dataGridView1[0, filas - 1].Value = "3. Verde";
                                dataGridView1[1, filas - 1].Value = "3";
                                dataGridView1[2, filas - 1].Value = "Segunda";
                                break;
                            case 4:
                                dataGridView1.Rows.Add();
                                filas = dataGridView1.Rows.Count - 1;
                                dataGridView1[0, filas - 1].Value = "4. Rosa";
                                dataGridView1[1, filas - 1].Value = "2";
                                dataGridView1[2, filas - 1].Value = "Segunda";
                                break;
                            case 5:
                                dataGridView1.Rows.Add();
                                filas = dataGridView1.Rows.Count - 1;
                                dataGridView1[0, filas - 1].Value = "5. Gris";
                                dataGridView1[1, filas - 1].Value = "1";
                                dataGridView1[2, filas - 1].Value = "Tercera";
                                break;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNum.Clear();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
