using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            InsertProductForm obj = new InsertProductForm();
            obj.ShowDialog();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ShowProductoForm obj = new ShowProductoForm();
            obj.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteProductForm obj = new DeleteProductForm();
            obj.ShowDialog();
        }

        private void BtnWebPage_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            System.Diagnostics.Process.Start(path);
        }
    }
}
