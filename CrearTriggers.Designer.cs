namespace DB2PJ1
{
    partial class CrearTriggers
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
            this.crearproc = new System.Windows.Forms.Button();
            this.dgvproc = new System.Windows.Forms.DataGridView();
            this.proc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crearproc);
            this.groupBox1.Controls.Add(this.dgvproc);
            this.groupBox1.Controls.Add(this.proc);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 223);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triggers";
            // 
            // crearproc
            // 
            this.crearproc.Location = new System.Drawing.Point(7, 187);
            this.crearproc.Name = "crearproc";
            this.crearproc.Size = new System.Drawing.Size(75, 23);
            this.crearproc.TabIndex = 2;
            this.crearproc.Text = "Crear";
            this.crearproc.UseVisualStyleBackColor = true;
            this.crearproc.Click += new System.EventHandler(this.crearproc_Click);
            // 
            // dgvproc
            // 
            this.dgvproc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproc.Location = new System.Drawing.Point(241, 20);
            this.dgvproc.Name = "dgvproc";
            this.dgvproc.Size = new System.Drawing.Size(528, 160);
            this.dgvproc.TabIndex = 1;
            // 
            // proc
            // 
            this.proc.Location = new System.Drawing.Point(7, 20);
            this.proc.Multiline = true;
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(227, 160);
            this.proc.TabIndex = 0;
            this.proc.TextChanged += new System.EventHandler(this.proc_TextChanged);
            // 
            // CrearTriggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 260);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearTriggers";
            this.Text = "CrearTriggers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button crearproc;
        private System.Windows.Forms.DataGridView dgvproc;
        private System.Windows.Forms.TextBox proc;
    }
}