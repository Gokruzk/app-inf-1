using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using CEntidades;
using CLogica;

namespace CPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        COperaciones objOP = new COperaciones();

        public void RefreshDataGrid(DataGridView d)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                adp = objOP.SearchDataAll();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("No hay datos", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void StripIngresar_Click(object sender, EventArgs e)
        {
            FrmRegister obj = new FrmRegister();
            obj.ShowDialog();
        }

        private void StripEliminar_Click(object sender, EventArgs e)
        {
            FrmDelete obj = new FrmDelete();
            obj.ShowDialog();
        }

        private void StripBuscar_Click(object sender, EventArgs e)
        {
            FrmSearch obj = new FrmSearch();
            obj.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void StripUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdate obj = new FrmUpdate();
            obj.ShowDialog();
        }

        private void StripReport_Click(object sender, EventArgs e)
        {
            FrmReport obj = new FrmReport();
            obj.ShowDialog();
        }
    }
}
