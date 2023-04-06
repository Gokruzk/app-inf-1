namespace WinAppHipoTrian
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblCat1 = new System.Windows.Forms.Label();
            this.TxtOpuesto = new System.Windows.Forms.TextBox();
            this.TxtAdy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblHipotenusa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULAR HIPOTENUSA DE UN TRIÁNGULO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 33);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIGELL MARCEL JAMA OYARVIDE - 7046";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.LblHipotenusa);
            this.panel3.Controls.Add(this.BtnSalir);
            this.panel3.Controls.Add(this.BtnCalc);
            this.panel3.Controls.Add(this.TxtAdy);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtOpuesto);
            this.panel3.Controls.Add(this.LblCat1);
            this.panel3.Location = new System.Drawing.Point(40, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 153);
            this.panel3.TabIndex = 2;
            // 
            // LblCat1
            // 
            this.LblCat1.AutoSize = true;
            this.LblCat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCat1.Location = new System.Drawing.Point(29, 17);
            this.LblCat1.Name = "LblCat1";
            this.LblCat1.Size = new System.Drawing.Size(114, 16);
            this.LblCat1.TabIndex = 0;
            this.LblCat1.Text = "Cateto Opuesto";
            // 
            // TxtOpuesto
            // 
            this.TxtOpuesto.Location = new System.Drawing.Point(32, 36);
            this.TxtOpuesto.Name = "TxtOpuesto";
            this.TxtOpuesto.Size = new System.Drawing.Size(144, 20);
            this.TxtOpuesto.TabIndex = 1;
            // 
            // TxtAdy
            // 
            this.TxtAdy.Location = new System.Drawing.Point(32, 82);
            this.TxtAdy.Name = "TxtAdy";
            this.TxtAdy.Size = new System.Drawing.Size(144, 20);
            this.TxtAdy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cateto Adyacente";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(32, 108);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(108, 36);
            this.BtnCalc.TabIndex = 4;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(146, 108);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 36);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblHipotenusa
            // 
            this.LblHipotenusa.AutoSize = true;
            this.LblHipotenusa.Location = new System.Drawing.Point(219, 65);
            this.LblHipotenusa.Name = "LblHipotenusa";
            this.LblHipotenusa.Size = new System.Drawing.Size(35, 13);
            this.LblHipotenusa.TabIndex = 6;
            this.LblHipotenusa.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 298);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hipotenusa de un Triángulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblCat1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox TxtAdy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOpuesto;
        private System.Windows.Forms.Label LblHipotenusa;
    }
}

