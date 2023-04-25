using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp7Afortunado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PbxWin.Visible = false;
            BtnReset.Visible = false;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            Lbl1.Text = objRandom.Next(1,8).ToString();
            Lbl2.Text = objRandom.Next(1, 8).ToString();
            Lbl3.Text = objRandom.Next(1, 8).ToString();
            if(Lbl1.Text == "7" || Lbl2.Text == "7" || Lbl3.Text == "7")
            {
                PbxWin.Visible = true;
                BtnPlay.Enabled = false;
                BtnReset.Visible = true;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Lbl3.Text = "";
            Lbl2.Text = "";
            Lbl1.Text = "";
            BtnPlay.Enabled = true;
            PbxWin.Visible = false;
            BtnReset.Visible = false;
        }
    }
}
