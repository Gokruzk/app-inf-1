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

namespace WinAppIndividuales
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath;
        string file1 = "espochLogo.png";
        public Form1()
        {
            InitializeComponent();
            string pic = Path.Combine(path, file1);
            pictureBox1.Image = Image.FromFile(pic);
        }

        private void BtnCantCifras_Click(object sender, EventArgs e)
        {
            WinAppCantCifras.Form1 obj = new WinAppCantCifras.Form1();
            obj.ShowDialog();
        }

        private void BtnVolPiram_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form1 obj = new WindowsFormsApp1.Form1();
            obj.ShowDialog();
        }

        private void BtnAreaTerreno_Click(object sender, EventArgs e)
        {
            WinAppAreaTerrreno.Form1 obj = new WinAppAreaTerrreno.Form1();
            obj.ShowDialog();
        }

        private void BtnNextNum_Click(object sender, EventArgs e)
        {
            WinAppNextNum.Form1 obj = new WinAppNextNum.Form1();
            obj.ShowDialog();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            WinAppCalc.Form1 obj = new WinAppCalc.Form1();
            obj.ShowDialog();
        }

        private void BtnHab_Click(object sender, EventArgs e)
        {
            WinAppHab.Form1 obj = new WinAppHab.Form1();
            obj.ShowDialog();
        }

        private void BtnNextSec_Click(object sender, EventArgs e)
        {
            WinAppNextSec.Form1 obj = new WinAppNextSec.Form1();
            obj.ShowDialog();
        }

        private void BtnRandomGame_Click(object sender, EventArgs e)
        {
            WinAppRandomG.Form1 obj = new WinAppRandomG.Form1();
            obj.ShowDialog();
        }

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            WinAppCompraInteractiva.Form1 obj = new WinAppCompraInteractiva.Form1();
            obj.ShowDialog();
        }

        private void BtnDados_Click(object sender, EventArgs e)
        {
            WinAppDados.Form1 obj = new WinAppDados.Form1();
            obj.ShowDialog();
        }

        private void BtnTriang_Click(object sender, EventArgs e)
        {
            WinAppTriang.Form1 obj = new WinAppTriang.Form1();
            obj.ShowDialog();
        }

        private void BtnSerie_Click(object sender, EventArgs e)
        {
            WinAppSerie.Form1 obj = new WinAppSerie.Form1();
            obj.ShowDialog();
        }

        private void BtnSizes_Click(object sender, EventArgs e)
        {
            WinAppSizeTable.Form1 obj = new WinAppSizeTable.Form1();
            obj.ShowDialog();
        }

        private void BtnDivisiones_Click(object sender, EventArgs e)
        {
            WinAppRestoDividendo.Form1 obj = new WinAppRestoDividendo.Form1();
            obj.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            WinAppArray.Form1 obj = new WinAppArray.Form1();
            obj.ShowDialog();
        }

        private void BtnMatriz_Click(object sender, EventArgs e)
        {
            WinAppDiagSuperiorInferior.Form1 obj = new WinAppDiagSuperiorInferior.Form1();
            obj.ShowDialog();
        }

        private void BtnInterfaceVoz_Click(object sender, EventArgs e)
        {
            WinAppVoiceImages.Form1 obj = new WinAppVoiceImages.Form1();
            obj.ShowDialog();
        }

        private void BtnEditor_Click(object sender, EventArgs e)
        {
            WinAppEditor.Form1 obj = new WinAppEditor.Form1();
            obj.ShowDialog();
        }

        private void BtnVotos_Click(object sender, EventArgs e)
        {
            WinAppVotos.Form1 obj = new WinAppVotos.Form1();
            obj.ShowDialog();
        }

        private void BtnStrings_Click(object sender, EventArgs e)
        {
            WinAppCadena.Form1 obj = new WinAppCadena.Form1();
            obj.ShowDialog();
        }
    }
}
