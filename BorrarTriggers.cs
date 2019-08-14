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
    public partial class BorrarTriggers : Form
    {
        DB2 tool = new DB2();
        public BorrarTriggers()
        {
            string query = "select trigname as Nombre from syscat.triggers where owner = 'ADMINISTRATOR'";
            string q = "select trigname from syscat.triggers where owner = 'ADMINISTRATOR'";
            InitializeComponent();
            tool.fillDataGrid(dgv, query);
            tool.fillcomboDB(this.trame, q);
        }

        private void trame_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v = tool.PoC(trame.Text);
            string q = "select trigname as Nombre, text as Script from syscat.triggers where trigname = '" + trame.Text + "'";
            tool.fillDataGrid(DataGridView1, q);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryc = "select trigname as Nombre from syscat.triggers where definer = 'ADMINISTRATOR'";
            string q = "select trigname from syscat.triggers where owner = 'ADMINISTRATOR'";
            if (string.IsNullOrWhiteSpace(trame.Text))
            {
                System.Windows.Forms.MessageBox.Show("Seleccione un trigger a borrar");
            }
            else
            {

                string query = "drop trigger " + trame.Text;
                tool.sendCmd(query);
                System.Windows.Forms.MessageBox.Show(trame.Text + " borrado");
                trame.Text = "";
                trame.Items.Clear();
                dgv.DataSource = null;
                dgv.Update();
                dgv.Refresh();
                tool.fillcomboDB(trame, q);
                tool.fillDataGrid(dgv, queryc);
            }
        }
    }
}
