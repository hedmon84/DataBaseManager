namespace DB2PJ1
{
    partial class CrearIndice
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colpk = new System.Windows.Forms.ComboBox();
            this.tabpk = new System.Windows.Forms.ComboBox();
            this.addpk = new System.Windows.Forms.Button();
            this.dgvpk = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colref = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabref = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colfk = new System.Windows.Forms.ComboBox();
            this.tabfk = new System.Windows.Forms.ComboBox();
            this.addfk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colidx = new System.Windows.Forms.ComboBox();
            this.tabidx = new System.Windows.Forms.ComboBox();
            this.addidx = new System.Windows.Forms.Button();
            this.dgvidx = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvidx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colpk);
            this.groupBox1.Controls.Add(this.tabpk);
            this.groupBox1.Controls.Add(this.addpk);
            this.groupBox1.Controls.Add(this.dgvpk);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 154);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PK";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columna:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla:  ";
            // 
            // colpk
            // 
            this.colpk.FormattingEnabled = true;
            this.colpk.Location = new System.Drawing.Point(89, 46);
            this.colpk.Name = "colpk";
            this.colpk.Size = new System.Drawing.Size(121, 21);
            this.colpk.TabIndex = 3;
            this.colpk.SelectedIndexChanged += new System.EventHandler(this.colpk_SelectedIndexChanged);
            // 
            // tabpk
            // 
            this.tabpk.FormattingEnabled = true;
            this.tabpk.Location = new System.Drawing.Point(89, 19);
            this.tabpk.Name = "tabpk";
            this.tabpk.Size = new System.Drawing.Size(121, 21);
            this.tabpk.TabIndex = 2;
            this.tabpk.SelectedIndexChanged += new System.EventHandler(this.tabpk_SelectedIndexChanged);
            // 
            // addpk
            // 
            this.addpk.Location = new System.Drawing.Point(110, 97);
            this.addpk.Name = "addpk";
            this.addpk.Size = new System.Drawing.Size(75, 23);
            this.addpk.TabIndex = 1;
            this.addpk.Text = "Crear";
            this.addpk.UseVisualStyleBackColor = true;
            this.addpk.Click += new System.EventHandler(this.addpk_Click);
            // 
            // dgvpk
            // 
            this.dgvpk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpk.Location = new System.Drawing.Point(225, 19);
            this.dgvpk.Name = "dgvpk";
            this.dgvpk.Size = new System.Drawing.Size(545, 101);
            this.dgvpk.TabIndex = 0;
            this.dgvpk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpk_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.colref);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tabref);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.colfk);
            this.groupBox2.Controls.Add(this.tabfk);
            this.groupBox2.Controls.Add(this.addfk);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 158);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FK";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // colref
            // 
            this.colref.FormattingEnabled = true;
            this.colref.Location = new System.Drawing.Point(89, 100);
            this.colref.Name = "colref";
            this.colref.Size = new System.Drawing.Size(121, 21);
            this.colref.TabIndex = 7;
            this.colref.SelectedIndexChanged += new System.EventHandler(this.colref_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Columna Ref:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tabla Ref:  ";
            // 
            // tabref
            // 
            this.tabref.FormattingEnabled = true;
            this.tabref.Location = new System.Drawing.Point(89, 73);
            this.tabref.Name = "tabref";
            this.tabref.Size = new System.Drawing.Size(121, 21);
            this.tabref.TabIndex = 6;
            this.tabref.SelectedIndexChanged += new System.EventHandler(this.tabref_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Columna:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tabla:  ";
            // 
            // colfk
            // 
            this.colfk.FormattingEnabled = true;
            this.colfk.Location = new System.Drawing.Point(89, 46);
            this.colfk.Name = "colfk";
            this.colfk.Size = new System.Drawing.Size(121, 21);
            this.colfk.TabIndex = 3;
            this.colfk.SelectedIndexChanged += new System.EventHandler(this.colfk_SelectedIndexChanged);
            // 
            // tabfk
            // 
            this.tabfk.FormattingEnabled = true;
            this.tabfk.Location = new System.Drawing.Point(89, 19);
            this.tabfk.Name = "tabfk";
            this.tabfk.Size = new System.Drawing.Size(121, 21);
            this.tabfk.TabIndex = 2;
            this.tabfk.SelectedIndexChanged += new System.EventHandler(this.tabfk_SelectedIndexChanged);
            // 
            // addfk
            // 
            this.addfk.Location = new System.Drawing.Point(110, 127);
            this.addfk.Name = "addfk";
            this.addfk.Size = new System.Drawing.Size(75, 23);
            this.addfk.TabIndex = 1;
            this.addfk.Text = "Crear";
            this.addfk.UseVisualStyleBackColor = true;
            this.addfk.Click += new System.EventHandler(this.addfk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.colidx);
            this.groupBox3.Controls.Add(this.tabidx);
            this.groupBox3.Controls.Add(this.addidx);
            this.groupBox3.Controls.Add(this.dgvidx);
            this.groupBox3.Location = new System.Drawing.Point(6, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 125);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Index";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Columna:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tabla:  ";
            // 
            // colidx
            // 
            this.colidx.FormattingEnabled = true;
            this.colidx.Location = new System.Drawing.Point(89, 46);
            this.colidx.Name = "colidx";
            this.colidx.Size = new System.Drawing.Size(121, 21);
            this.colidx.TabIndex = 3;
            this.colidx.SelectedIndexChanged += new System.EventHandler(this.colidx_SelectedIndexChanged);
            // 
            // tabidx
            // 
            this.tabidx.FormattingEnabled = true;
            this.tabidx.Location = new System.Drawing.Point(89, 19);
            this.tabidx.Name = "tabidx";
            this.tabidx.Size = new System.Drawing.Size(121, 21);
            this.tabidx.TabIndex = 2;
            this.tabidx.SelectedIndexChanged += new System.EventHandler(this.tabidx_SelectedIndexChanged);
            // 
            // addidx
            // 
            this.addidx.Location = new System.Drawing.Point(110, 96);
            this.addidx.Name = "addidx";
            this.addidx.Size = new System.Drawing.Size(75, 23);
            this.addidx.TabIndex = 1;
            this.addidx.Text = "Crear";
            this.addidx.UseVisualStyleBackColor = true;
            this.addidx.Click += new System.EventHandler(this.addidx_Click);
            // 
            // dgvidx
            // 
            this.dgvidx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvidx.Location = new System.Drawing.Point(225, 19);
            this.dgvidx.Name = "dgvidx";
            this.dgvidx.Size = new System.Drawing.Size(545, 101);
            this.dgvidx.TabIndex = 0;
            // 
            // CrearIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearIndice";
            this.Text = "CrearIndice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvidx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colpk;
        private System.Windows.Forms.ComboBox tabpk;
        private System.Windows.Forms.Button addpk;
        private System.Windows.Forms.DataGridView dgvpk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox colref;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tabref;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colfk;
        private System.Windows.Forms.ComboBox tabfk;
        private System.Windows.Forms.Button addfk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox colidx;
        private System.Windows.Forms.ComboBox tabidx;
        private System.Windows.Forms.Button addidx;
        private System.Windows.Forms.DataGridView dgvidx;
    }
}