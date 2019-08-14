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
    public partial class ListarViews : Form
    {
        DB2 tool = new DB2();
        public ListarViews()
        {
            string q = "select viewname as Nombre, text as DDL from syscat.views where owner = 'ADMINISTRATOR'";
            InitializeComponent();
            tool.fillDataGrid(dgv, q);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
