using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCompraInteractiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChVest_CheckedChanged(object sender, EventArgs e)
        {
            if(ChVest.Checked)
            {
                PbxVest.Visible = true;
            }
            else
            {
                PbxVest.Visible = false;
            }
        }

        private void ChPants_CheckedChanged(object sender, EventArgs e)
        {
            if (ChPants.Checked)
            {
                PbxPant.Visible = true;
            }
            else
            {
                PbxPant.Visible = false;
            }
        }

        private void ChShirt_CheckedChanged(object sender, EventArgs e)
        {
            if (ChShirt.Checked)
            {
                PbxBlusa.Visible = true;
            }
            else
            {
                PbxBlusa.Visible = false;
            }
        }

        private void RdbFem_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbFem.Checked)
            {
                PbxGen.Image = System.Drawing.Image.FromFile("C:\\Users\\nigel\\Downloads\\fem.png");
            }
            else
            {
                PbxGen.Image = System.Drawing.Image.FromFile("C:\\Users\\nigel\\Downloads\\mas.png");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: PbxLista.Image = Image.FromFile("C:\\Users\\nigel\\Downloads\\vestido2.jpg"); 
                    break;
                case 1:
                    PbxLista.Image = Image.FromFile("C:\\Users\\nigel\\Downloads\\pant.jpg");
                    break;
                case 2:
                    PbxLista.Image = Image.FromFile("C:\\Users\\nigel\\Downloads\\blusa.jpg");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    PbxLista.Image = Image.FromFile("C:\\Users\\nigel\\Downloads\\vestido2.jpg");
                    break;
                case 1:
                    PbxLista.Image = Image.FromFile("C:\\Users\\nigel\\Downloads\\pant.jpg");
                    break;
                case 2:
                    PbxLista.Image = Image.FromFile("C:\\Users\\nigel\\Downloads\\blusa.jpg");
                    break;
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int filas = dataGridView1.Rows.Count - 1;
            dataGridView1[0, filas-1].Value = TxtName.Text;
            dataGridView1[1, filas - 1].Value = TxtLastName.Text;
            dataGridView1[2, filas - 1].Value = listBox1.SelectedItem.ToString();
        }
    }
}
