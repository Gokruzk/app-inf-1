using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsj.Visible = false;
            TxtAltura.Text = "0";
            TxtBase.Text = "0";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            LblMsj.Visible = true;
            double altura = double.Parse(TxtAltura.Text);
            double basep = double.Parse(TxtBase.Text);
            ClVolPiram obj = new ClVolPiram(basep, altura);
            LblMsj.Text = "El volúmen de la pirámide es: " + obj.CalcVol().ToString();
        }
    }
}
