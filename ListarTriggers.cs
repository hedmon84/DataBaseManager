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
    public partial class ListarTriggers : Form
    {
        DB2 tool = new DB2();
        public ListarTriggers()
        {
            InitializeComponent();
            string q = "select trigname as Nombre, text as DDL from syscat.triggers where owner = 'ADMINISTRATOR'";
            tool.fillDataGrid(dgv, q);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
