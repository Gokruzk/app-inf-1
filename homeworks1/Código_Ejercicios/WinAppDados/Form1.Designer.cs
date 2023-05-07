namespace WinAppDados
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtDado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(106, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(190, 24);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "JUEGO DE DADOS";
            // 
            // TxtDado
            // 
            this.TxtDado.Location = new System.Drawing.Point(236, 75);
            this.TxtDado.Name = "TxtDado";
            this.TxtDado.Size = new System.Drawing.Size(100, 20);
            this.TxtDado.TabIndex = 1;
            this.TxtDado.Click += new System.EventHandler(this.TxtDado_Click);
            this.TxtDado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado de lanzar un dado";
            // 
            // LblDado
            // 
            this.LblDado.AutoSize = true;
            this.LblDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDado.Location = new System.Drawing.Point(69, 122);
            this.LblDado.Name = "LblDado";
            this.LblDado.Size = new System.Drawing.Size(0, 16);
            this.LblDado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 201);
            this.Controls.Add(this.LblDado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDado);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtDado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDado;
    }
}

