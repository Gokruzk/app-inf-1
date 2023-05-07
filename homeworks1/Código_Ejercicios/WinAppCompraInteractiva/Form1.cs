using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinAppCompraInteractiva
{
    public partial class Form1 : Form
    {
        string paths = Application.StartupPath;
        string file = "blusa.jpg";
        string file2 = "vestido.jpg";
        string file3 = "pants.jpg";
        string file4 = "fem.png";
        string file5 = "mas.png";
        string pathFile1;
        string pathFile2;
        string pathFile3;
        double[] precios = new double[3];
        double precio = 0;
        double sub = 0;
        double iva = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
            precios[0] = 12.99;
            precios[1] = 10.99;
            precios[2] = 11.99;
        }

        private void ChVest_CheckedChanged(object sender, EventArgs e)
        {
            pathFile2 = Path.Combine(paths, file2);
            try
            {
                if (ChVest.Checked)
                {
                    LblPrecio.Text = "$ " + precios[0];
                    precio = precios[0];
                    PbxClothes.Image = Image.FromFile(pathFile2);
                    ChPants.Enabled = false;
                    ChShirt.Enabled = false;
                }
                else
                {
                    PbxClothes.Image = null;
                    ChPants.Enabled = true;
                    ChShirt.Enabled = true;
                    LblPrecio.Text = "$";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChPants_CheckedChanged(object sender, EventArgs e)
        {
            pathFile3 = Path.Combine(paths, file3);
            if (ChPants.Checked)
            {
                LblPrecio.Text = "$ " + precios[1];
                precio = precios[1];
                PbxClothes.Image = Image.FromFile(pathFile3);
                ChVest.Enabled = false;
                ChShirt.Enabled = false;
            }
            else
            {
                PbxClothes.Image = null;
                ChVest.Enabled = true;
                ChShirt.Enabled = true;
                LblPrecio.Text = "$";
            }
        }

        private void ChShirt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pathFile1 = Path.Combine(paths, file);
                if (ChShirt.Checked)
                {
                    LblPrecio.Text = "$ " + precios[2];
                    precio = precios[2];
                    PbxClothes.Image = Image.FromFile(pathFile1);
                    ChVest.Enabled = false;
                    ChPants.Enabled = false;
                }
                else
                {
                    PbxClothes.Image = null;
                    ChVest.Enabled = true;
                    ChPants.Enabled = true;
                    LblPrecio.Text = "$";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdbFem_CheckedChanged(object sender, EventArgs e)
        {
            string pathFile4 = Path.Combine(paths, file4);
            string pathFile5 = Path.Combine(paths, file5);
            if (RdbFem.Checked)
            {
                PbxGen.Image = Image.FromFile(pathFile4);
            }
            else
            {
                PbxGen.Image = Image.FromFile(pathFile5);
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string lastName = TxtLastName.Text;
            if (dataGridView1.Rows.Count > 1)
            {
                MessageBox.Show("Gracias por tu compra " + name + " " + lastName, "GRACIAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChVest.Enabled = true;
                ChVest.Checked = false;
                ChPants.Enabled = true;
                ChPants.Checked = false;
                ChVest.Enabled = true;
                ChVest.Checked = false;
                PbxClothes.Image = null;
                PbxGen.Image = null;
                LblPrecio.Text = "$ 0.00";
                LblSubt.Text = "Subtotal: ";
                LblIva.Text = "IVA 12%: ";
                LblTotal.Text = "Total: ";
            }
            else
            {
                MessageBox.Show("Debe comprar algo", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sub += precio;
                iva = sub * 0.12;
                total = sub + iva;
                string name = TxtName.Text;
                string lastName = TxtLastName.Text;
                if (name == "" || lastName == "")
                {
                    MessageBox.Show("Ingrese sus nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtName.Focus();
                }
                else if (PbxClothes.Image == null)
                {
                    MessageBox.Show("Seleccione una prenda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView1.Rows.Add();
                    int filas = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, filas - 1].Value = TxtName.Text;
                    dataGridView1[1, filas - 1].Value = TxtLastName.Text;
                    dataGridView1[2, filas - 1].Value = PbxClothes.Image;
                    DataGridViewImageColumn column = (DataGridViewImageColumn)dataGridView1.Columns[2];
                    column.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    ChVest.Enabled = true;
                    ChVest.Checked = false;
                    ChPants.Enabled = true;
                    ChPants.Checked = false;
                    ChVest.Enabled = true;
                    ChVest.Checked = false;
                    PbxClothes.Image = null;
                    PbxGen.Image = null;
                    LblPrecio.Text = "$ 0.00";
                    LblSubt.Text = "Subtotal: " + sub;
                    LblIva.Text = "IVA 12%: " + iva;
                    LblTotal.Text = "Total: " + total;

                }
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtLastName.Focus();
            }
        }
    }
}
