namespace WinAppNextHour
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
            LblHAct = new Label();
            LblHour = new Label();
            button1 = new Button();
            label2 = new Label();
            LblNextH = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 19);
            label1.Name = "label1";
            label1.Size = new Size(470, 30);
            label1.TabIndex = 0;
            label1.Text = "CALCULAR LA HORA AL SIGUIENTE SEGUNDO";
            // 
            // LblHAct
            // 
            LblHAct.AutoSize = true;
            LblHAct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblHAct.Location = new Point(80, 104);
            LblHAct.Name = "LblHAct";
            LblHAct.Size = new Size(106, 21);
            LblHAct.TabIndex = 1;
            LblHAct.Text = "Hora actual: ";
            // 
            // LblHour
            // 
            LblHour.AutoSize = true;
            LblHour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblHour.Location = new Point(192, 104);
            LblHour.Name = "LblHour";
            LblHour.Size = new Size(0, 21);
            LblHour.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(405, 155);
            button1.Name = "button1";
            button1.Size = new Size(105, 49);
            button1.TabIndex = 3;
            button1.Text = "Siguiente segundo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 155);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 4;
            label2.Text = "Segundo siguiente:";
            // 
            // LblNextH
            // 
            LblNextH.AutoSize = true;
            LblNextH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblNextH.Location = new Point(243, 155);
            LblNextH.Name = "LblNextH";
            LblNextH.Size = new Size(0, 21);
            LblNextH.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(405, 100);
            button2.Name = "button2";
            button2.Size = new Size(105, 49);
            button2.TabIndex = 6;
            button2.Text = "Cargar Hora";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 230);
            Controls.Add(button2);
            Controls.Add(LblNextH);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(LblHour);
            Controls.Add(LblHAct);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblHAct;
        private Label LblHour;
        private Button button1;
        private Label label2;
        private Label LblNextH;
        private Button button2;
    }
}