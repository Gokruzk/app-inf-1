namespace WinAppAplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnHours = new System.Windows.Forms.Button();
            this.BtnCalcSec = new System.Windows.Forms.Button();
            this.BtnSaveFile = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripExit});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // StripExit
            // 
            this.StripExit.Name = "StripExit";
            this.StripExit.Size = new System.Drawing.Size(180, 22);
            this.StripExit.Text = "Salir";
            this.StripExit.Click += new System.EventHandler(this.StripExit_Click);
            // 
            // BtnHours
            // 
            this.BtnHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(128)))), ((int)(((byte)(245)))));
            this.BtnHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHours.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHours.ForeColor = System.Drawing.Color.White;
            this.BtnHours.Location = new System.Drawing.Point(0, 23);
            this.BtnHours.Name = "BtnHours";
            this.BtnHours.Size = new System.Drawing.Size(150, 129);
            this.BtnHours.TabIndex = 3;
            this.BtnHours.Text = "VER HORAS MUNDIALES";
            this.BtnHours.UseVisualStyleBackColor = false;
            this.BtnHours.Click += new System.EventHandler(this.BtnHours_Click);
            // 
            // BtnCalcSec
            // 
            this.BtnCalcSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(128)))), ((int)(((byte)(245)))));
            this.BtnCalcSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcSec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcSec.ForeColor = System.Drawing.Color.White;
            this.BtnCalcSec.Location = new System.Drawing.Point(0, 280);
            this.BtnCalcSec.Name = "BtnCalcSec";
            this.BtnCalcSec.Size = new System.Drawing.Size(150, 130);
            this.BtnCalcSec.TabIndex = 5;
            this.BtnCalcSec.Text = "CALCULAR SEGUNDOS";
            this.BtnCalcSec.UseVisualStyleBackColor = false;
            this.BtnCalcSec.Click += new System.EventHandler(this.BtnCalcSec_Click);
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(128)))), ((int)(((byte)(245)))));
            this.BtnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFile.ForeColor = System.Drawing.Color.White;
            this.BtnSaveFile.Location = new System.Drawing.Point(0, 151);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(150, 130);
            this.BtnSaveFile.TabIndex = 4;
            this.BtnSaveFile.Text = "VER RUTA DE ARCHIVO GUARDADO";
            this.BtnSaveFile.UseVisualStyleBackColor = false;
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(188)))), ((int)(((byte)(230)))));
            this.Panel.Location = new System.Drawing.Point(150, 24);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(634, 387);
            this.Panel.TabIndex = 6;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.SystemColors.Control;
            this.LblTime.Location = new System.Drawing.Point(539, 6);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(91, 13);
            this.LblTime.TabIndex = 7;
            this.LblTime.Text = "Hora del sistema: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.BtnCalcSec);
            this.Controls.Add(this.BtnSaveFile);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BtnHours);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj Mundial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripExit;
        private System.Windows.Forms.Button BtnHours;
        private System.Windows.Forms.Button BtnCalcSec;
        private System.Windows.Forms.Button BtnSaveFile;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

