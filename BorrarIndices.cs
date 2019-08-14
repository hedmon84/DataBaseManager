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
    public partial class BorrarIndices : Form
    {
        DB2 tool = new DB2();
        public BorrarIndices()
        {
            InitializeComponent();
            string q = "select name from sysibm.systables where creator  = 'ADMINISTRATOR'";
            tabpk.Text = "Tabla";
            tabfk.Text = "Tabla";
            tabind.Text = "Tabla";
            tool.fillcomboDB(tabpk, q);
            tool.fillcomboDB(tabfk, q);
            tool.fillcomboDB(tabind, q);
        }

        private void BorrarIndices_Load(object sender, EventArgs e)
        {

        }

        private void tabpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qd = "select colname as PK, tabname as Tabla from syscat.keycoluse where tabname = '" + tabpk.Text + "'";
            string q = "select colname from syscat.keycoluse where tabname = '" + tabpk.Text + "'";
            tool.fillcomboDB(pkname, q);
            tool.fillDataGrid(dgvpk, qd);
        }

        private void pkname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btpk_Click(object sender, EventArgs e)
        {
            string q = "alter table " + tabpk.Text + " drop primary key";
            tool.sendCmd(q);
            System.Windows.Forms.MessageBox.Show("PK Borrada");
            dgvpk.DataSource = null;
            dgvpk.Update();
            dgvpk.Refresh();
            pkname.Items.Clear();
            pkname.Text = "";
            //tabpk.Items.Clear();
            tabpk.Text = "";

        }

        private void tabfk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qfkd = "select constname as FK, tabname as Tabla, reftabname as Referencia from syscat.references where tabname = '" + tabfk.Text + "'";
            string qfk = "select constname from syscat.references where tabname = '" + tabfk.Text + "'";
            tool.fillcomboDB(fkname, qfk);
            tool.fillDataGrid(dgvfk, qfkd);

        }

        private void btfk_Click(object sender, EventArgs e)
        {
            string q = "alter table " + tabfk.Text + " drop foreign key " + fkname.Text;
            tool.sendCmd(q);
            System.Windows.Forms.MessageBox.Show("FK Borrada");
            dgvfk.DataSource = null;
            dgvfk.Update();
            dgvfk.Refresh();
            fkname.Items.Clear();
            fkname.Text = "";
            //tabfk.Items.Clear();
            tabfk.Text = "";
        }

        private void tabind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qid = "select name as Indice, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbname = '" + tabind.Text + "' and uniquerule != 'P'";
            string qi = "select name from sysibm.sysindexes where tbname = '" + tabind.Text + "'";
            tool.fillcomboDB(indname, qi);
            tool.fillDataGrid(dgvind, qid);
        }

        private void btind_Click(object sender, EventArgs e)
        {
            string q = "drop index " + indname.Text;
            tool.sendCmd(q);
            System.Windows.Forms.MessageBox.Show("Indice Borrado");
            dgvind.DataSource = null;
            dgvind.Update();
            dgvind.Refresh();
            indname.Items.Clear();
            indname.Text = "";
            // tabind.Items.Clear();
            tabind.Text = "";
        }
    }

        
    
}
