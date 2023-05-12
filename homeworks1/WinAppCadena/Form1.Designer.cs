namespace WinAppCadena
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
            this.TxtString = new System.Windows.Forms.TextBox();
            this.BtnL = new System.Windows.Forms.Button();
            this.BtnInvertir = new System.Windows.Forms.Button();
            this.BtnDSpaces = new System.Windows.Forms.Button();
            this.BtnCVOp = new System.Windows.Forms.Button();
            this.TxtCI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADENAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese una cadena";
            // 
            // TxtString
            // 
            this.TxtString.Location = new System.Drawing.Point(12, 126);
            this.TxtString.Name = "TxtString";
            this.TxtString.Size = new System.Drawing.Size(425, 20);
            this.TxtString.TabIndex = 2;
            this.TxtString.Click += new System.EventHandler(this.TxtString_Click);
            this.TxtString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtString_KeyPress);
            // 
            // BtnL
            // 
            this.BtnL.Enabled = false;
            this.BtnL.Location = new System.Drawing.Point(93, 181);
            this.BtnL.Name = "BtnL";
            this.BtnL.Size = new System.Drawing.Size(123, 57);
            this.BtnL.TabIndex = 3;
            this.BtnL.Text = "Imprimir letra por letra";
            this.BtnL.UseVisualStyleBackColor = true;
            this.BtnL.Click += new System.EventHandler(this.BtnL_Click);
            // 
            // BtnInvertir
            // 
            this.BtnInvertir.Enabled = false;
            this.BtnInvertir.Location = new System.Drawing.Point(222, 181);
            this.BtnInvertir.Name = "BtnInvertir";
            this.BtnInvertir.Size = new System.Drawing.Size(123, 57);
            this.BtnInvertir.TabIndex = 4;
            this.BtnInvertir.Text = "Invertir cadena";
            this.BtnInvertir.UseVisualStyleBackColor = true;
            this.BtnInvertir.Click += new System.EventHandler(this.BtnInvertir_Click);
            // 
            // BtnDSpaces
            // 
            this.BtnDSpaces.Enabled = false;
            this.BtnDSpaces.Location = new System.Drawing.Point(93, 244);
            this.BtnDSpaces.Name = "BtnDSpaces";
            this.BtnDSpaces.Size = new System.Drawing.Size(123, 57);
            this.BtnDSpaces.TabIndex = 5;
            this.BtnDSpaces.Text = "Eliminar espacios";
            this.BtnDSpaces.UseVisualStyleBackColor = true;
            this.BtnDSpaces.Click += new System.EventHandler(this.BtnDSpaces_Click);
            // 
            // BtnCVOp
            // 
            this.BtnCVOp.Enabled = false;
            this.BtnCVOp.Location = new System.Drawing.Point(222, 244);
            this.BtnCVOp.Name = "BtnCVOp";
            this.BtnCVOp.Size = new System.Drawing.Size(123, 57);
            this.BtnCVOp.TabIndex = 6;
            this.BtnCVOp.Text = "Contar vocales abiertas";
            this.BtnCVOp.UseVisualStyleBackColor = true;
            this.BtnCVOp.Click += new System.EventHandler(this.BtnCVOp_Click);
            // 
            // TxtCI
            // 
            this.TxtCI.Location = new System.Drawing.Point(12, 152);
            this.TxtCI.Name = "TxtCI";
            this.TxtCI.ReadOnly = true;
            this.TxtCI.Size = new System.Drawing.Size(425, 20);
            this.TxtCI.TabIndex = 7;
            this.TxtCI.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 320);
            this.Controls.Add(this.TxtCI);
            this.Controls.Add(this.BtnCVOp);
            this.Controls.Add(this.BtnDSpaces);
            this.Controls.Add(this.BtnInvertir);
            this.Controls.Add(this.BtnL);
            this.Controls.Add(this.TxtString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtString;
        private System.Windows.Forms.Button BtnL;
        private System.Windows.Forms.Button BtnInvertir;
        private System.Windows.Forms.Button BtnDSpaces;
        private System.Windows.Forms.Button BtnCVOp;
        private System.Windows.Forms.TextBox TxtCI;
    }
}

