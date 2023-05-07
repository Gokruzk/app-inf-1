namespace WinAppRandomG
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAttempt = new System.Windows.Forms.Label();
            this.LblWinLose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(138, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(293, 37);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "ADIVINA EL NÚMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intentos";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(312, 167);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(100, 20);
            this.TxtNum.TabIndex = 2;
            this.TxtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(312, 78);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(100, 41);
            this.BtnPlay.TabIndex = 3;
            this.BtnPlay.Text = "JUGAR";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblAttempt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 100);
            this.panel1.TabIndex = 4;
            // 
            // LblAttempt
            // 
            this.LblAttempt.AutoSize = true;
            this.LblAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAttempt.Location = new System.Drawing.Point(58, 72);
            this.LblAttempt.Name = "LblAttempt";
            this.LblAttempt.Size = new System.Drawing.Size(22, 16);
            this.LblAttempt.TabIndex = 2;
            this.LblAttempt.Text = "---";
            // 
            // LblWinLose
            // 
            this.LblWinLose.AutoSize = true;
            this.LblWinLose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWinLose.Location = new System.Drawing.Point(138, 213);
            this.LblWinLose.Name = "LblWinLose";
            this.LblWinLose.Size = new System.Drawing.Size(0, 25);
            this.LblWinLose.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 280);
            this.Controls.Add(this.LblWinLose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivinar el número";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblAttempt;
        private System.Windows.Forms.Label LblWinLose;
    }
}

