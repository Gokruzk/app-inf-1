using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppFile
{
    public partial class UpdateForm : Form
    {
        public UpdateForm(DataRow[] data)
        {
            InitializeComponent();
            TxtCode.Text = data[0]["Codigo"].ToString();
            TxtName.Text = data[0]["Nombre"].ToString();
            TxtLastName.Text = data[0]["Apellido"].ToString();
            TxtAge.Text = data[0]["Edad"].ToString();
        }

        public void Devolver(DataRow[] data)
        {
            data[0]["Codigo"] = TxtCode.Text;
            data[0]["Nombre"] = TxtName.Text;
            data[0]["Apellido"] = TxtLastName.Text;
            data[0]["Edad"] = TxtAge.Text;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            dataSet11.ReadXml(path + "\\data.xml");
            DataRow[] data;

            data = dataSet11.TblData.Select("Codigo='" + TxtCode.Text + "'");

            if (data.Length > 0)
            {
                TxtName.Text = data[0]["Nombre"].ToString();
                TxtLastName.Text = data[0]["Apellido"].ToString();
                TxtAge.Text = data[0]["Edad"].ToString();
            }
            else
            {
                MessageBox.Show("No se encuentra el usuario", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
