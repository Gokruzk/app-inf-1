using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entity;
using CLogic;

namespace CPresentation
{
    public partial class ShowProductoForm : Form
    {
        public ShowProductoForm()
        {
            InitializeComponent();
        }
        ClOperations objOP = new ClOperations();
        public void RefreshDataGrid(DataGridView d)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                adp = objOP.MostrarProduct();
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

        private void ShowProductoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datosProducDataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.datosProducDataSet.Productos);

        }
    }
}
