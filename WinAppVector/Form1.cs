using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppVector
{
    public partial class Form1 : Form
    {
        int[] vec = new int[4];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int n = int.Parse(TxtNum.Text);
                    vec[i] = n;
                    listBox1.Items.Add(vec[i].ToString());
                    listBox1.Show();
                    i++;
                    TxtNum.Clear();
                    if (i == vec.Length)
                    {
                        MessageBox.Show("El vector éstá lleno", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNum.Enabled = false;
                        //    for (int j = 0; j < vec.Length; j++)
                        //    {
                        //        listBox1.Items.Add(vec[j].ToString());
                        //        listBox1.Show();
                        //    }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    TxtNum.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TxtNum.Clear();
            TxtNum.Enabled = true;
            i = 0;
        }
    }
}
