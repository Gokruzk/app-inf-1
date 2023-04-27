namespace WinAppCantCifras
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
            this.LblNum = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblMsj = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblCifra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.BackColor = System.Drawing.Color.Transparent;
            this.LblNum.Location = new System.Drawing.Point(44, 86);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(95, 13);
            this.LblNum.TabIndex = 1;
            this.LblNum.Text = "Ingrese un número";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(47, 102);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(146, 20);
            this.TxtNum.TabIndex = 2;
            // 
            // BtnCalc
            // 
            this.BtnCalc.BackColor = System.Drawing.Color.Coral;
            this.BtnCalc.Location = new System.Drawing.Point(253, 86);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(108, 47);
            this.BtnCalc.TabIndex = 3;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LblMsj
            // 
            this.LblMsj.AutoSize = true;
            this.LblMsj.BackColor = System.Drawing.Color.Transparent;
            this.LblMsj.Location = new System.Drawing.Point(44, 150);
            this.LblMsj.Name = "LblMsj";
            this.LblMsj.Size = new System.Drawing.Size(227, 13);
            this.LblMsj.TabIndex = 4;
            this.LblMsj.Text = "La cantidad de cifras del número ingresado es:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Coral;
            this.BtnSalir.Location = new System.Drawing.Point(428, 221);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 44);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.LblName);
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 29);
            this.panel1.TabIndex = 6;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(167, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(229, 12);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "NIGELL MARCEL JAMA OYARVIDE - 7046";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.LblTitle);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 39);
            this.panel2.TabIndex = 7;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(37, 8);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(510, 24);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "CANTIDAD DE CIFRAS DE UN NÚMERO ENTERO";
            // 
            // LblCifra
            // 
            this.LblCifra.AutoSize = true;
            this.LblCifra.BackColor = System.Drawing.Color.Transparent;
            this.LblCifra.Location = new System.Drawing.Point(44, 179);
            this.LblCifra.Name = "LblCifra";
            this.LblCifra.Size = new System.Drawing.Size(35, 13);
            this.LblCifra.TabIndex = 8;
            this.LblCifra.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 300);
            this.Controls.Add(this.LblCifra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblMsj);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.LblNum);
            this.Name = "Form1";
            this.Text = "Cantidad de Cifras de un Número";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblMsj;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblCifra;
    }
}

