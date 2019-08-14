namespace DB2PJ1
{
    partial class ListarIndices
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
            this.dgvpk = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvind = new System.Windows.Forms.DataGridView();
            this.dgvfk = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvpk);
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llaves Primarias";
            // 
            // dgvpk
            // 
            this.dgvpk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpk.Location = new System.Drawing.Point(7, 20);
            this.dgvpk.Name = "dgvpk";
            this.dgvpk.Size = new System.Drawing.Size(762, 121);
            this.dgvpk.TabIndex = 0;
            this.dgvpk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpk_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvfk);
            this.groupBox2.Location = new System.Drawing.Point(39, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 158);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Llaves Foraneas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvind);
            this.groupBox3.Location = new System.Drawing.Point(39, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 162);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Indices";
            // 
            // dgvind
            // 
            this.dgvind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvind.Location = new System.Drawing.Point(7, 18);
            this.dgvind.Name = "dgvind";
            this.dgvind.Size = new System.Drawing.Size(762, 136);
            this.dgvind.TabIndex = 0;
            this.dgvind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvind_CellContentClick);
            // 
            // dgvfk
            // 
            this.dgvfk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfk.Location = new System.Drawing.Point(7, 20);
            this.dgvfk.Name = "dgvfk";
            this.dgvfk.Size = new System.Drawing.Size(762, 132);
            this.dgvfk.TabIndex = 0;
            // 
            // ListarIndices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListarIndices";
            this.Text = "ListarIndices";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvpk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvind;
        private System.Windows.Forms.DataGridView dgvfk;
    }
}