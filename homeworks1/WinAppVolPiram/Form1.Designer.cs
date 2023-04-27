namespace WindowsFormsApp1
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.LblBase = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblMsj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 43);
            this.panel1.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(83, 10);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(356, 22);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "VOLÚMEN DE PIRÁMIDE CUADRADA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 33);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIGELL MARCEL JAMA OYARVIDE - 7046";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.BackColor = System.Drawing.Color.Transparent;
            this.LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.Location = new System.Drawing.Point(42, 90);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(44, 15);
            this.LblAltura.TabIndex = 2;
            this.LblAltura.Text = "Altura";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(45, 108);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(134, 20);
            this.TxtAltura.TabIndex = 3;
            // 
            // TxtBase
            // 
            this.TxtBase.Location = new System.Drawing.Point(45, 157);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(134, 20);
            this.TxtBase.TabIndex = 5;
            // 
            // LblBase
            // 
            this.LblBase.AutoSize = true;
            this.LblBase.BackColor = System.Drawing.Color.Transparent;
            this.LblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBase.Location = new System.Drawing.Point(42, 139);
            this.LblBase.Name = "LblBase";
            this.LblBase.Size = new System.Drawing.Size(39, 15);
            this.LblBase.TabIndex = 4;
            this.LblBase.Text = "Base";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(204, 124);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(91, 30);
            this.BtnCalc.TabIndex = 6;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(48, 243);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(91, 30);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblMsj
            // 
            this.LblMsj.AutoSize = true;
            this.LblMsj.BackColor = System.Drawing.Color.Transparent;
            this.LblMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsj.Location = new System.Drawing.Point(46, 194);
            this.LblMsj.Name = "LblMsj";
            this.LblMsj.Size = new System.Drawing.Size(41, 15);
            this.LblMsj.TabIndex = 8;
            this.LblMsj.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 312);
            this.Controls.Add(this.LblMsj);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.LblBase);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Volumen Pirámide";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.Label LblBase;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblMsj;
    }
}

