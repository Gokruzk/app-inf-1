using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMay3Nums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a,b,c;

        private void TxtN3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                c = int.Parse(TxtN3.Text);
                ClNums obj = new ClNums(a,b,c);
                int r = obj.may3();
                label5.Text = "El número mayor es: " + r.ToString();
                TxtN1.Clear();
                TxtN2.Clear();
                TxtN3.Clear();
                TxtN1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                b = int.Parse(TxtN2.Text);
                TxtN3.Focus();
            }
        }

        private void TxtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                a = int.Parse(TxtN1.Text);
                TxtN2.Focus();
            }
        }
    }
}
