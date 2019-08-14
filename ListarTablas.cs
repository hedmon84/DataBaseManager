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
    public partial class ListarTablas : Form
    {

        DB2 tool = new DB2();

        public ListarTablas()
        {
            InitializeComponent();

            string query = "select name from sysibm.systables where creator  = 'ADMINISTRATOR'";
            tool.fillcomboDB(this.tables, query);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tables_SelectedIndexChanged(object sender, EventArgs e)
        {
             string query = "select * from " + tables.Text;
            tool.fillDataGrid(dgv, query);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
