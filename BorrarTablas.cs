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
    public partial class BorrarTablas : Form
    {

        DB2 tool = new DB2();

        public BorrarTablas()
        {
            InitializeComponent();
            string query = "select name from sysibm.systables where creator  = 'ADMINISTRATOR'";
            tool.fillcomboDB(this.tabName, query);
            tool.fillDataGrid(dgv, query);
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tabName.Text))
            {

                string query = "drop table " + tabName.Text;
                System.Windows.Forms.MessageBox.Show("Tabla " + tabName.Text + " ha sido borrada");
                tool.sendCmd(query);
                tabName.Text = "";
                tool.fillcomboDB(tabName, "select name from sysibm.systables where creator  = 'ADMINISTRATOR'");
                tool.fillDataGrid(dgv, "select name from sysibm.systables where creator  = 'ADMINISTRATOR'");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No ha seleccionado una tabla");
            }

        }
    }
}
