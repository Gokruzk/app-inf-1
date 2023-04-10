using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Media;

namespace WinAppMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmboxCursor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmboxCursor.SelectedIndex)
            {
                case 0:
                    Cursor = Cursors.AppStarting;
                    break;
                case 1:
                    Cursor = Cursors.Arrow;
                    break;
                case 2:
                    Cursor = Cursors.Cross;
                    break;
                case 3:
                    Cursor = Cursors.Default;
                    break;
                case 4:
                    Cursor = Cursors.PanSouth;
                    break;
            }
        }

        private void BtnBeep_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void BtnExclam_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void BtnCallWin_Click(object sender, EventArgs e)
        {
            FrmCaraFeliz objCaraUwU = new FrmCaraFeliz();
            objCaraUwU.Show();
        }
    }
}
