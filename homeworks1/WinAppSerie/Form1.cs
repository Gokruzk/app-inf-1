using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSerie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(TxtNum.Text == "")
                {
                    MessageBox.Show("Porfavor ingrese un número", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    TxtNum.Clear();
                }
                else
                {
                    try
                    {
                        int n = int.Parse(TxtNum.Text);
                        if (n <= 0)
                        {
                            MessageBox.Show("Ingrese un valor positivo o mayor a 0", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            TxtNum.Clear();
                        }
                        else if (n > 16)
                        {
                            MessageBox.Show("Ingrese un valor menor a 17", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            TxtNum.Clear();
                        }
                        else
                        {
                            ClSerie obj = new ClSerie(n);
                            LblR.Text = obj.SerieRecursiva(n,0,1).ToString();
                            TxtNum.Clear();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese un valor menor a 17", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        TxtNum.Clear();
                    }
                    
                }
            }
        }

        private void TxtNum_Click(object sender, EventArgs e)
        {
            TxtNum.Clear();
            LblR.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
