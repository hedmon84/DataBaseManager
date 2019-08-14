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
    public partial class ListProcedures : Form
    {

        DB2 tool = new DB2();
        public ListProcedures()
        {
            InitializeComponent();
            string query = "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'ADMINISTRATOR'";

            tool.fillDataGrid(this.dgv, query);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
