using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppKeyPressEnter
{
    public partial class Form1 : Form
    {
        string name, lastName, age;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                name = TxtName.Text + " ";
                TxtLastNam.Focus();
            }
        }

        private void TxtLastNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lastName = TxtLastNam.Text + " ";
                TxtAge.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblHi.Visible = false;
        }

        private void TxtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                age = TxtAge.Text;
                LblHi.Visible = true;
                LblHi.Text = name + lastName + age;
                TxtName.Clear();
                TxtLastNam.Clear();
                TxtAge.Clear();
                TxtName.Focus();
            }
        }
    }
}