namespace WinAppMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUnFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aOtroProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.LblMsj = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.alFondoYTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.fechaToolStripMenuItem,
            this.llamarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbrir,
            this.MnuCerrar,
            this.MnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alTextoToolStripMenuItem,
            this.alFondoToolStripMenuItem,
            this.alFondoYTextoToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // alTextoToolStripMenuItem
            // 
            this.alTextoToolStripMenuItem.Name = "alTextoToolStripMenuItem";
            this.alTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alTextoToolStripMenuItem.Text = "Al texto";
            this.alTextoToolStripMenuItem.Click += new System.EventHandler(this.alTextoToolStripMenuItem_Click);
            // 
            // alFondoToolStripMenuItem
            // 
            this.alFondoToolStripMenuItem.Name = "alFondoToolStripMenuItem";
            this.alFondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alFondoToolStripMenuItem.Text = "Al fondo";
            this.alFondoToolStripMenuItem.Click += new System.EventHandler(this.alFondoToolStripMenuItem_Click);
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fechaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horaToolStripMenuItem,
            this.fechaToolStripMenuItem1});
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fechaToolStripMenuItem.Text = "Fecha";
            // 
            // horaToolStripMenuItem
            // 
            this.horaToolStripMenuItem.Name = "horaToolStripMenuItem";
            this.horaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horaToolStripMenuItem.Text = "Hora";
            this.horaToolStripMenuItem.Click += new System.EventHandler(this.horaToolStripMenuItem_Click);
            // 
            // llamarToolStripMenuItem
            // 
            this.llamarToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.llamarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUnFormularioToolStripMenuItem,
            this.aOtroProyectoToolStripMenuItem});
            this.llamarToolStripMenuItem.Name = "llamarToolStripMenuItem";
            this.llamarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.llamarToolStripMenuItem.Text = "Llamar";
            // 
            // aUnFormularioToolStripMenuItem
            // 
            this.aUnFormularioToolStripMenuItem.Name = "aUnFormularioToolStripMenuItem";
            this.aUnFormularioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aUnFormularioToolStripMenuItem.Text = "A un formulario";
            this.aUnFormularioToolStripMenuItem.Click += new System.EventHandler(this.aUnFormularioToolStripMenuItem_Click);
            // 
            // aOtroProyectoToolStripMenuItem
            // 
            this.aOtroProyectoToolStripMenuItem.Name = "aOtroProyectoToolStripMenuItem";
            this.aOtroProyectoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aOtroProyectoToolStripMenuItem.Text = "A otro proyecto";
            this.aOtroProyectoToolStripMenuItem.Click += new System.EventHandler(this.aOtroProyectoToolStripMenuItem_Click);
            // 
            // MnuAbrir
            // 
            this.MnuAbrir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MnuAbrir.ForeColor = System.Drawing.Color.Green;
            this.MnuAbrir.Image = ((System.Drawing.Image)(resources.GetObject("MnuAbrir.Image")));
            this.MnuAbrir.Name = "MnuAbrir";
            this.MnuAbrir.Size = new System.Drawing.Size(180, 22);
            this.MnuAbrir.Text = "Abrir";
            this.MnuAbrir.Click += new System.EventHandler(this.MnuAbrir_Click);
            // 
            // MnuCerrar
            // 
            this.MnuCerrar.Name = "MnuCerrar";
            this.MnuCerrar.Size = new System.Drawing.Size(180, 22);
            this.MnuCerrar.Text = "Cerrar";
            this.MnuCerrar.Click += new System.EventHandler(this.MnuCerrar_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(180, 22);
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PbxFoto
            // 
            this.PbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxFoto.Location = new System.Drawing.Point(253, 105);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(156, 115);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 1;
            this.PbxFoto.TabStop = false;
            // 
            // LblMsj
            // 
            this.LblMsj.AutoSize = true;
            this.LblMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsj.Location = new System.Drawing.Point(42, 41);
            this.LblMsj.Name = "LblMsj";
            this.LblMsj.Size = new System.Drawing.Size(585, 24);
            this.LblMsj.TabIndex = 2;
            this.LblMsj.Text = "EL VIERNES NO HAY ASISTENCIA ME VOY AL CONCIERTO";
            // 
            // alFondoYTextoToolStripMenuItem
            // 
            this.alFondoYTextoToolStripMenuItem.Name = "alFondoYTextoToolStripMenuItem";
            this.alFondoYTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alFondoYTextoToolStripMenuItem.Text = "Al fondo y texto";
            this.alFondoYTextoToolStripMenuItem.Click += new System.EventHandler(this.alFondoYTextoToolStripMenuItem_Click);
            // 
            // fechaToolStripMenuItem1
            // 
            this.fechaToolStripMenuItem1.Name = "fechaToolStripMenuItem1";
            this.fechaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fechaToolStripMenuItem1.Text = "Fecha";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(473, 117);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(30, 13);
            this.LblTime.TabIndex = 3;
            this.LblTime.Text = "Hora";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(473, 104);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(37, 13);
            this.LblDate.TabIndex = 4;
            this.LblDate.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 267);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblMsj);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem MnuCerrar;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUnFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aOtroProyectoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Label LblMsj;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem alFondoYTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
    }
}

