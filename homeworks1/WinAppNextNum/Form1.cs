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
            if(e.KeyChar == (char)Keys.Enter)
            {
                num += TxtN1.Text[0];
                TxtN2.Focus();
            }
        }

        private void TxtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                num += TxtN2.Text[1];
                TxtN3.Focus();
            }
        }

        private void TxtN3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                num += TxtN3.Text[2];
                TxtN4.Focus();
            }
        }

        private void TxtN4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                num += TxtN4.Text[3];
                TxtN5.Focus();
            }
        }

        private void TxtN5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                num += TxtN5.Text[4];
                LblRes.Text += num;
                TxtN1.Clear();
                TxtN2.Clear();
                TxtN3.Clear();
                TxtN4.Clear();
                TxtN5.Clear();
            }
        }
    }
}
