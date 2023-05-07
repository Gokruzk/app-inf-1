using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDatagridview
{
    public partial class Form2 : Form
    {
        public Form2(DataGridView dataGridView)
        {
            InitializeComponent();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row.Index].Cells["Column1"].Value = row.Cells[0].Value;
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
        }
    }
}
