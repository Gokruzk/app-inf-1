namespace WinAppDiagSuperiorInferior
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblMayTS = new System.Windows.Forms.Label();
            this.LblMenD = new System.Windows.Forms.Label();
            this.LblSumTI = new System.Windows.Forms.Label();
            this.LblSumTriInf = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARREGLOS BIDIMENSIONALES CUADRÁTICOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ELEMENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMPRESIÓN ARREGLO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 117);
            this.dataGridView1.TabIndex = 3;
            // 
            // LblMayTS
            // 
            this.LblMayTS.AutoSize = true;
            this.LblMayTS.Location = new System.Drawing.Point(285, 156);
            this.LblMayTS.Name = "LblMayTS";
            this.LblMayTS.Size = new System.Drawing.Size(174, 13);
            this.LblMayTS.TabIndex = 4;
            this.LblMayTS.Text = "Mayor elemento tringualor superior: ";
            // 
            // LblMenD
            // 
            this.LblMenD.AutoSize = true;
            this.LblMenD.Location = new System.Drawing.Point(285, 196);
            this.LblMenD.Name = "LblMenD";
            this.LblMenD.Size = new System.Drawing.Size(158, 13);
            this.LblMenD.TabIndex = 5;
            this.LblMenD.Text = "Menor elemento de la diagonal: ";
            // 
            // LblSumTI
            // 
            this.LblSumTI.AutoSize = true;
            this.LblSumTI.Location = new System.Drawing.Point(285, 229);
            this.LblSumTI.Name = "LblSumTI";
            this.LblSumTI.Size = new System.Drawing.Size(145, 13);
            this.LblSumTI.TabIndex = 6;
            this.LblSumTI.Text = "Suma del triángulo inferior es:";
            // 
            // LblSumTriInf
            // 
            this.LblSumTriInf.AutoSize = true;
            this.LblSumTriInf.Location = new System.Drawing.Point(441, 229);
            this.LblSumTriInf.Name = "LblSumTriInf";
            this.LblSumTriInf.Size = new System.Drawing.Size(0, 13);
            this.LblSumTriInf.TabIndex = 9;
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(267, 77);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(100, 20);
            this.TxtNum.TabIndex = 10;
            this.TxtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 285);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.LblSumTriInf);
            this.Controls.Add(this.LblSumTI);
            this.Controls.Add(this.LblMenD);
            this.Controls.Add(this.LblMayTS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arreglos Bidimensionales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblMayTS;
        private System.Windows.Forms.Label LblMenD;
        private System.Windows.Forms.Label LblSumTI;
        private System.Windows.Forms.Label LblSumTriInf;
        private System.Windows.Forms.TextBox TxtNum;
    }
}

