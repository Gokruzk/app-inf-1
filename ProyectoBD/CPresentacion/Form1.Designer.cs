namespace CPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.StripBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.StripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.StripUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.StripReport = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.eSTUDIANTEDataSet = new CPresentacion.ESTUDIANTEDataSet();
            this.eSTUDIANTEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripIngresar,
            this.StripBuscar,
            this.StripEliminar,
            this.StripUpdate,
            this.StripReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripIngresar
            // 
            this.StripIngresar.Name = "StripIngresar";
            this.StripIngresar.Size = new System.Drawing.Size(61, 20);
            this.StripIngresar.Text = "Ingresar";
            this.StripIngresar.Click += new System.EventHandler(this.StripIngresar_Click);
            // 
            // StripBuscar
            // 
            this.StripBuscar.Name = "StripBuscar";
            this.StripBuscar.Size = new System.Drawing.Size(54, 20);
            this.StripBuscar.Text = "Buscar";
            this.StripBuscar.Click += new System.EventHandler(this.StripBuscar_Click);
            // 
            // StripEliminar
            // 
            this.StripEliminar.Name = "StripEliminar";
            this.StripEliminar.Size = new System.Drawing.Size(62, 20);
            this.StripEliminar.Text = "Eliminar";
            this.StripEliminar.Click += new System.EventHandler(this.StripEliminar_Click);
            // 
            // StripUpdate
            // 
            this.StripUpdate.Name = "StripUpdate";
            this.StripUpdate.Size = new System.Drawing.Size(71, 20);
            this.StripUpdate.Text = "Actualizar";
            this.StripUpdate.Click += new System.EventHandler(this.StripUpdate_Click);
            // 
            // StripReport
            // 
            this.StripReport.Name = "StripReport";
            this.StripReport.Size = new System.Drawing.Size(60, 20);
            this.StripReport.Text = "Reporte";
            this.StripReport.Click += new System.EventHandler(this.StripReport_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(12, 327);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(113, 44);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Actualizar Tabla";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // eSTUDIANTEDataSet
            // 
            this.eSTUDIANTEDataSet.DataSetName = "ESTUDIANTEDataSet";
            this.eSTUDIANTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTUDIANTEDataSetBindingSource
            // 
            this.eSTUDIANTEDataSetBindingSource.DataSource = this.eSTUDIANTEDataSet;
            this.eSTUDIANTEDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripIngresar;
        private System.Windows.Forms.ToolStripMenuItem StripBuscar;
        private System.Windows.Forms.ToolStripMenuItem StripEliminar;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem StripUpdate;
        private System.Windows.Forms.ToolStripMenuItem StripReport;
        private System.Windows.Forms.BindingSource eSTUDIANTEDataSetBindingSource;
        private ESTUDIANTEDataSet eSTUDIANTEDataSet;
    }
}

