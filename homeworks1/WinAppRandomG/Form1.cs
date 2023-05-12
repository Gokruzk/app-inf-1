using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRandomG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int attempts = 0;
        int num = 0;
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            TxtNum.Enabled = true;
            TxtNum.Clear();
            LblWinLose.Text = "";
            attempts = 10;
            LblAttempt.Text = attempts.ToString();
            Random rnd = new Random();
            num = rnd.Next(1, 51);
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    int n = int.Parse(TxtNum.Text);
                    if (n <= 0 || n >= 101)
                    {
                        MessageBox.Show("Ingrese un número mayor a 0 y menor a 51", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNum.Clear();
                    }
                    else
                    {
                        if (attempts > 0)
                        {
                            if (n == num)
                            {
                                LblWinLose.Text = "FELICIDADES HAS GANADO!!";
                                TxtNum.Enabled = false;
                            }
                            else if (n < num)
                            {
                                attempts -= 1;
                                MessageBox.Show("Sigue intentado, el número es mayor", "Juega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtNum.Clear();
                            }
                            else
                            {
                                attempts -= 1;
                                MessageBox.Show("Sigue intentado, el número es menor", "Juega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtNum.Clear();
                            }
                            LblAttempt.Text = attempts.ToString();
                        }
                        else
                        {
                            LblWinLose.Text = "Se acabaron los intentos :c\nEl número era " + num;
                            TxtNum.Enabled = false;
                            TxtNum.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNum.Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtNum.Enabled = false;
        }
    }
}
