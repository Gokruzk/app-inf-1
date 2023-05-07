using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath;
        string file = "piram.jpg";
        double altura, bse;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string root = Path.Combine(path, file);
            BackgroundImage = Image.FromFile(root);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    altura = double.Parse(TxtAltura.Text);
                    TxtBase.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtAltura.Clear();
                }
            }
        }

        private void TxtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    bse = double.Parse(TxtBase.Text);
                    ClVolPiram obj = new ClVolPiram(bse, altura);
                    LblMsj.Text = "El volúmen de la pirámide es: " + obj.CalcVol().ToString();
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtBase.Clear();
                }
            }
        }
    }
}
