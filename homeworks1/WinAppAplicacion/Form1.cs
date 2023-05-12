using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void StripExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego...", "Chao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BtnHours_Click(object sender, EventArgs e)
        {
            if (Panel.Controls.Count > 0)
                Panel.Controls.RemoveAt(0);

            WorldHours worldHour = new WorldHours();

            worldHour.TopLevel = false;
            worldHour.Dock = DockStyle.Fill;

            Panel.Controls.Add(worldHour);
            Panel.Tag = worldHour;

            worldHour.Show();
        }

        private void BtnCalcSec_Click(object sender, EventArgs e)
        {
            if (Panel.Controls.Count > 0)
                Panel.Controls.RemoveAt(0);
                
            CalcSecs calcSecs = new CalcSecs();

            calcSecs.TopLevel = false;
            calcSecs.Dock = DockStyle.Fill;

            Panel.Controls.Add(calcSecs);
            Panel.Tag = calcSecs;

            calcSecs.Show();
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (Panel.Controls.Count > 0)
                Panel.Controls.RemoveAt(0);

            PathForm pathForm= new PathForm();

            pathForm.TopLevel = false;
            pathForm.Dock = DockStyle.Fill;

            Panel.Controls.Add(pathForm);
            Panel.Tag = pathForm;

            pathForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = "Hora del sistema: " + DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
