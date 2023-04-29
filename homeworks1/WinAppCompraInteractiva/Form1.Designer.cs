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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChShirt = new System.Windows.Forms.CheckBox();
            this.ChPants = new System.Windows.Forms.CheckBox();
            this.ChVest = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbMasc = new System.Windows.Forms.RadioButton();
            this.RdbFem = new System.Windows.Forms.RadioButton();
            this.PbxVest = new System.Windows.Forms.PictureBox();
            this.PbxPant = new System.Windows.Forms.PictureBox();
            this.PbxBlusa = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PbxGen = new System.Windows.Forms.PictureBox();
            this.PbxLista = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxVest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBlusa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 30);
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
            this.groupBox1.Size = new System.Drawing.Size(270, 122);
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
            this.groupBox2.Location = new System.Drawing.Point(331, 122);
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
            // PbxVest
            // 
            this.PbxVest.Image = ((System.Drawing.Image)(resources.GetObject("PbxVest.Image")));
            this.PbxVest.Location = new System.Drawing.Point(26, 283);
            this.PbxVest.Name = "PbxVest";
            this.PbxVest.Size = new System.Drawing.Size(110, 109);
            this.PbxVest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxVest.TabIndex = 3;
            this.PbxVest.TabStop = false;
            this.PbxVest.Visible = false;
            // 
            // PbxPant
            // 
            this.PbxPant.Image = ((System.Drawing.Image)(resources.GetObject("PbxPant.Image")));
            this.PbxPant.Location = new System.Drawing.Point(142, 283);
            this.PbxPant.Name = "PbxPant";
            this.PbxPant.Size = new System.Drawing.Size(110, 109);
            this.PbxPant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPant.TabIndex = 4;
            this.PbxPant.TabStop = false;
            this.PbxPant.Visible = false;
            // 
            // PbxBlusa
            // 
            this.PbxBlusa.Image = ((System.Drawing.Image)(resources.GetObject("PbxBlusa.Image")));
            this.PbxBlusa.Location = new System.Drawing.Point(258, 283);
            this.PbxBlusa.Name = "PbxBlusa";
            this.PbxBlusa.Size = new System.Drawing.Size(110, 109);
            this.PbxBlusa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBlusa.TabIndex = 5;
            this.PbxBlusa.TabStop = false;
            this.PbxBlusa.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Vestido",
            "Pantalón",
            "Blusa"});
            this.listBox1.Location = new System.Drawing.Point(475, 268);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 56);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PbxGen
            // 
            this.PbxGen.Location = new System.Drawing.Point(475, 136);
            this.PbxGen.Name = "PbxGen";
            this.PbxGen.Size = new System.Drawing.Size(116, 84);
            this.PbxGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxGen.TabIndex = 7;
            this.PbxGen.TabStop = false;
            // 
            // PbxLista
            // 
            this.PbxLista.Location = new System.Drawing.Point(611, 136);
            this.PbxLista.Name = "PbxLista";
            this.PbxLista.Size = new System.Drawing.Size(116, 84);
            this.PbxLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxLista.TabIndex = 8;
            this.PbxLista.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vestido",
            "Pantalón",
            "Blusa"});
            this.comboBox1.Location = new System.Drawing.Point(611, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(258, 76);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 10;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(451, 76);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 11;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3});
            this.dataGridView1.Location = new System.Drawing.Point(767, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // BtnBuy
            // 
            this.BtnBuy.Location = new System.Drawing.Point(876, 283);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(135, 63);
            this.BtnBuy.TabIndex = 15;
            this.BtnBuy.Text = "Comprar";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
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
            // C3
            // 
            this.C3.HeaderText = "Fotos";
            this.C3.Name = "C3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 402);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PbxLista);
            this.Controls.Add(this.PbxGen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PbxBlusa);
            this.Controls.Add(this.PbxPant);
            this.Controls.Add(this.PbxVest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxVest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBlusa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLista)).EndInit();
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
        private System.Windows.Forms.PictureBox PbxVest;
        private System.Windows.Forms.PictureBox PbxPant;
        private System.Windows.Forms.PictureBox PbxBlusa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox PbxGen;
        private System.Windows.Forms.PictureBox PbxLista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
    }
}

