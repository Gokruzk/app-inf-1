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

namespace CPresentacion
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        COperaciones objOP = new COperaciones();
        Entidades objEnt = new Entidades();

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                TxtId.Enabled = false;
                TxtName.Enabled = true;
                TxtLastName.Enabled = true;
                int id = int.Parse(TxtId.Text);
                objEnt = objOP.SearchData(id);

                if (objEnt.NombreE == null)
                {
                    MessageBox.Show("No se encontró al estudiante", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TxtName.Text = objEnt.NombreE.ToString();
                    TxtLastName.Text = objEnt.ApellidoE.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un id de estudiante", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtId.Text);
                objEnt.NombreE = TxtName.Text;
                objEnt.ApellidoE = TxtLastName.Text;
                objOP.UpdateData(objEnt);
                //MessageBox.Show("No se encontró al estudiante", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Información de estudiante actualizada", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtId.Enabled = true;
                TxtName.Enabled = false;
                TxtLastName.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ingrese un id de estudiante", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtId.Enabled = true;
            TxtName.Enabled = false;
            TxtLastName.Enabled = false;
            TxtId.Clear();
            TxtName.Clear();
            TxtLastName.Clear();
        }
    }
}
