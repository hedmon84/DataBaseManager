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
    public partial class ModificarProcedures : Form
    {

        DB2 tool = new DB2();
        public ModificarProcedures()
        {
            InitializeComponent();
            string query = "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'P'";
            string q = "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'F'";

            string queryc = "select routinename from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'P'";
            string qc = "select routinename from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'F'";

            tool.fillDataGrid(dgvpk, query);
            tool.fillDataGrid(dataGridView1, q);

            tool.fillcomboDB(pk, queryc);
            tool.fillcomboDB(fk, qc);
        }

        private void pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = tool.ddl("select text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'P' and routinename = '" + textBox1.Text + "'");
        }

        private void addpk_Click(object sender, EventArgs e)
        {
            string tab = "select text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'P' and routinename = '" + textBox1.Text + "'";
            string query = "drop procedure " + textBox1.Text;
            tool.dropCmd(query, tool.ddl(tab));
            tool.sendCmd(textBox1.Text);
            tool.fillDataGrid(dgvpk, "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'P'");

        }

        private void fk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = tool.ddl("select text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'F' and routinename = '" + textBox2.Text + "'");
        }

        private void addfk_Click(object sender, EventArgs e)
        {
            string tab = "select text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'F' and routinename = '" + textBox2.Text + "'";
            string query = "drop function " + textBox2.Text;
            tool.dropCmd(query, tool.ddl(tab));
            tool.sendCmd(textBox1.Text);
            tool.fillDataGrid(dgvpk, "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'ADMINISTRATOR' and routinetype = 'F'");

        }

        private void dgvpk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
