using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml(path + "\\data.xml");
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            dataSet1.Clear();
            dataSet1.ReadXml(path + "\\data.xml");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngreso obj = new FormIngreso();
            obj.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscar obj = new FrmBuscar(0);
            obj.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscar obj = new FrmBuscar(1);
            obj.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscar obj = new FrmBuscar(2);
            obj.ShowDialog();
        }

        private void reporteEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte obj = new FrmReporte();
            obj.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path + "\\AYUDA.htm");
        }
    }
}
