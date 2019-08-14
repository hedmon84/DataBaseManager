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
    public partial class BorrarViews : Form
    {
        DB2 tool = new DB2();
        public BorrarViews()
        {
            InitializeComponent();
            string query = "select viewname as Nombre from syscat.views where owner = 'ADMINISTRATOR'";
            string q = "select viewname from syscat.views where owner = 'ADMINISTRATOR'";
            tool.fillcomboDB(trame, q);
            tool.fillDataGrid(dgv, query);
        }

        private void trame_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v = tool.PoC(trame.Text);
            string q = "select viewname as Nombre, text as Script from syscat.views where viewname = '" + trame.Text + "'";
            tool.fillDataGrid(dataGridView1, q);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryc = "select viewname as Nombre from syscat.views where owner = 'ADMINISTRATOR'";
            string q = "select viewname from syscat.views where owner = 'ADMINISTRATOR'";
            if (string.IsNullOrWhiteSpace(trame.Text))
            {
                System.Windows.Forms.MessageBox.Show("Seleccione un view a borrar");
            }
            else
            {

                string query = "drop view " + trame.Text;
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
