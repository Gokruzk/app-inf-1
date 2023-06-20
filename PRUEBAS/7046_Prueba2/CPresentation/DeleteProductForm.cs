using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using CLogic;

namespace CPresentation
{
    public partial class DeleteProductForm : Form
    {
        public DeleteProductForm()
        {
            InitializeComponent();
        }
        ClOperations objOP = new ClOperations();
        Producto pData = new Producto();
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtID.Text);
                pData = objOP.SearchProduct(id);
                if (pData == null)
                {
                    MessageBox.Show("No existe el producto", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TxtName.Text = pData.NombrePro;
                    TxtPrecio.Text = pData.Precio.ToString();
                    TxtCant.Text = pData.Cantidad.ToString();
                    TxtIva.Text = pData.Iva.ToString();
                    TxtTotal.Text = pData.TotalPrecio.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un ID", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtID.Text);
                objOP.DeleteProduct(id);
                MessageBox.Show("Producto eliminado", "ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ingrese un ID", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProductForm_Load(object sender, EventArgs e)
        {
            TxtID.Focus();
        }
    }
}
