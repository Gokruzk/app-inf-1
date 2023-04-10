namespace WinAppMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCursor = new System.Windows.Forms.Label();
            this.CmboxCursor = new System.Windows.Forms.ComboBox();
            this.BtnBeep = new System.Windows.Forms.Button();
            this.BtnAsterisk = new System.Windows.Forms.Button();
            this.BtnExclam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incógnitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCallWin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(195, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(131, 25);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "ACTIVIDAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(395, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LblCursor
            // 
            this.LblCursor.AutoSize = true;
            this.LblCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCursor.Location = new System.Drawing.Point(32, 88);
            this.LblCursor.Name = "LblCursor";
            this.LblCursor.Size = new System.Drawing.Size(107, 25);
            this.LblCursor.TabIndex = 2;
            this.LblCursor.Text = "Cursores";
            // 
            // CmboxCursor
            // 
            this.CmboxCursor.FormattingEnabled = true;
            this.CmboxCursor.Items.AddRange(new object[] {
            "AppStarting",
            "Arrow",
            "Cross",
            "Default",
            "PanSouth"});
            this.CmboxCursor.Location = new System.Drawing.Point(145, 94);
            this.CmboxCursor.Name = "CmboxCursor";
            this.CmboxCursor.Size = new System.Drawing.Size(121, 21);
            this.CmboxCursor.TabIndex = 3;
            this.CmboxCursor.SelectedIndexChanged += new System.EventHandler(this.CmboxCursor_SelectedIndexChanged);
            // 
            // BtnBeep
            // 
            this.BtnBeep.Location = new System.Drawing.Point(25, 24);
            this.BtnBeep.Name = "BtnBeep";
            this.BtnBeep.Size = new System.Drawing.Size(112, 49);
            this.BtnBeep.TabIndex = 4;
            this.BtnBeep.Text = "Beep";
            this.BtnBeep.UseVisualStyleBackColor = true;
            this.BtnBeep.Click += new System.EventHandler(this.BtnBeep_Click);
            // 
            // BtnAsterisk
            // 
            this.BtnAsterisk.Location = new System.Drawing.Point(143, 24);
            this.BtnAsterisk.Name = "BtnAsterisk";
            this.BtnAsterisk.Size = new System.Drawing.Size(112, 49);
            this.BtnAsterisk.TabIndex = 5;
            this.BtnAsterisk.Text = "Asterisk";
            this.BtnAsterisk.UseVisualStyleBackColor = true;
            this.BtnAsterisk.Click += new System.EventHandler(this.BtnAsterisco_Click);
            // 
            // BtnExclam
            // 
            this.BtnExclam.Location = new System.Drawing.Point(261, 24);
            this.BtnExclam.Name = "BtnExclam";
            this.BtnExclam.Size = new System.Drawing.Size(112, 49);
            this.BtnExclam.TabIndex = 6;
            this.BtnExclam.Text = "Exclamation";
            this.BtnExclam.UseVisualStyleBackColor = true;
            this.BtnExclam.Click += new System.EventHandler(this.BtnExclam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExclam);
            this.groupBox1.Controls.Add(this.BtnAsterisk);
            this.groupBox1.Controls.Add(this.BtnBeep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sounds";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.coloresToolStripMenuItem,
            this.fechaToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alTextoToolStripMenuItem,
            this.alFondoToolStripMenuItem});
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.coloresToolStripMenuItem.Text = "Colores";
            // 
            // alTextoToolStripMenuItem
            // 
            this.alTextoToolStripMenuItem.Name = "alTextoToolStripMenuItem";
            this.alTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alTextoToolStripMenuItem.Text = "Al texto";
            // 
            // alFondoToolStripMenuItem
            // 
            this.alFondoToolStripMenuItem.Name = "alFondoToolStripMenuItem";
            this.alFondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alFondoToolStripMenuItem.Text = "Al fondo";
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horaToolStripMenuItem});
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fechaToolStripMenuItem.Text = "Fecha";
            // 
            // horaToolStripMenuItem
            // 
            this.horaToolStripMenuItem.Name = "horaToolStripMenuItem";
            this.horaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horaToolStripMenuItem.Text = "Hora";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incógnitaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // incógnitaToolStripMenuItem
            // 
            this.incógnitaToolStripMenuItem.Name = "incógnitaToolStripMenuItem";
            this.incógnitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incógnitaToolStripMenuItem.Text = "Incógnita";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // BtnCallWin
            // 
            this.BtnCallWin.Location = new System.Drawing.Point(265, 246);
            this.BtnCallWin.Name = "BtnCallWin";
            this.BtnCallWin.Size = new System.Drawing.Size(112, 49);
            this.BtnCallWin.TabIndex = 7;
            this.BtnCallWin.Text = "Llamar Ventana";
            this.BtnCallWin.UseVisualStyleBackColor = true;
            this.BtnCallWin.Click += new System.EventHandler(this.BtnCallWin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 307);
            this.Controls.Add(this.BtnCallWin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmboxCursor);
            this.Controls.Add(this.LblCursor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblCursor;
        private System.Windows.Forms.ComboBox CmboxCursor;
        private System.Windows.Forms.Button BtnBeep;
        private System.Windows.Forms.Button BtnAsterisk;
        private System.Windows.Forms.Button BtnExclam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incógnitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button BtnCallWin;
    }
}

