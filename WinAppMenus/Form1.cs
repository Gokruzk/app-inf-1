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
                    Cursor = Cursors.Hand;
                    break;
                case 5:
                    Cursor = Cursors.Help;
                    break;
                case 6:
                    Cursor = Cursors.HSplit;
                    break;
                case 7:
                    Cursor = Cursors.IBeam;
                    break;
                case 8:
                    Cursor = Cursors.No;
                    break;
                case 9:
                    Cursor = Cursors.NoMove2D;
                    break;
                case 10:
                    Cursor = Cursors.NoMoveHoriz;
                    break;
                case 11:
                    Cursor = Cursors.NoMoveVert;
                    break;
                case 12:
                    Cursor = Cursors.PanEast;
                    break;
                case 13:
                    Cursor = Cursors.PanNE;
                    break;
                case 14:
                    Cursor = Cursors.PanNorth;
                    break;
                case 15:
                    Cursor = Cursors.PanSouth;
                    break;
                case 16:
                    Cursor = Cursors.PanSW;
                    break;
                case 17:
                    Cursor = Cursors.PanWest;
                    break;
                case 18: Cursor = Cursors.SizeAll; break;
                case 19:
                    Cursor = Cursors.SizeNESW;
                    break;
                case 20:
                    Cursor = Cursors.SizeNS;
                    break;
                case 21:
                    Cursor = Cursors.SizeNWSE;
                    break;
                case 22:
                    Cursor = Cursors.SizeWE;
                    break;
                case 23:
                    Cursor = Cursors.UpArrow;
                    break;
                case 24:
                    Cursor = Cursors.VSplit;
                    break;
                case 25:
                    Cursor = Cursors.WaitCursor;
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
