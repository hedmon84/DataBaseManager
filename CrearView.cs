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
    public partial class CrearView : Form
    {
        DB2 tool = new DB2();
        public CrearView()
        {
            InitializeComponent();
            string q = "select viewname as Nombre, text as DDL from syscat.views where owner = 'ADMINISTRATOR'";
            tool.fillDataGrid(dgvproc, q);
        }

        private void proc_TextChanged(object sender, EventArgs e)
        {

        }

        private void crearproc_Click(object sender, EventArgs e)
        {
            string q = proc.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvproc, "select viewname as Nombre, text as DDL from syscat.views where owner = 'ADMINISTRATOR'");
        }
    }
}
