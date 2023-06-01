using CEntidades;
using CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CPresentacion
{
    public partial class FrmDelete : Form
    {
        public FrmDelete()
        {
            InitializeComponent();
        }

        COperaciones objOP = new COperaciones();
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtId.Text);
                objOP.DeleteData(id);
                MessageBox.Show("Estudiante eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnDelete_Click(sender, e);
            }
        }
    }
}
