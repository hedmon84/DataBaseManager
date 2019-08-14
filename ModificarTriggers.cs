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
    public partial class ModificarTriggers : Form
    {
        DB2 tool = new DB2();
        public ModificarTriggers()
        {
            InitializeComponent();
            string q = "select trigname as Nombre, text as DDL from syscat.triggers where owner = 'ADMINISTRATOR'";
            string qe = "select trigname from syscat.triggers where owner = 'USUARIO'";

            tool.fillcomboDB(pk, qe);
            tool.fillDataGrid(dgvpk, q);
        }

        private void pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = tool.ddl("select text as DDL from syscat.triggers where owner = 'USUARIO' and trigname = '" + textBox1.Text + "'");

        }

            private void addpk_Click(object sender, EventArgs e)
        {
            string tab = "select text as DDL from syscat.triggers where owner = 'ADMINISTRATOR' and trigname = '" + textBox1.Text + "'";
            string query = "drop trigger " + textBox1.Text;
            tool.dropCmd(query, tool.ddl(tab));
            tool.sendCmd(textBox1.Text);
            tool.fillDataGrid(dgvpk, "select trigname as Nombre, text as DDL from syscat.triggers where owner = 'ADMINISTRATOR'");
        }
    }
}
