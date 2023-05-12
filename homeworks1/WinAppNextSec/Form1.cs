using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppNextSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime obj = new DateTime();
        private void BtnNextSec_Click(object sender, EventArgs e)
        {
            try
            {
                string date = TxtHour.Text;
                string q = TxtHour.Text[0] + "" + TxtHour.Text[1];
                string r = TxtHour.Text[3] + "" + TxtHour.Text[4];
                string s = TxtHour.Text[6] + "" + TxtHour.Text[7];
                int n1 = int.Parse(q), n2 = int.Parse(r), n3 = int.Parse(s);
                obj = new DateTime(1, 1, 1, n1, n2, n3);
                LblNextH.Text = obj.AddSeconds(1).ToString("HH:mm:ss");
                TxtHour.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un número o siga el formato especificado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtHour.Clear();
            }
        }

        private void TxtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                BtnNextSec_Click(sender, e);
            }
        }
    }
}
