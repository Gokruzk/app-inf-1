namespace WinAppFahrenCelsius
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblName = new System.Windows.Forms.Label();
            this.LblFahr = new System.Windows.Forms.Label();
            this.TxtFahr = new System.Windows.Forms.TextBox();
            this.LblCelsius = new System.Windows.Forms.Label();
            this.LblCels = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(243, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAHRENHEIT A CELSIUS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Location = new System.Drawing.Point(2, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 32);
            this.panel2.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(165, 6);
            this.LblName.Name = "LblName";
            this.LblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblName.Size = new System.Drawing.Size(311, 17);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "NIGELL MARCEL JAMA OYARVIDE - 7046";
            // 
            // LblFahr
            // 
            this.LblFahr.AutoSize = true;
            this.LblFahr.BackColor = System.Drawing.Color.Transparent;
            this.LblFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFahr.Location = new System.Drawing.Point(60, 92);
            this.LblFahr.Name = "LblFahr";
            this.LblFahr.Size = new System.Drawing.Size(80, 16);
            this.LblFahr.TabIndex = 2;
            this.LblFahr.Text = "Fahrenheit";
            // 
            // TxtFahr
            // 
            this.TxtFahr.Location = new System.Drawing.Point(63, 111);
            this.TxtFahr.Name = "TxtFahr";
            this.TxtFahr.Size = new System.Drawing.Size(135, 20);
            this.TxtFahr.TabIndex = 3;
            // 
            // LblCelsius
            // 
            this.LblCelsius.AutoSize = true;
            this.LblCelsius.BackColor = System.Drawing.Color.Transparent;
            this.LblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelsius.Location = new System.Drawing.Point(60, 184);
            this.LblCelsius.Name = "LblCelsius";
            this.LblCelsius.Size = new System.Drawing.Size(58, 16);
            this.LblCelsius.TabIndex = 4;
            this.LblCelsius.Text = "Celsius";
            // 
            // LblCels
            // 
            this.LblCels.AutoSize = true;
            this.LblCels.BackColor = System.Drawing.Color.Transparent;
            this.LblCels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCels.Location = new System.Drawing.Point(10, 9);
            this.LblCels.Name = "LblCels";
            this.LblCels.Size = new System.Drawing.Size(44, 16);
            this.LblCels.TabIndex = 5;
            this.LblCels.Text = "label2";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(63, 137);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(97, 31);
            this.BtnCalc.TabIndex = 6;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(63, 251);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(97, 31);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.LblCels);
            this.panel3.Location = new System.Drawing.Point(50, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 35);
            this.panel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 333);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblCelsius);
            this.Controls.Add(this.TxtFahr);
            this.Controls.Add(this.LblFahr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Fahrenheit a Celsius";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblFahr;
        private System.Windows.Forms.TextBox TxtFahr;
        private System.Windows.Forms.Label LblCelsius;
        private System.Windows.Forms.Label LblCels;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel3;
    }
}

