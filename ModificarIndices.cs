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
    public partial class ModificarIndices : Form
    {

        DB2 tool = new DB2();
        TableSrcipt ts = new TableSrcipt();

        public ModificarIndices()
        {
            InitializeComponent();
            string pkt = "select name from sysibm.systables where creator  = 'ADMINISTRATOR'";

            string qdgv = "select colname as PK, tabname as Tabla from syscat.keycoluse where tabschema = 'ADMINISTRATOR'";
            string qfkdgv = "select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname ";
            string qidgv = "select name as Indice, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbcreator = 'USUARIO' and uniquerule = 'U'";


            tool.fillcomboDB(comboBox1, pkt);
            tool.fillcomboDB(comboBox2, pkt);
            tool.fillcomboDB(comboBox3, pkt);






            tool.fillDataGrid(dgvpk, qdgv);
            tool.fillDataGrid(dataGridView1, qfkdgv);
            tool.fillDataGrid(dgvidx, qidgv);

            //  textBox1.Text = "alter table _____ add primary key (_____)";
            textBox2.Text = "alter table _____ add constraint _____|_FK foreign key (_____) references _____ (_____) not enforced";
            textBox3.Text = "create unique index _____ on _____ (______)";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "select colname from syscat.keycoluse where tabschema = 'ADMINISTRATOR' and tabname = '" + comboBox1.Text + "'";
            tool.fillcomboDB(this.pk, q);
        }

        private void pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tab = "select colname from syscat.columns where tabname = '" + comboBox1.Text + "' and colname != '" + pk.Text + "'";
            tool.fillcomboDB(comboBox4, tab);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addpk_Click(object sender, EventArgs e)
        {
            string tab = comboBox1.Text;
            string text = tool.scriptPk(pk.Text, tab);
            string query = "alter table " + tab + " drop primary key";
            tool.dropCmd(query, text);
            tool.sendCmd("alter table " + tab + " add primary key (" + comboBox4.Text + ")");
            tool.fillDataGrid(dgvpk, "select colname as PK, tabname as Tabla from syscat.keycoluse where tabschema = 'ADMINISTRATOR'");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qfk = "select ref.constname from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname  and key.tabname = '" + comboBox2.Text + "'";
            tool.fillcomboDB(this.fk, qfk);

        }

        private void fk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tab = comboBox2.Text;//tool.coltab(fk.Text.Remove(fk.Text.Length - 3));
            textBox2.Text = ts.scriptFK(fk.Text.Remove(fk.Text.Length - 3), tab);
        }

        private void addfk_Click(object sender, EventArgs e)
        {
            string tab = comboBox2.Text;
            string text = tool.scriptFK(fk.Text, tab);
            string query = "alter table " + tab + " drop foreign key " + fk.Text;
            tool.dropCmd(query, text);
            tool.sendCmd(textBox2.Text);
            tool.fillDataGrid(dataGridView1, "select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname ");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qi = "select name from sysibm.sysindexes where tbcreator = 'ADMINISTRATOR' and uniquerule = 'U' and tbname = '" + comboBox3.Text + "'";
            tool.fillcomboDB(this.idx, qi);
        }

        private void idx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tab = comboBox3.Text;//tool.coltab(idx.Text.Remove(idx.Text.Length - 4));
            textBox3.Text = ts.script_Ind(idx.Text, tab);

        }

        private void addidx_Click(object sender, EventArgs e)
        {
            string tab = comboBox3.Text;
            string text = tool.scriptInd(idx.Text, tab);
            string query = "drop index " + idx.Text;
            tool.dropCmd(query, text);
            tool.sendCmd(textBox3.Text);
            tool.fillDataGrid(dgvidx, "select name as Indice, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbcreator = 'ADMINISTRATOR' and uniquerule = 'U'");
        }

        private void dgvpk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
