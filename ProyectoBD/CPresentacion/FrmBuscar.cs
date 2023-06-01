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
using CEntidades;
using CLogica;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace CPresentacion
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }
        COperaciones objOP = new COperaciones();
        Entidades objEnt = new Entidades();

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtId.Text);
                objEnt = objOP.SearchData(id);
                
                if(objEnt.NombreE == null)
                {
                    MessageBox.Show("No se encontró al estudiante", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{
                    TxtName.Text = objEnt.NombreE.ToString();
                    TxtLastName.Text = objEnt.ApellidoE.ToString();

                }
            }
            catch
            {
                MessageBox.Show("Ingrese un id de estudiante", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnSearch_Click(sender, e);
            }
        }
    }
}
