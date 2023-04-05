namespace WinAppAreaCir
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtRadio = new System.Windows.Forms.TextBox();
            this.LblRadio = new System.Windows.Forms.Label();
            this.LblRad = new System.Windows.Forms.Label();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(80, 18);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(370, 25);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "CÁLCULO ÁREA DE UN CÍRCULO";
            // 
            // TxtRadio
            // 
            this.TxtRadio.Location = new System.Drawing.Point(102, 91);
            this.TxtRadio.Name = "TxtRadio";
            this.TxtRadio.Size = new System.Drawing.Size(100, 20);
            this.TxtRadio.TabIndex = 2;
            // 
            // LblRadio
            // 
            this.LblRadio.AutoSize = true;
            this.LblRadio.BackColor = System.Drawing.Color.Transparent;
            this.LblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRadio.Location = new System.Drawing.Point(98, 133);
            this.LblRadio.Name = "LblRadio";
            this.LblRadio.Size = new System.Drawing.Size(236, 24);
            this.LblRadio.TabIndex = 3;
            this.LblRadio.Text = "Área de la circunferencia =";
            // 
            // LblRad
            // 
            this.LblRad.AutoSize = true;
            this.LblRad.BackColor = System.Drawing.Color.Transparent;
            this.LblRad.Location = new System.Drawing.Point(109, 71);
            this.LblRad.Name = "LblRad";
            this.LblRad.Size = new System.Drawing.Size(35, 13);
            this.LblRad.TabIndex = 4;
            this.LblRad.Text = "Radio";
            // 
            // PbxFoto
            // 
            this.PbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxFoto.Image")));
            this.PbxFoto.Location = new System.Drawing.Point(12, 201);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(172, 107);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 5;
            this.PbxFoto.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Location = new System.Drawing.Point(375, 219);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.BackColor = System.Drawing.Color.Transparent;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(337, 133);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 24);
            this.LblRes.TabIndex = 7;
            // 
            // BtnCalc
            // 
            this.BtnCalc.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalc.Location = new System.Drawing.Point(375, 91);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 8;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 320);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.LblRad);
            this.Controls.Add(this.LblRadio);
            this.Controls.Add(this.TxtRadio);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtRadio;
        private System.Windows.Forms.Label LblRadio;
        private System.Windows.Forms.Label LblRad;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnCalc;
    }
}

