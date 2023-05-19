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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            dataSet11.ReadXml(path + "\\data.xml");

            DataRow[] vecData;
            DataRow[] data;

            vecData = dataSet11.TblData.Select("Codigo='" + textBox1.Text + "'");
            data = vecData;

            if (vecData.Length > 0)
            {
                UpdateForm obj = new UpdateForm(vecData);
                if(obj.ShowDialog() == DialogResult.OK)
                {
                    obj.Devolver(data);
                    data[0].AcceptChanges();
                    MessageBox.Show("Datos modificados", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataSet11.WriteXml(path + "\\data.xml");
                }
                else
                {
                    MessageBox.Show("No se modificaron los datos", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra el usuario", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
