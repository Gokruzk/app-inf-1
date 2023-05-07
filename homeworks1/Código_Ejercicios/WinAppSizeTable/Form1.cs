using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSizeTable
{
    public partial class Form1 : Form
    {
        int sz = 84 - 48;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                double c = 0;
                for (int i = 0; i <= sz; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = i + 48;
                    dataGridView1[1, i].Value = (i + 48) * 2.54;
                }
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
