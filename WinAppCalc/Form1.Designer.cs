namespace WinAppCalc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAux = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.TxtNumbers = new System.Windows.Forms.TextBox();
            this.BtnRaiz = new System.Windows.Forms.Button();
            this.BtnPot = new System.Windows.Forms.Button();
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnLn = new System.Windows.Forms.Button();
            this.BtnMov = new System.Windows.Forms.Button();
            this.BtnTan = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnSin = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.Btn10 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnP = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnPc = new System.Windows.Forms.Button();
            this.BtnPa = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.TxtExp = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblBase = new System.Windows.Forms.Label();
            this.LblExponente = new System.Windows.Forms.Label();
            this.BtnAbs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.TxtAux);
            this.groupBox1.Controls.Add(this.TxtResult);
            this.groupBox1.Controls.Add(this.TxtNumbers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TxtAux
            // 
            this.TxtAux.BackColor = System.Drawing.Color.Green;
            this.TxtAux.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAux.Location = new System.Drawing.Point(6, 68);
            this.TxtAux.Name = "TxtAux";
            this.TxtAux.ReadOnly = true;
            this.TxtAux.Size = new System.Drawing.Size(78, 17);
            this.TxtAux.TabIndex = 2;
            this.TxtAux.TabStop = false;
            // 
            // TxtResult
            // 
            this.TxtResult.BackColor = System.Drawing.Color.Green;
            this.TxtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.Location = new System.Drawing.Point(160, 61);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(193, 17);
            this.TxtResult.TabIndex = 1;
            this.TxtResult.TabStop = false;
            // 
            // TxtNumbers
            // 
            this.TxtNumbers.BackColor = System.Drawing.Color.Green;
            this.TxtNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumbers.CausesValidation = false;
            this.TxtNumbers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumbers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtNumbers.Location = new System.Drawing.Point(6, 14);
            this.TxtNumbers.Name = "TxtNumbers";
            this.TxtNumbers.ReadOnly = true;
            this.TxtNumbers.Size = new System.Drawing.Size(349, 17);
            this.TxtNumbers.TabIndex = 0;
            this.TxtNumbers.TabStop = false;
            // 
            // BtnRaiz
            // 
            this.BtnRaiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRaiz.Location = new System.Drawing.Point(12, 105);
            this.BtnRaiz.Name = "BtnRaiz";
            this.BtnRaiz.Size = new System.Drawing.Size(67, 38);
            this.BtnRaiz.TabIndex = 1;
            this.BtnRaiz.Text = " √";
            this.BtnRaiz.UseVisualStyleBackColor = false;
            this.BtnRaiz.Click += new System.EventHandler(this.BtnRaiz_Click);
            this.BtnRaiz.MouseHover += new System.EventHandler(this.BtnRaiz_MouseHover);
            // 
            // BtnPot
            // 
            this.BtnPot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPot.Location = new System.Drawing.Point(85, 105);
            this.BtnPot.Name = "BtnPot";
            this.BtnPot.Size = new System.Drawing.Size(67, 38);
            this.BtnPot.TabIndex = 2;
            this.BtnPot.Text = "a ^ b";
            this.BtnPot.UseVisualStyleBackColor = false;
            this.BtnPot.Click += new System.EventHandler(this.BtnPot_Click);
            this.BtnPot.MouseHover += new System.EventHandler(this.BtnPot_MouseHover);
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLog.Location = new System.Drawing.Point(158, 105);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(67, 38);
            this.BtnLog.TabIndex = 3;
            this.BtnLog.Text = "log";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // BtnLn
            // 
            this.BtnLn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLn.Location = new System.Drawing.Point(231, 105);
            this.BtnLn.Name = "BtnLn";
            this.BtnLn.Size = new System.Drawing.Size(67, 38);
            this.BtnLn.TabIndex = 4;
            this.BtnLn.Text = "ln";
            this.BtnLn.UseVisualStyleBackColor = false;
            this.BtnLn.Click += new System.EventHandler(this.BtnLn_Click);
            // 
            // BtnMov
            // 
            this.BtnMov.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMov.Location = new System.Drawing.Point(304, 237);
            this.BtnMov.Name = "BtnMov";
            this.BtnMov.Size = new System.Drawing.Size(67, 38);
            this.BtnMov.TabIndex = 8;
            this.BtnMov.Text = "Mover";
            this.BtnMov.UseVisualStyleBackColor = false;
            this.BtnMov.Click += new System.EventHandler(this.BtnMov_Click);
            // 
            // BtnTan
            // 
            this.BtnTan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTan.Location = new System.Drawing.Point(158, 149);
            this.BtnTan.Name = "BtnTan";
            this.BtnTan.Size = new System.Drawing.Size(67, 38);
            this.BtnTan.TabIndex = 7;
            this.BtnTan.Text = "tan";
            this.BtnTan.UseVisualStyleBackColor = false;
            this.BtnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCos.Location = new System.Drawing.Point(85, 149);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(67, 38);
            this.BtnCos.TabIndex = 6;
            this.BtnCos.Text = "cos";
            this.BtnCos.UseVisualStyleBackColor = false;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnSin
            // 
            this.BtnSin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSin.Location = new System.Drawing.Point(12, 149);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(67, 38);
            this.BtnSin.TabIndex = 5;
            this.BtnSin.Text = "sin";
            this.BtnSin.UseVisualStyleBackColor = false;
            this.BtnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(304, 193);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(67, 38);
            this.BtnBorrar.TabIndex = 12;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // Btn10
            // 
            this.Btn10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn10.Location = new System.Drawing.Point(158, 193);
            this.Btn10.Name = "Btn10";
            this.Btn10.Size = new System.Drawing.Size(67, 38);
            this.Btn10.TabIndex = 11;
            this.Btn10.Text = "9";
            this.Btn10.UseVisualStyleBackColor = false;
            this.Btn10.Click += new System.EventHandler(this.Btn10_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(85, 193);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(67, 38);
            this.Btn8.TabIndex = 10;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(12, 193);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(67, 38);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(231, 281);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(67, 38);
            this.BtnMult.TabIndex = 16;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = false;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(158, 237);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(67, 38);
            this.Btn6.TabIndex = 15;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(85, 237);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(67, 38);
            this.Btn5.TabIndex = 14;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(12, 237);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(67, 38);
            this.Btn4.TabIndex = 13;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSum.Location = new System.Drawing.Point(304, 325);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(67, 38);
            this.BtnSum.TabIndex = 20;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = false;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(158, 281);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(67, 38);
            this.Btn3.TabIndex = 19;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(85, 281);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(67, 38);
            this.Btn2.TabIndex = 18;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(12, 281);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(67, 38);
            this.Btn1.TabIndex = 17;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRest.Location = new System.Drawing.Point(304, 281);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(67, 38);
            this.BtnRest.TabIndex = 24;
            this.BtnRest.Text = "-";
            this.BtnRest.UseVisualStyleBackColor = false;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.Location = new System.Drawing.Point(231, 325);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(67, 38);
            this.BtnIgual.TabIndex = 23;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = false;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnP
            // 
            this.BtnP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnP.Location = new System.Drawing.Point(85, 325);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(67, 38);
            this.BtnP.TabIndex = 22;
            this.BtnP.Text = ".";
            this.BtnP.UseVisualStyleBackColor = false;
            this.BtnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(12, 325);
            this.Btn0.Name = "Btn0";
            this.Btn0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn0.Size = new System.Drawing.Size(67, 38);
            this.Btn0.TabIndex = 21;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(231, 237);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(67, 38);
            this.BtnDiv.TabIndex = 25;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnPc
            // 
            this.BtnPc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPc.Location = new System.Drawing.Point(231, 193);
            this.BtnPc.Name = "BtnPc";
            this.BtnPc.Size = new System.Drawing.Size(67, 38);
            this.BtnPc.TabIndex = 27;
            this.BtnPc.Text = ")";
            this.BtnPc.UseVisualStyleBackColor = false;
            this.BtnPc.Click += new System.EventHandler(this.BtnPc_Click);
            // 
            // BtnPa
            // 
            this.BtnPa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPa.Location = new System.Drawing.Point(231, 149);
            this.BtnPa.Name = "BtnPa";
            this.BtnPa.Size = new System.Drawing.Size(67, 38);
            this.BtnPa.TabIndex = 26;
            this.BtnPa.Text = "(";
            this.BtnPa.UseVisualStyleBackColor = false;
            this.BtnPa.Click += new System.EventHandler(this.BtnPa_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMax.Location = new System.Drawing.Point(304, 149);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(67, 38);
            this.BtnMax.TabIndex = 30;
            this.BtnMax.Text = "max";
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.Location = new System.Drawing.Point(304, 105);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(67, 38);
            this.BtnMin.TabIndex = 29;
            this.BtnMin.Text = "min";
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // TxtBase
            // 
            this.TxtBase.Location = new System.Drawing.Point(222, 105);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(76, 20);
            this.TxtBase.TabIndex = 31;
            this.TxtBase.Visible = false;
            this.TxtBase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBase_MouseClick);
            this.TxtBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBase_KeyPress);
            // 
            // TxtExp
            // 
            this.TxtExp.Location = new System.Drawing.Point(222, 127);
            this.TxtExp.Name = "TxtExp";
            this.TxtExp.Size = new System.Drawing.Size(76, 20);
            this.TxtExp.TabIndex = 32;
            this.TxtExp.Visible = false;
            this.TxtExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtExp_KeyPress);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(304, 105);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(67, 38);
            this.BtnBack.TabIndex = 33;
            this.BtnBack.Text = "Regresar";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblBase
            // 
            this.LblBase.AutoSize = true;
            this.LblBase.Location = new System.Drawing.Point(158, 108);
            this.LblBase.Name = "LblBase";
            this.LblBase.Size = new System.Drawing.Size(31, 13);
            this.LblBase.TabIndex = 34;
            this.LblBase.Text = "Base";
            this.LblBase.Visible = false;
            // 
            // LblExponente
            // 
            this.LblExponente.AutoSize = true;
            this.LblExponente.Location = new System.Drawing.Point(158, 130);
            this.LblExponente.Name = "LblExponente";
            this.LblExponente.Size = new System.Drawing.Size(58, 13);
            this.LblExponente.TabIndex = 35;
            this.LblExponente.Text = "Exponente";
            this.LblExponente.Visible = false;
            // 
            // BtnAbs
            // 
            this.BtnAbs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbs.Location = new System.Drawing.Point(158, 325);
            this.BtnAbs.Name = "BtnAbs";
            this.BtnAbs.Size = new System.Drawing.Size(67, 38);
            this.BtnAbs.TabIndex = 36;
            this.BtnAbs.Text = "abs";
            this.BtnAbs.UseVisualStyleBackColor = false;
            this.BtnAbs.Click += new System.EventHandler(this.BtnAbs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(386, 377);
            this.Controls.Add(this.BtnAbs);
            this.Controls.Add(this.LblExponente);
            this.Controls.Add(this.LblBase);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxtExp);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.BtnMax);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnPc);
            this.Controls.Add(this.BtnPa);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnRest);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnP);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.Btn10);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnMov);
            this.Controls.Add(this.BtnTan);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.BtnLn);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.BtnPot);
            this.Controls.Add(this.BtnRaiz);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRaiz;
        private System.Windows.Forms.Button BtnPot;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Button BtnLn;
        private System.Windows.Forms.Button BtnMov;
        private System.Windows.Forms.Button BtnTan;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button BtnSin;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button Btn10;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnP;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.TextBox TxtAux;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.TextBox TxtNumbers;
        private System.Windows.Forms.Button BtnPc;
        private System.Windows.Forms.Button BtnPa;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.TextBox TxtExp;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblBase;
        private System.Windows.Forms.Label LblExponente;
        private System.Windows.Forms.Button BtnAbs;
    }
}

