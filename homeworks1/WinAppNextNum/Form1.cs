using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppNextNum
{
    public partial class Form1 : Form
    {
        string num;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num += TxtN1.Text[0];
                    TxtN2.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtN1.Clear();
                }
            }
        }

        private void TxtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num += TxtN2.Text[1];
                    TxtN3.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtN2.Clear();
                }
            }
        }

        private void TxtN3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num += TxtN3.Text[2];
                    TxtN4.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtN3.Clear();
                }
            }
        }

        private void TxtN4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num += TxtN4.Text[3];
                    TxtN5.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtN4.Clear();
                }
            }
        }

        private void TxtN5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num += TxtN5.Text[4];
                    LblRes.Text += num;
                    TxtN1.Clear();
                    TxtN2.Clear();
                    TxtN3.Clear();
                    TxtN4.Clear();
                    TxtN5.Clear();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtN5.Clear();
                }
            }
        }
    }
}
