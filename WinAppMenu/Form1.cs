using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MnuCerrar.Enabled = false;
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnuAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "bmp|*.bmp|jpg|*.jpg|docx|*.docx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbxFoto.Image = Image.FromFile(openFileDialog1.FileName);
                MnuCerrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No seleccionó una imagen", "ERROR");
            }
        }

        private void MnuCerrar_Click(object sender, EventArgs e)
        {
            PbxFoto.Image = null;
            MnuCerrar.Enabled = false;
        }

        private void alTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            LblMsj.ForeColor = colorDialog1.Color;
        }

        private void alFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            LblMsj.BackColor = colorDialog1.Color;
        }

        private void alFondoYTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            LblMsj.BackColor = colorDialog1.Color;
            colorDialog1.ShowDialog();
            LblMsj.ForeColor = colorDialog1.Color;
        }

        private void horaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString();
        }

        private void aUnFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSadFace obj = new FrmSadFace();
            obj.ShowDialog();
        }

        private void aOtroProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WinAppCalc.Form1 obj = new WinAppCalc.Form1();
            //obj.ShowDialog();
        }
    }
}
