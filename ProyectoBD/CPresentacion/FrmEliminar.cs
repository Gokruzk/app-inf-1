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
    public partial class FrmEliminar : Form
    {
        public FrmEliminar()
        {
            InitializeComponent();
        }

        COperaciones objOP = new COperaciones();
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            objOP.DeleteData(id);
        }
    }
}
