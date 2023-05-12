namespace WinAppCompraInteractiva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChShirt = new System.Windows.Forms.CheckBox();
            this.ChPants = new System.Windows.Forms.CheckBox();
            this.ChVest = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbMasc = new System.Windows.Forms.RadioButton();
            this.RdbFem = new System.Windows.Forms.RadioButton();
            this.PbxClothes = new System.Windows.Forms.PictureBox();
            this.PbxGen = new System.Windows.Forms.PictureBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSubt = new System.Windows.Forms.Label();
            this.LblIva = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClothes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRA INTERACTIVA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChShirt);
            this.groupBox1.Controls.Add(this.ChPants);
            this.groupBox1.Controls.Add(this.ChVest);
            this.groupBox1.Location = new System.Drawing.Point(40, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prendas de Vestir";
            // 
            // ChShirt
            // 
            this.ChShirt.AutoSize = true;
            this.ChShirt.Location = new System.Drawing.Point(33, 84);
            this.ChShirt.Name = "ChShirt";
            this.ChShirt.Size = new System.Drawing.Size(52, 17);
            this.ChShirt.TabIndex = 2;
            this.ChShirt.Text = "Blusa";
            this.ChShirt.UseVisualStyleBackColor = true;
            this.ChShirt.CheckedChanged += new System.EventHandler(this.ChShirt_CheckedChanged);
            // 
            // ChPants
            // 
            this.ChPants.AutoSize = true;
            this.ChPants.Location = new System.Drawing.Point(33, 61);
            this.ChPants.Name = "ChPants";
            this.ChPants.Size = new System.Drawing.Size(68, 17);
            this.ChPants.TabIndex = 1;
            this.ChPants.Text = "Pantalón";
            this.ChPants.UseVisualStyleBackColor = true;
            this.ChPants.CheckedChanged += new System.EventHandler(this.ChPants_CheckedChanged);
            // 
            // ChVest
            // 
            this.ChVest.AutoSize = true;
            this.ChVest.Location = new System.Drawing.Point(33, 38);
            this.ChVest.Name = "ChVest";
            this.ChVest.Size = new System.Drawing.Size(61, 17);
            this.ChVest.TabIndex = 0;
            this.ChVest.Text = "Vestido";
            this.ChVest.UseVisualStyleBackColor = true;
            this.ChVest.CheckedChanged += new System.EventHandler(this.ChVest_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbMasc);
            this.groupBox2.Controls.Add(this.RdbFem);
            this.groupBox2.Location = new System.Drawing.Point(178, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Género";
            // 
            // RdbMasc
            // 
            this.RdbMasc.AutoSize = true;
            this.RdbMasc.Location = new System.Drawing.Point(20, 67);
            this.RdbMasc.Name = "RdbMasc";
            this.RdbMasc.Size = new System.Drawing.Size(73, 17);
            this.RdbMasc.TabIndex = 1;
            this.RdbMasc.TabStop = true;
            this.RdbMasc.Text = "Masculino";
            this.RdbMasc.UseVisualStyleBackColor = true;
            // 
            // RdbFem
            // 
            this.RdbFem.AutoSize = true;
            this.RdbFem.Location = new System.Drawing.Point(20, 44);
            this.RdbFem.Name = "RdbFem";
            this.RdbFem.Size = new System.Drawing.Size(71, 17);
            this.RdbFem.TabIndex = 0;
            this.RdbFem.TabStop = true;
            this.RdbFem.Text = "Femenino";
            this.RdbFem.UseVisualStyleBackColor = true;
            this.RdbFem.CheckedChanged += new System.EventHandler(this.RdbFem_CheckedChanged);
            // 
            // PbxClothes
            // 
            this.PbxClothes.Location = new System.Drawing.Point(451, 132);
            this.PbxClothes.Name = "PbxClothes";
            this.PbxClothes.Size = new System.Drawing.Size(110, 109);
            this.PbxClothes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxClothes.TabIndex = 3;
            this.PbxClothes.TabStop = false;
            // 
            // PbxGen
            // 
            this.PbxGen.Location = new System.Drawing.Point(325, 132);
            this.PbxGen.Name = "PbxGen";
            this.PbxGen.Size = new System.Drawing.Size(110, 109);
            this.PbxGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxGen.TabIndex = 7;
            this.PbxGen.TabStop = false;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(258, 76);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 10;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(451, 76);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 11;
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLastName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.Desc,
            this.C3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(40, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(487, 147);
            this.dataGridView1.TabIndex = 14;
            // 
            // BtnBuy
            // 
            this.BtnBuy.Location = new System.Drawing.Point(537, 374);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(135, 57);
            this.BtnBuy.TabIndex = 15;
            this.BtnBuy.Text = "Comprar";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(672, 143);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(135, 63);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Agregar al Carrito";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prenda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio";
            // 
            // LblSubt
            // 
            this.LblSubt.AutoSize = true;
            this.LblSubt.Location = new System.Drawing.Point(534, 294);
            this.LblSubt.Name = "LblSubt";
            this.LblSubt.Size = new System.Drawing.Size(52, 13);
            this.LblSubt.TabIndex = 20;
            this.LblSubt.Text = "Subtotal: ";
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Location = new System.Drawing.Point(534, 317);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(53, 13);
            this.LblIva.TabIndex = 21;
            this.LblIva.Text = "IVA 12%: ";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(534, 340);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 22;
            this.LblTotal.Text = "Total:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(586, 180);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 23;
            this.LblPrecio.Text = "$ 0.00";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(678, 374);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(135, 57);
            this.BtnExit.TabIndex = 24;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(672, 222);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(135, 63);
            this.BtnDelete.TabIndex = 25;
            this.BtnDelete.Text = "Eliminar del Carrito";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // C1
            // 
            this.C1.HeaderText = "Nombre";
            this.C1.Name = "C1";
            // 
            // C2
            // 
            this.C2.HeaderText = "Apellido";
            this.C2.Name = "C2";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripción";
            this.Desc.Name = "Desc";
            // 
            // C3
            // 
            this.C3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C3.HeaderText = "Fotos";
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Carrito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.LblSubt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.PbxGen);
            this.Controls.Add(this.PbxClothes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra interactiva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClothes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChShirt;
        private System.Windows.Forms.CheckBox ChPants;
        private System.Windows.Forms.CheckBox ChVest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbMasc;
        private System.Windows.Forms.RadioButton RdbFem;
        private System.Windows.Forms.PictureBox PbxClothes;
        private System.Windows.Forms.PictureBox PbxGen;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSubt;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewImageColumn C3;
        private System.Windows.Forms.Label label7;
    }
}

