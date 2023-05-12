using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinAppAplicacion
{
    public partial class WorldHours : Form
    {
        public WorldHours()
        {
            InitializeComponent();
        }

        private void GuardarDatosEnArchivo()
        {
            string directoryPath = "";
            try
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    saveFileDialog1.Filter = ".txt|*.txt";
                    saveFileDialog1.Title = "Guardar archivo de datos";
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {
                            string filePath = saveFileDialog1.FileName;
                            directoryPath = Path.GetDirectoryName(filePath);
                            // Obtener los encabezados de las columnas
                            foreach (DataGridViewColumn columna in dataGridView1.Columns)
                            {
                                sw.Write(columna.HeaderText + "\t");
                            }
                            sw.WriteLine();

                            // Obtener los datos de las filas
                            foreach (DataGridViewRow fila in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell celda in fila.Cells)
                                {
                                    if (celda.Value != null)
                                    {
                                        sw.Write(celda.Value.ToString() + "\t");
                                    }
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Coloque un nombre al archivo");
                    }

                    string rutaArchivo = Application.StartupPath + "\\path.txt";
                    File.Delete(rutaArchivo);

                    // Crear un objeto StreamWriter para escribir en el archivo.
                    using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
                    {

                        // Escribir los datos en el archivo.
                        escritor.WriteLine(
                            directoryPath
                        );
                    }
                    MessageBox.Show("Archivo guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No hay ciduades agregadas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Error al guardar datos en archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private DateTime CalcularHoraEnOtroPais(string city)
        {
            DateTime horaActual = DateTime.Now;
            TimeZoneInfo zonaPais = TimeZoneInfo.FindSystemTimeZoneById(city);
            DateTime horaEnPais = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(horaActual, TimeZoneInfo.Local.Id, zonaPais.Id);
            return horaEnPais;
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int progress = 0;
                ProBar.Visible = true;
                ProBar.MarqueeAnimationSpeed = 5;
                while (progress >= 0 && progress <= 100)
                {
                    progress += 1;
                    if (progress < 101)
                    {
                        ProBar.Value = progress;
                    }
                }
                string city = CmbCountry.Text;
                string cityName = city;
                switch (city)
                {
                    case "Nueva York": city = "Eastern Standard Time"; break;
                    case "Londres": city = "GMT Standard Time"; break;
                    case "Berlín": city = "W. Europe Standard Time"; break;
                    case "Tokio": city = "Tokyo Standard Time"; break;
                    case "Sídney": city = "AUS Eastern Standard Time"; break;
                    case "Toronto": city = "Eastern Standard Time"; break;
                }
                DateTime hora = CalcularHoraEnOtroPais(city);
                dataGridView1.Rows.Add();
                int filas = dataGridView1.Rows.Count - 1;
                dataGridView1[0, filas - 1].Value = cityName;
                dataGridView1[1, filas - 1].Value = hora.ToString("HH:mm:ss");
                MessageBox.Show("Ciudad agregada", "Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar hora", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GuardarDatosEnArchivo();
        }
    }
}
