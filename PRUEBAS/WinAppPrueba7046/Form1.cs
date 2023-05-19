using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPrueba7046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            MenuForm obj = new MenuForm();
            obj.ShowDialog();
        }
    }
}