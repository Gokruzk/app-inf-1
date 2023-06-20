using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLogic;
using Entity;

namespace CPresentation
{
    public partial class InsertProductForm : Form
    {
        string name;
        int cant = 0;
        int iva = 0;
        int price = 0;
        float totalPrice = 0;
        public InsertProductForm()
        {
            InitializeComponent();
        }
        Producto pData = new Producto();
        ClOperations objOP = new ClOperations();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            objOP.InsertProduct(pData);
            MessageBox.Show("Producto agregado", "Éxisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    name = TxtName.Text;
                    if (name == "")
                    {
                        MessageBox.Show("Ingrese un nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pData.NombrePro = name;
                        TxtPrecio.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    price = int.Parse(TxtPrecio.Text);
                    if (price >= 1 && price <= 10)
                    {
                        pData.Precio = price;
                        TxtCant.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El precio debe estar entre 1 y 10", "Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("Ingrese un precio", "Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    cant = int.Parse(TxtCant.Text);
                    pData.Cantidad = cant;
                    TxtIva.Focus();

                }
                catch
                {
                    MessageBox.Show("Ingrese una cantidad", "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    iva = int.Parse(TxtIva.Text);
                    if (iva >= 0 && iva <= 12)
                    {
                        pData.Iva = iva;
                        pData.TotalPrecio = pData.Precio * (iva / 100) + pData.Precio * pData.Cantidad;
                        TxtTotal.Text = pData.TotalPrecio.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El iva debe estar entre 0 y 12", "Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("Ingrese el iva", "IVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
