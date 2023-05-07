namespace WinAppTriang
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtS1 = new System.Windows.Forms.TextBox();
            this.TxtS2 = new System.Windows.Forms.TextBox();
            this.TxtS3 = new System.Windows.Forms.TextBox();
            this.LblTriang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPOS DE TRIÁNGULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lado 3:";
            // 
            // TxtS1
            // 
            this.TxtS1.Location = new System.Drawing.Point(101, 65);
            this.TxtS1.Name = "TxtS1";
            this.TxtS1.Size = new System.Drawing.Size(100, 20);
            this.TxtS1.TabIndex = 4;
            this.TxtS1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtS1_KeyPress);
            // 
            // TxtS2
            // 
            this.TxtS2.Location = new System.Drawing.Point(101, 105);
            this.TxtS2.Name = "TxtS2";
            this.TxtS2.Size = new System.Drawing.Size(100, 20);
            this.TxtS2.TabIndex = 5;
            this.TxtS2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtS2_KeyPress);
            // 
            // TxtS3
            // 
            this.TxtS3.Location = new System.Drawing.Point(101, 146);
            this.TxtS3.Name = "TxtS3";
            this.TxtS3.Size = new System.Drawing.Size(100, 20);
            this.TxtS3.TabIndex = 6;
            this.TxtS3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtS3_KeyPress);
            // 
            // LblTriang
            // 
            this.LblTriang.AutoSize = true;
            this.LblTriang.Location = new System.Drawing.Point(263, 112);
            this.LblTriang.Name = "LblTriang";
            this.LblTriang.Size = new System.Drawing.Size(0, 13);
            this.LblTriang.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 191);
            this.Controls.Add(this.LblTriang);
            this.Controls.Add(this.TxtS3);
            this.Controls.Add(this.TxtS2);
            this.Controls.Add(this.TxtS1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Triángulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtS1;
        private System.Windows.Forms.TextBox TxtS2;
        private System.Windows.Forms.TextBox TxtS3;
        private System.Windows.Forms.Label LblTriang;
    }
}

