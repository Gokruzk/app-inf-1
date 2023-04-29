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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSumDiag = new System.Windows.Forms.Label();
            this.LblSumTrigSup = new System.Windows.Forms.Label();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "La suma de la diagonal es: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "La suma del triángulo superior es:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "La suma del triángulo inferior es:";
            // 
            // LblSumDiag
            // 
            this.LblSumDiag.AutoSize = true;
            this.LblSumDiag.Location = new System.Drawing.Point(414, 158);
            this.LblSumDiag.Name = "LblSumDiag";
            this.LblSumDiag.Size = new System.Drawing.Size(0, 13);
            this.LblSumDiag.TabIndex = 7;
            // 
            // LblSumTrigSup
            // 
            this.LblSumTrigSup.AutoSize = true;
            this.LblSumTrigSup.Location = new System.Drawing.Point(455, 196);
            this.LblSumTrigSup.Name = "LblSumTrigSup";
            this.LblSumTrigSup.Size = new System.Drawing.Size(0, 13);
            this.LblSumTrigSup.TabIndex = 8;
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
            this.Controls.Add(this.LblSumTrigSup);
            this.Controls.Add(this.LblSumDiag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSumDiag;
        private System.Windows.Forms.Label LblSumTrigSup;
        private System.Windows.Forms.Label LblSumTriInf;
        private System.Windows.Forms.TextBox TxtNum;
    }
}

