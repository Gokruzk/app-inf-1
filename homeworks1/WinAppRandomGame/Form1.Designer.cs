namespace WinAppRandomGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            LblAttempt = new Label();
            panel1 = new Panel();
            TxtNum = new TextBox();
            LblWinLose = new Label();
            BtnPlay = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 17);
            label1.Name = "label1";
            label1.Size = new Size(244, 30);
            label1.TabIndex = 0;
            label1.Text = "ADIVINA EL NÚMERO!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 15);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Intentos";
            // 
            // LblAttempt
            // 
            LblAttempt.AutoSize = true;
            LblAttempt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAttempt.Location = new Point(51, 60);
            LblAttempt.Name = "LblAttempt";
            LblAttempt.Size = new Size(34, 21);
            LblAttempt.TabIndex = 2;
            LblAttempt.Text = "----";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LblAttempt);
            panel1.Location = new Point(26, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 100);
            panel1.TabIndex = 3;
            // 
            // TxtNum
            // 
            TxtNum.Location = new Point(272, 156);
            TxtNum.Name = "TxtNum";
            TxtNum.Size = new Size(100, 23);
            TxtNum.TabIndex = 4;
            TxtNum.KeyPress += textBox1_KeyPress;
            // 
            // LblWinLose
            // 
            LblWinLose.AutoSize = true;
            LblWinLose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblWinLose.Location = new Point(192, 207);
            LblWinLose.Name = "LblWinLose";
            LblWinLose.Size = new Size(0, 25);
            LblWinLose.TabIndex = 5;
            // 
            // BtnPlay
            // 
            BtnPlay.Location = new Point(272, 73);
            BtnPlay.Name = "BtnPlay";
            BtnPlay.Size = new Size(100, 41);
            BtnPlay.TabIndex = 7;
            BtnPlay.Text = "Jugar";
            BtnPlay.UseVisualStyleBackColor = true;
            BtnPlay.Click += BtnPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 280);
            Controls.Add(BtnPlay);
            Controls.Add(LblWinLose);
            Controls.Add(TxtNum);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label LblAttempt;
        private Panel panel1;
        private TextBox TxtNum;
        private Label LblWinLose;
        private Button BtnPlay;
    }
}