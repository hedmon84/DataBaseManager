namespace DB2PJ1
{
    partial class CrearProcedures
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crearfunc = new System.Windows.Forms.Button();
            this.dgvfunc = new System.Windows.Forms.DataGridView();
            this.func = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crearproc);
            this.groupBox1.Controls.Add(this.dgvproc);
            this.groupBox1.Controls.Add(this.proc);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 223);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedures";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crearfunc);
            this.groupBox2.Controls.Add(this.dgvfunc);
            this.groupBox2.Controls.Add(this.func);
            this.groupBox2.Location = new System.Drawing.Point(13, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 214);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // crearfunc
            // 
            this.crearfunc.Location = new System.Drawing.Point(7, 184);
            this.crearfunc.Name = "crearfunc";
            this.crearfunc.Size = new System.Drawing.Size(75, 23);
            this.crearfunc.TabIndex = 3;
            this.crearfunc.Text = "Crear";
            this.crearfunc.UseVisualStyleBackColor = true;
            // 
            // dgvfunc
            // 
            this.dgvfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfunc.Location = new System.Drawing.Point(241, 20);
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.Size = new System.Drawing.Size(528, 159);
            this.dgvfunc.TabIndex = 2;
            // 
            // func
            // 
            this.func.Location = new System.Drawing.Point(7, 19);
            this.func.Multiline = true;
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(227, 160);
            this.func.TabIndex = 1;
            this.func.TextChanged += new System.EventHandler(this.func_TextChanged);
            // 
            // CrearProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearProcedures";
            this.Text = "CrearProcedures";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button crearproc;
        private System.Windows.Forms.DataGridView dgvproc;
        private System.Windows.Forms.TextBox proc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button crearfunc;
        private System.Windows.Forms.DataGridView dgvfunc;
        private System.Windows.Forms.TextBox func;
    }
}