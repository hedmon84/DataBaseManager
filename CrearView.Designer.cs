namespace DB2PJ1
{
    partial class CrearView
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
            this.Views = new System.Windows.Forms.GroupBox();
            this.crearproc = new System.Windows.Forms.Button();
            this.dgvproc = new System.Windows.Forms.DataGridView();
            this.proc = new System.Windows.Forms.TextBox();
            this.Views.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproc)).BeginInit();
            this.SuspendLayout();
            // 
            // Views
            // 
            this.Views.Controls.Add(this.crearproc);
            this.Views.Controls.Add(this.dgvproc);
            this.Views.Controls.Add(this.proc);
            this.Views.Location = new System.Drawing.Point(12, 30);
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(775, 223);
            this.Views.TabIndex = 11;
            this.Views.TabStop = false;
            this.Views.Text = "Triggers";
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
            this.proc.Location = new System.Drawing.Point(8, 20);
            this.proc.Multiline = true;
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(227, 160);
            this.proc.TabIndex = 0;
            this.proc.TextChanged += new System.EventHandler(this.proc_TextChanged);
            // 
            // CrearView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 270);
            this.Controls.Add(this.Views);
            this.Name = "CrearView";
            this.Text = "CrearView";
            this.Views.ResumeLayout(false);
            this.Views.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Views;
        private System.Windows.Forms.Button crearproc;
        private System.Windows.Forms.DataGridView dgvproc;
        private System.Windows.Forms.TextBox proc;
    }
}