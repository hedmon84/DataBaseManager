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
    public partial class CrearTriggers : Form
    {
        DB2 tool = new DB2();
        public CrearTriggers()
        {
            InitializeComponent();
            string q = "select trigname as Nombre, text ad DDL from syscat.triggers where owner = 'ADMINISTRATOR'";
            tool.fillDataGrid(dgvproc, q);
        }

        private void crearproc_Click(object sender, EventArgs e)
        {
            string q = proc.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvproc, "select trigname as Nombre, text ad DDL from syscat.triggers where owner = 'ADMINISTRATOR'");
        }

        private void proc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
