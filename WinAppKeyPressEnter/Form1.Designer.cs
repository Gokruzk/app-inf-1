namespace WinAppKeyPressEnter
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
            this.LblName = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblHi = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastNam = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KEY PRESS";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(124, 92);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LbLastName
            // 
            this.LbLastName.AutoSize = true;
            this.LbLastName.Location = new System.Drawing.Point(124, 151);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(58, 13);
            this.LbLastName.TabIndex = 2;
            this.LbLastName.Text = "Last Name";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(124, 208);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(26, 13);
            this.LblAge.TabIndex = 3;
            this.LblAge.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hello";
            // 
            // LblHi
            // 
            this.LblHi.AutoSize = true;
            this.LblHi.Location = new System.Drawing.Point(161, 284);
            this.LblHi.Name = "LblHi";
            this.LblHi.Size = new System.Drawing.Size(19, 13);
            this.LblHi.TabIndex = 5;
            this.LblHi.Text = "aa";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(186, 89);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(257, 20);
            this.TxtName.TabIndex = 6;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // TxtLastNam
            // 
            this.TxtLastNam.Location = new System.Drawing.Point(186, 144);
            this.TxtLastNam.Name = "TxtLastNam";
            this.TxtLastNam.Size = new System.Drawing.Size(257, 20);
            this.TxtLastNam.TabIndex = 7;
            this.TxtLastNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLastNam_KeyPress);
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(186, 201);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(257, 20);
            this.TxtAge.TabIndex = 8;
            this.TxtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAge_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 325);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtLastNam);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblHi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LbLastName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblHi;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastNam;
        private System.Windows.Forms.TextBox TxtAge;
    }
}

