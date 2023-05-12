using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAplicacion
{
    public partial class PathForm : Form
    {
        public PathForm()
        {
            InitializeComponent();
        }

        private void CargarRutaEnTreeView(string ruta)
        {
            // Limpiar el TreeView
            treeView1.Nodes.Clear();

            // Agregar el nodo raíz con el nombre de la ruta
            TreeNode rootNode = new TreeNode(ruta);
            treeView1.Nodes.Add(rootNode);

            // Llamar a un método recursivo para cargar los directorios y archivos dentro del nodo raíz
            CargarDirectoriosEnTreeView(ruta, rootNode);
        }

        private void CargarDirectoriosEnTreeView(string ruta, TreeNode parentNode)
        {
            try
            {
                // Obtener la lista de directorios en la ruta actual
                string[] directorios = Directory.GetDirectories(ruta);

                // Recorrer cada directorio y agregarlo como un nuevo nodo hijo
                foreach (string directorio in directorios)
                {
                    string nombreDirectorio = Path.GetFileName(directorio);
                    TreeNode directoryNode = new TreeNode(nombreDirectorio);
                    parentNode.Nodes.Add(directoryNode);

                    // Llamar recursivamente a este método para cargar los directorios dentro del directorio actual
                    CargarDirectoriosEnTreeView(directorio, directoryNode);
                }

                // Obtener la lista de archivos en la ruta actual
                string[] archivos = Directory.GetFiles(ruta);

                // Recorrer cada archivo y agregarlo como un nuevo nodo hijo
                foreach (string archivo in archivos)
                {
                    string nombreArchivo = Path.GetFileName(archivo);
                    TreeNode fileNode = new TreeNode(nombreArchivo);
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la carga de directorios y archivos
                MessageBox.Show("Error al cargar la ruta en el TreeView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PathForm_Load(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                string rutaArchivo = Application.StartupPath + "\\path.txt";

                // Crear un objeto StreamReader para leer el archivo.
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    // Leer todas las líneas del archivo.
                        path = lector.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error al obtener rutas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarRutaEnTreeView(path);
        }
    }
}
            //MessageBox.Show(path);
