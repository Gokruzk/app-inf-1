using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAplicacion
{
    public partial class CalcSecs : Form
    {
        public CalcSecs()
        {
            InitializeComponent();
        }

        private int CalcularSegundos(DateTime fecha)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - fecha;
            int segundos = (int)tiempoTranscurrido.TotalSeconds;
            return segundos;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                DateTime fechaSeleccionada = dateTimePicker1.Value;
                int segundosTranscurridos = CalcularSegundos(fechaSeleccionada);
                LblCalc.Text = "Segundos transcurridos\ndesde " + fechaSeleccionada + "\nhasta " + dateTime + "\n" + segundosTranscurridos.ToString() + " segundos";
                LblCalc.Visible = true;
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
