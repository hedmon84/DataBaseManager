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
    public partial class CrearProcedures : Form
    {
        DB2 tool = new DB2();
        public CrearProcedures()
        {
            InitializeComponent();
            string q = "select routinename as Nombre, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'P'";
            string qf = "select routinename as Nombre, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'F'";
            tool.fillDataGrid(dgvproc, q);
            tool.fillDataGrid(dgvfunc, qf);
        }

        private void proc_TextChanged(object sender, EventArgs e)
        {

        }

        private void crearproc_Click(object sender, EventArgs e)
        {
            string q = proc.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvproc, "select routinename as Nombre, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'P'");

        }

        private void func_TextChanged(object sender, EventArgs e)
        {
            string q = func.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvfunc, "select routinename as Nombre, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'F'");

        }
    }
}
