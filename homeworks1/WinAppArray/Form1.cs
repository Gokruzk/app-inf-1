using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppArray
{
    public partial class Form1 : Form
    {
        int n = 0, i = 0;
        int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    n = int.Parse(TxtSize.Text);
                    if (n <= 0)
                    {
                        MessageBox.Show("Ingrese un número positivo", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        TxtNums.Enabled = true;
                        SortDesc.Enabled = false;
                        FindDelete.Enabled = false;
                        ReadFind.Enabled = false;
                        LblFind.Visible = false;
                        TxtNumFind.Visible = false;
                        listBox1.Items.Clear();
                        i = 0;
                        array = new int[n];
                        TxtNums.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    n = int.Parse(TxtNums.Text);
                    array[i] = n;
                    listBox1.Items.Add(array[i].ToString());
                    listBox1.Show();
                    i++;
                    TxtNums.Clear();
                    if (i == array.Length)
                    {
                        MessageBox.Show("El vector éstá lleno", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNums.Enabled = false;
                        SortDesc.Enabled = true;
                        ReadFind.Enabled = true;
                        FindDelete.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReadFind_Click(object sender, EventArgs e)
        {
            LblFind.Visible = true;
            TxtNumFind.Visible = true;
            TxtNumFind.Focus();
        }

        private void TxtNumFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    int n = int.Parse(TxtNumFind.Text);
                    int sz = array.Length;
                    ClArray obj = new ClArray(array, sz);
                    int pos = obj.BuscarElemento(n);
                    if (pos == -1)
                    {
                        MessageBox.Show("El número no se encontró", "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtNumFind.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El número se encuentra en la posición: " + pos, "BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNumFind.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FindDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int sz = array.Length;
                ClArray obj = new ClArray(array, sz);
                obj.FindMin();
                obj.DeleteMin(ref sz);
                int min = obj.GetMin();
                int posMin = obj.GetPosMin();
                listBox1.Items.Clear();
                for (int i = 0; i < sz; i++)
                {
                    listBox1.Items.Add(array[i].ToString());
                    listBox1.Show();
                }
                MessageBox.Show("Elemento " + min + " eliminado, de la posición " + posMin, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortDesc_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int sz = array.Length;
                ClArray obj = new ClArray(array, sz);
                obj.SortDesc();
                for (int i = 0; i < sz; i++)
                {
                    listBox1.Items.Add(array[i].ToString());
                    listBox1.Show();
                }
                MessageBox.Show("Vector ordenado con éxito", "Ordenamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
