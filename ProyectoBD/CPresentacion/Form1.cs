using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CEntidades;
using CLogica;

namespace CPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        COperaciones objOp = new COperaciones();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eSTUDIANTEDataSet.TblDatos' table. You can move, or remove it, as needed.
            this.tblDatosTableAdapter.Fill(this.eSTUDIANTEDataSet.TblDatos);

            //List<Entidades> DatosEstu
        }

        private void StripIngresar_Click(object sender, EventArgs e)
        {
            FrmIngresar obj = new FrmIngresar();
            obj.ShowDialog();
        }

        private void StripEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminar obj = new FrmEliminar();
            obj.ShowDialog();
        }

        private void StripBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar obj = new FrmBuscar();
            obj.ShowDialog();
        }
    }
}
