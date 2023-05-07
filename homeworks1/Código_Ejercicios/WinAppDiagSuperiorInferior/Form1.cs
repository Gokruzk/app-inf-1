using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDiagSuperiorInferior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] Matriz = new int[3, 3];
        int i = 0, j = 0;
        int sz = 3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    int n = int.Parse(TxtNum.Text);
                    TxtNum.Clear();
                    Matriz[i, j] = n;
                    j++;
                    if (j == 3)
                    {
                        i++;
                        j = 0;
                    }
                    if (i == 3)
                    {
                        for (int i = 0; i < sz; i++)
                            dataGridView1.Columns.Add("", "");
                        for (int j = 0; j < sz - 1; j++)
                            dataGridView1.Rows.Add();

                        for (int i = 0; i < sz; i++)
                            for (int j = 0; j < sz; j++)
                                dataGridView1[j, i].Value = Matriz[i, j].ToString();

                        ClArreglo mat = new ClArreglo(Matriz, sz);
                        int mayDS = mat.FinDMaxDS();
                        int menD = mat.FindMinD();
                        int sum3 = mat.SumDI();
                        LblMayTS.Text = "Mayor elemento triángulo superior: " + mayDS;
                        LblMenD.Text = "Menor elemento de la diagonal: " + menD;
                        LblSumTI.Text = "Suma del triángulo inferior: " + sum3;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("- Ingrese un número\n- Matriz llena", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
