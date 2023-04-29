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
            button1 = new Button();
            label2 = new Label();
            LblNextH = new Label();
            TxtHour = new TextBox();
            LblMsj = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(470, 30);
            label1.TabIndex = 0;
            label1.Text = "CALCULAR LA HORA AL SIGUIENTE SEGUNDO";
            // 
            // LblHAct
            // 
            LblHAct.AutoSize = true;
            LblHAct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblHAct.Location = new Point(36, 94);
            LblHAct.Name = "LblHAct";
            LblHAct.Size = new Size(106, 21);
            LblHAct.TabIndex = 1;
            LblHAct.Text = "Hora actual: ";
            // 
            // button1
            // 
            button1.Location = new Point(357, 117);
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
            label2.Location = new Point(36, 145);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 4;
            label2.Text = "Segundo siguiente:";
            // 
            // LblNextH
            // 
            LblNextH.AutoSize = true;
            LblNextH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblNextH.Location = new Point(199, 145);
            LblNextH.Name = "LblNextH";
            LblNextH.Size = new Size(0, 21);
            LblNextH.TabIndex = 5;
            // 
            // TxtHour
            // 
            TxtHour.Location = new Point(148, 92);
            TxtHour.Name = "TxtHour";
            TxtHour.Size = new Size(100, 23);
            TxtHour.TabIndex = 7;
            TxtHour.KeyPress += TxtHour_KeyPress;
            // 
            // LblMsj
            // 
            LblMsj.AutoSize = true;
            LblMsj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblMsj.Location = new Point(148, 74);
            LblMsj.Name = "LblMsj";
            LblMsj.Size = new Size(178, 15);
            LblMsj.TabIndex = 8;
            LblMsj.Text = "Formato de 24 horas: 00:00:00 ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 187);
            Controls.Add(LblMsj);
            Controls.Add(TxtHour);
            Controls.Add(LblNextH);
            Controls.Add(label2);
            Controls.Add(button1);
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
        private Button button1;
        private Label label2;
        private Label LblNextH;
        private TextBox TxtHour;
        private Label LblMsj;
    }
}