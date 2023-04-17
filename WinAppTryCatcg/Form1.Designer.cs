namespace WinAppTryCatcg
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
            this.LblTittle = new System.Windows.Forms.Label();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.TxtAlt = new System.Windows.Forms.TextBox();
            this.LblBase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMsj = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTittle
            // 
            this.LblTittle.AutoSize = true;
            this.LblTittle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTittle.Location = new System.Drawing.Point(174, 9);
            this.LblTittle.Name = "LblTittle";
            this.LblTittle.Size = new System.Drawing.Size(151, 28);
            this.LblTittle.TabIndex = 0;
            this.LblTittle.Text = "TRY CATCH";
            // 
            // TxtBase
            // 
            this.TxtBase.Location = new System.Drawing.Point(152, 87);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(202, 20);
            this.TxtBase.TabIndex = 1;
            this.TxtBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TxtAlt
            // 
            this.TxtAlt.Location = new System.Drawing.Point(152, 113);
            this.TxtAlt.Name = "TxtAlt";
            this.TxtAlt.Size = new System.Drawing.Size(202, 20);
            this.TxtAlt.TabIndex = 2;
            this.TxtAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAlt_KeyPress);
            // 
            // LblBase
            // 
            this.LblBase.AutoSize = true;
            this.LblBase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBase.Location = new System.Drawing.Point(77, 86);
            this.LblBase.Name = "LblBase";
            this.LblBase.Size = new System.Drawing.Size(49, 18);
            this.LblBase.TabIndex = 3;
            this.LblBase.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura";
            // 
            // LblMsj
            // 
            this.LblMsj.AutoSize = true;
            this.LblMsj.Location = new System.Drawing.Point(77, 205);
            this.LblMsj.Name = "LblMsj";
            this.LblMsj.Size = new System.Drawing.Size(47, 13);
            this.LblMsj.TabIndex = 5;
            this.LblMsj.Text = "Mensaje";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cuadro diálogo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblMsj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblBase);
            this.Controls.Add(this.TxtAlt);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.LblTittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTittle;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.TextBox TxtAlt;
        private System.Windows.Forms.Label LblBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMsj;
        private System.Windows.Forms.Button button1;
    }
}

