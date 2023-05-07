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
    public partial class Form1 : Form
    {
        Random num = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(3);
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    dataGridView1[j, i].Value = num.Next(0, 10).ToString();
                }
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2(dataGridView1);
            obj.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}
