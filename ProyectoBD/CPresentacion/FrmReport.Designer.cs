﻿namespace CPresentacion
{
    partial class FrmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.eSTUDIANTEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTUDIANTEDataSet = new CPresentacion.ESTUDIANTEDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eSTUDIANTEDataSetBindingSource
            // 
            this.eSTUDIANTEDataSetBindingSource.DataSource = this.eSTUDIANTEDataSet;
            this.eSTUDIANTEDataSetBindingSource.Position = 0;
            // 
            // eSTUDIANTEDataSet
            // 
            this.eSTUDIANTEDataSet.DataSetName = "ESTUDIANTEDataSet";
            this.eSTUDIANTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblDatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CPresentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblDatosBindingSource
            // 
            this.tblDatosBindingSource.DataMember = "TblDatos";
            this.tblDatosBindingSource.DataSource = this.eSTUDIANTEDataSet;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource eSTUDIANTEDataSetBindingSource;
        private ESTUDIANTEDataSet eSTUDIANTEDataSet;
        private System.Windows.Forms.BindingSource tblDatosBindingSource;
    }
}