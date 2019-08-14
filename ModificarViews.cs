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
    public partial class ModificarViews : Form
    {
        DB2 tool = new DB2();
        public ModificarViews()
        {
            InitializeComponent();
            string q = "select viewname from syscat.views where owner = 'ADMINISTRATOR'";
            string qdg = "select viewname as Nombre, text as DDL from syscat.views where owner = 'ADMINISTRATOR'";

            tool.fillcomboDB(pk, q);
            tool.fillDataGrid(dgvpk, qdg);
        }

        private void pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = tool.ddl("select text as DDL from syscat.views where owner = 'ADMINISTRATOR' and viewname = '" + textBox1.Text + "'");

        }

        private void addpk_Click(object sender, EventArgs e)
        {
            string tab = "select text as DDL from syscat.views where owner = 'ADMINISTRATOR' viewname = '" + textBox1.Text + "'";
            string query = "drop view " + textBox1.Text;
            tool.dropCmd(query, tool.ddl(tab));
            tool.sendCmd(textBox1.Text);
            tool.fillDataGrid(dgvpk, "select viewname as Nombre, text as DDL from syscat.views where owner = 'ADMINISTRATOR'");
        }
    }
}
