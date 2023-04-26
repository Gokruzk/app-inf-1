namespace WinAppAreaTerrreno
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
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitle2 = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(153, 6);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(208, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "ÁREA DE UN TERRENO";
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(56, 105);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 20);
            this.TxtA.TabIndex = 1;
            this.TxtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtA_KeyPress);
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(56, 131);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(100, 20);
            this.TxtB.TabIndex = 2;
            this.TxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_KeyPress);
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(56, 157);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(100, 20);
            this.TxtC.TabIndex = 3;
            this.TxtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtC_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LblTitle2
            // 
            this.LblTitle2.AutoSize = true;
            this.LblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle2.Location = new System.Drawing.Point(57, 78);
            this.LblTitle2.Name = "LblTitle2";
            this.LblTitle2.Size = new System.Drawing.Size(54, 13);
            this.LblTitle2.TabIndex = 5;
            this.LblTitle2.Text = "Medidas";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA.Location = new System.Drawing.Point(24, 112);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(15, 13);
            this.LblA.TabIndex = 6;
            this.LblA.Text = "A";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblB.Location = new System.Drawing.Point(24, 138);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(15, 13);
            this.LblB.TabIndex = 7;
            this.LblB.Text = "B";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC.Location = new System.Drawing.Point(24, 164);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(15, 13);
            this.LblC.TabIndex = 8;
            this.LblC.Text = "A";
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.Location = new System.Drawing.Point(35, 252);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(133, 13);
            this.LblRespuesta.TabIndex = 9;
            this.LblRespuesta.Text = "El área del terreno es ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 30);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 30);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIGELL MARCEL JAMA OYARVIDE - 7046";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.LblB);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.LblTitle2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitle2;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

