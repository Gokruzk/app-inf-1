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

namespace WinAppPrueba7046
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        int n1 = 0, n2 = 0;
        int n = 0;
        int op = 0;

        private bool PerfectNum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum == n;
        }

        private bool PerfectNum(double n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum == n;
        }

        private void SumStrip_Click(object sender, EventArgs e)
        {
            try
            {
                op = 1;
                TxtNum1.Clear();
                TxtNum2.Clear();
                MessageBox.Show("Bienvenido a la operación Suma", "Suma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblN1.Visible = true;
                LblN2.Visible = true;
                TxtNum1.Visible = true;
                TxtNum2.Visible = true;
                LblTitle.Text = "SUMA DE DOS NÚMERO ENTEROS";
                TxtNum1.Focus();
            }
            catch
            {
                MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    n1 = int.Parse(TxtNum1.Text);
                    if (n1 > 99)
                    {
                        MessageBox.Show("Los números deben ser de dos cifras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNum1.Clear();
                        TxtNum1.Focus();
                    }
                    else
                    {
                        TxtNum2.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingresa un número entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNum1.Clear();
                }
            }
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RestStrip_Click(object sender, EventArgs e)
        {
            try
            {
                TxtNum1.Clear();
                TxtNum2.Clear();
                op = 2;
                MessageBox.Show("Bienvenido a la operación Resta", "Resta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblN1.Visible = true;
                LblN2.Visible = true;
                TxtNum1.Visible = true;
                TxtNum2.Visible = true;
                TxtNum1.Focus();
                LblTitle.Text = "RESTA DE DOS NÚMERO ENTEROS";
            }
            catch
            {
                MessageBox.Show("Ingresa un número entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MultStrip_Click(object sender, EventArgs e)
        {
            try
            {
                TxtNum1.Clear();
                TxtNum2.Clear();
                op = 3;
                MessageBox.Show("Bienvenido a la operación Multiplicación", "Multiplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblN1.Visible = true;
                LblN2.Visible = true;
                TxtNum1.Visible = true;
                TxtNum2.Visible = true;
                LblTitle.Text = "MULTIPLICACIÓN DE DOS NÚMERO ENTEROS";
                TxtNum1.Focus();
            }
            catch
            {
                MessageBox.Show("Ingresa un número entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DivStrip_Click(object sender, EventArgs e)
        {
            try
            {
                TxtNum1.Clear();
                TxtNum2.Clear();
                op = 4;
                MessageBox.Show("Bienvenido a la operación División", "División", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblN1.Visible = true;
                LblN2.Visible = true;
                TxtNum1.Visible = true;
                TxtNum2.Visible = true;
                LblTitle.Text = "DIVISIÓN DE DOS NÚMERO ENTEROS";
                TxtNum1.Focus();
            }
            catch
            {
                MessageBox.Show("Ingresa un número entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (op == 1)
                    {
                        n2 = int.Parse(TxtNum2.Text);
                        if (n2 > 99)
                        {
                            MessageBox.Show("Los números deben ser de dos cifras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtNum2.Clear();
                            TxtNum2.Focus();
                        }
                        else
                        {
                            ClOperaciones operacion = new ClOperaciones(n1, n2);
                            int sum = operacion.Suma();
                            dataGridView1.Visible = true;
                            dataGridView1.Rows.Add();
                            int filas = dataGridView1.Rows.Count - 1;
                            dataGridView1[0, filas - 1].Value = "Suma";
                            dataGridView1[1, filas - 1].Value = "" + n1;
                            dataGridView1[2, filas - 1].Value = "" + n2;
                            dataGridView1[3, filas - 1].Value = "" + sum;

                            if (PerfectNum(sum))
                            {
                                dataGridView2.Visible = true;
                                n++;
                                dataGridView2.Rows.Add();
                                int filas2 = dataGridView2.Rows.Count - 1;
                                dataGridView2[0, filas2 - 1].Value = "" + sum;
                            }
                            LblNumPerf.Visible = true;
                            LblNumPerf.Text = "Cantidad de resultados \nque son números \nperfectos: " + n;

                        }

                    }
                    if (op == 2)
                    {
                        n2 = int.Parse(TxtNum2.Text);
                        if (n2 > 99)
                        {
                            MessageBox.Show("Los números deben ser de dos cifras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtNum2.Clear();
                            TxtNum2.Focus();
                        }
                        else
                        {
                            ClOperaciones operacion = new ClOperaciones(n1, n2);
                            int res = operacion.Resta();
                            dataGridView1.Visible = true;
                            dataGridView1.Rows.Add();
                            int filas = dataGridView1.Rows.Count - 1;
                            dataGridView1[0, filas - 1].Value = "Resta";
                            dataGridView1[1, filas - 1].Value = "" + n1;
                            dataGridView1[2, filas - 1].Value = "" + n2;
                            dataGridView1[3, filas - 1].Value = "" + res;

                            if (PerfectNum(res))
                            {
                                dataGridView2.Visible = true;
                                n++;
                                dataGridView2.Rows.Add();
                                int filas2 = dataGridView2.Rows.Count - 1;
                                dataGridView2[0, filas2 - 1].Value = "" + res;
                            }
                            LblNumPerf.Visible = true;
                            LblNumPerf.Text = "Cantidad de resultados \nque son números \nperfectos: " + n;

                        }
                    }
                    if (op == 3)
                    {
                        n2 = int.Parse(TxtNum2.Text);
                        if (n2 > 99)
                        {
                            MessageBox.Show("Los números deben ser de dos cifras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtNum2.Clear();
                            TxtNum2.Focus();
                        }
                        else
                        {
                            ClOperaciones operacion = new ClOperaciones(n1, n2);
                            int mult = operacion.Mult();
                            dataGridView1.Visible = true;
                            dataGridView1.Rows.Add();
                            int filas = dataGridView1.Rows.Count - 1;
                            dataGridView1[0, filas - 1].Value = "Multiplicación";
                            dataGridView1[1, filas - 1].Value = "" + n1;
                            dataGridView1[2, filas - 1].Value = "" + n2;
                            dataGridView1[3, filas - 1].Value = "" + mult;

                            if (PerfectNum(mult))
                            {
                                dataGridView2.Visible = true;
                                n++;
                                dataGridView2.Rows.Add();
                                int filas2 = dataGridView2.Rows.Count - 1;
                                dataGridView2[0, filas2 - 1].Value = "" + mult;
                            }
                            LblNumPerf.Visible = true;
                            LblNumPerf.Text = "Cantidad de resultados \nque son números \nperfectos: " + n;

                        }
                    }
                    if (op == 4)
                    {
                        n2 = int.Parse(TxtNum2.Text);
                        if (n2 == 0)
                        {
                            MessageBox.Show("No se puede dividir para 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtNum2.Clear();
                        }
                        else
                        {
                            if (n2 > 99)
                            {
                                MessageBox.Show("Los números deben ser de dos cifras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                TxtNum2.Clear();
                                TxtNum2.Focus();
                            }
                            else
                            {
                                ClOperaciones operacion = new ClOperaciones(n1, n2);
                                double div = operacion.Div();
                                dataGridView1.Visible = true;
                                dataGridView1.Rows.Add();
                                int filas = dataGridView1.Rows.Count - 1;
                                dataGridView1[0, filas - 1].Value = "División";
                                dataGridView1[1, filas - 1].Value = "" + n1;
                                dataGridView1[2, filas - 1].Value = "" + n2;
                                dataGridView1[3, filas - 1].Value = "" + div;

                                if (PerfectNum(div))
                                {
                                    dataGridView2.Visible = true;
                                    n++;
                                    dataGridView2.Rows.Add();
                                    int filas2 = dataGridView2.Rows.Count - 1;
                                    dataGridView2[0, filas2 - 1].Value = "" + div;
                                }
                                LblNumPerf.Visible = true;
                                LblNumPerf.Text = "Cantidad de resultados \nque son números \nperfectos: " + n;
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ingresa un número entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNum2.Clear();
                }
            }
        }
    }
}
