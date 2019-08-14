using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2PJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarTablas ta = new ListarTablas();
            ta.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearTablas form = new CrearTablas();
            form.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarTablas form = new ModificarTablas();
            form.Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarTablas form = new BorrarTablas();
            form.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarIndices form = new ListarIndices();
            form.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            CrearIndice form = new CrearIndice();
            form.Show();

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarIndices form = new ModificarIndices();
            form.Show();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarIndices form = new BorrarIndices();
            form.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListProcedures form = new ListProcedures();
            form.Show();
        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CrearProcedures form = new CrearProcedures();
            form.Show();

        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
