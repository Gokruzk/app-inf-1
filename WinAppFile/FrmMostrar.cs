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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar(System.Data.DataRow[] data)
        {
            InitializeComponent();
            LblCode.Text += data[0]["Codigo"].ToString();
            LblName.Text += data[0]["Nombre"].ToString();
            LblLastName.Text += data[0]["Apellido"].ToString();
            LblAge.Text += data[0]["Edad"].ToString();
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
