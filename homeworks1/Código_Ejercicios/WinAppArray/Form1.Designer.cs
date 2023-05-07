namespace WinAppArray
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadFind = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.TxtNums = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TxtNumFind = new System.Windows.Forms.TextBox();
            this.LblFind = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenamientoToolStripMenuItem,
            this.lecturaToolStripMenuItem,
            this.busquedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordenamientoToolStripMenuItem
            // 
            this.ordenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortDesc});
            this.ordenamientoToolStripMenuItem.Name = "ordenamientoToolStripMenuItem";
            this.ordenamientoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.ordenamientoToolStripMenuItem.Text = "Ordenamiento";
            // 
            // SortDesc
            // 
            this.SortDesc.Enabled = false;
            this.SortDesc.Name = "SortDesc";
            this.SortDesc.Size = new System.Drawing.Size(142, 22);
            this.SortDesc.Text = "Descendente";
            this.SortDesc.Click += new System.EventHandler(this.SortDesc_Click);
            // 
            // lecturaToolStripMenuItem
            // 
            this.lecturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadFind});
            this.lecturaToolStripMenuItem.Name = "lecturaToolStripMenuItem";
            this.lecturaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.lecturaToolStripMenuItem.Text = "Lectura";
            // 
            // ReadFind
            // 
            this.ReadFind.Enabled = false;
            this.ReadFind.Name = "ReadFind";
            this.ReadFind.Size = new System.Drawing.Size(180, 22);
            this.ReadFind.Text = "Leer y buscar";
            this.ReadFind.Click += new System.EventHandler(this.ReadFind_Click);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindDelete});
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // FindDelete
            // 
            this.FindDelete.Enabled = false;
            this.FindDelete.Name = "FindDelete";
            this.FindDelete.Size = new System.Drawing.Size(255, 22);
            this.FindDelete.Text = "Buscar menor elemento y eliminar";
            this.FindDelete.Click += new System.EventHandler(this.FindDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "VECTORES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elementos";
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(227, 110);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(100, 20);
            this.TxtSize.TabIndex = 4;
            this.TxtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSize_KeyPress);
            // 
            // TxtNums
            // 
            this.TxtNums.Location = new System.Drawing.Point(227, 141);
            this.TxtNums.Name = "TxtNums";
            this.TxtNums.Size = new System.Drawing.Size(100, 20);
            this.TxtNums.TabIndex = 5;
            this.TxtNums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNums_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(227, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // TxtNumFind
            // 
            this.TxtNumFind.Location = new System.Drawing.Point(419, 113);
            this.TxtNumFind.Name = "TxtNumFind";
            this.TxtNumFind.Size = new System.Drawing.Size(100, 20);
            this.TxtNumFind.TabIndex = 8;
            this.TxtNumFind.Visible = false;
            this.TxtNumFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumFind_KeyPress);
            // 
            // LblFind
            // 
            this.LblFind.AutoSize = true;
            this.LblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFind.Location = new System.Drawing.Point(358, 114);
            this.LblFind.Name = "LblFind";
            this.LblFind.Size = new System.Drawing.Size(55, 16);
            this.LblFind.TabIndex = 7;
            this.LblFind.Text = "Buscar";
            this.LblFind.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 323);
            this.Controls.Add(this.TxtNumFind);
            this.Controls.Add(this.LblFind);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TxtNums);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortDesc;
        private System.Windows.Forms.ToolStripMenuItem lecturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReadFind;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.TextBox TxtNums;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtNumFind;
        private System.Windows.Forms.Label LblFind;
    }
}

