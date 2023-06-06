namespace Client
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
            this.BtnConn = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConn
            // 
            this.BtnConn.Location = new System.Drawing.Point(25, 28);
            this.BtnConn.Name = "BtnConn";
            this.BtnConn.Size = new System.Drawing.Size(75, 23);
            this.BtnConn.TabIndex = 7;
            this.BtnConn.Text = "CONNECT";
            this.BtnConn.UseVisualStyleBackColor = true;
            this.BtnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.Location = new System.Drawing.Point(12, 70);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(341, 91);
            this.TxtMessage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "CLIENT";
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(278, 167);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 10;
            this.BtnSend.Text = "SEND";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(12, 196);
            this.TxtStatus.Multiline = true;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(341, 91);
            this.TxtStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 299);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.BtnConn);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConn;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtStatus;
    }
}

