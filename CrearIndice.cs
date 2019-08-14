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
    public partial class CrearIndice : Form
    {

        DB2 tool = new DB2();

        public CrearIndice()
        {
            InitializeComponent();
            string q = "select name as Nombre from sysibm.systables where creator  = 'ADMINISTRATOR'"; //"select constname as Nombre, tabname as Tabla, refkeyname as Col_Ref, reftabname as Tabla_Ref from syscat.references";
            tool.fillcomboDB(tabpk, q);
            tool.fillcomboDB(tabfk, q);
            tool.fillcomboDB(tabref, q);
            tool.fillcomboDB(tabidx, q);

        }

        private void tabpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            colpk.Text = "";
            colpk.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabpk.Text + "'";
            string dgvq = "select * from " + tabpk.Text;
            tool.fillcomboDB(colpk, q);
            tool.fillDataGrid(dgvpk, dgvq);

        }

        private void dgvpk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void colpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = tool.isInd(colpk.Text, tabpk.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addpk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tabpk.Text) || string.IsNullOrWhiteSpace(colpk.Text))
            {
                MessageBox.Show("Debe seleccionar una tabla y columna");
            }
            if (tool.isInd(colpk.Text, tabpk.Text) != "No")
            {
                MessageBox.Show("Esta columna ya es una llave primaria");
            }
            else
            {
                string dgq = "select colname as Nombre, tabname as Tabla from syscat.keycoluse where tabschema  = 'ADMINISTRATOR'";
                string q = "alter table " + tabpk.Text + " add primary key (" + colpk.Text + ")";
                tool.sendCmd(q);
                MessageBox.Show("Llave primaria creada");
                tabpk.Text = "";
                colpk.Text = "";
                colpk.Items.Clear();
                tool.fillDataGrid(dgvpk, dgq);
            }

        }

        private void tabfk_SelectedIndexChanged(object sender, EventArgs e)
        {
            colfk.Text = "";
            colfk.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabfk.Text + "'";
            string dgvq = "select * from " + tabfk.Text;
            tool.fillcomboDB(colfk, q);
            tool.fillDataGrid(dataGridView1, dgvq);
        }

        private void colfk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = tool.isfk(colfk.Text, tabfk.Text).ToString();
        }

        private void tabref_SelectedIndexChanged(object sender, EventArgs e)
        {
            colref.Text = "";
            colref.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabref.Text + "'";
            string dgvq = "select * from " + tabref.Text;
            tool.fillcomboDB(colref, q);
        }

        private void colref_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addfk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tabfk.Text) || string.IsNullOrWhiteSpace(colfk.Text) || string.IsNullOrWhiteSpace(tabref.Text) || string.IsNullOrWhiteSpace(colref.Text))
            {
                MessageBox.Show("Debe seleccionar una tabla y columna");
            }
            if (tool.isfk(colfk.Text, tabfk.Text))
            {
                MessageBox.Show("Esta columna ya es una llave foranea");
            }
            else
            {
                string dgq = "select constname as Nombre, tabname as Tabla, refkeyname as Col_Ref, reftabname as Tabla_Ref from syscat.references";
                string q = "alter table " + tabfk.Text + " add constraint " + colfk.Text + "_fk foreign key (" + colfk.Text + ") references " + tabref.Text + "(" + colref.Text + ")";
                tool.sendCmd(q);
                //MessageBox.Show(q);
                MessageBox.Show("Llave foranea creada");
                tabpk.Text = "";
                colpk.Text = "";
                colpk.Items.Clear();
                tool.fillDataGrid(dataGridView1, dgq);
            }
        }

        private void tabidx_SelectedIndexChanged(object sender, EventArgs e)
        {
            colidx.Text = "";
            colidx.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabidx.Text + "'";
            string dgvq = "select * from " + tabidx.Text;
            tool.fillcomboDB(colidx, q);
            tool.fillDataGrid(dgvidx, dgvq);
        }

        private void colidx_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = tool.isInd(colidx.Text + "_IDX", tabidx.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addidx_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tabidx.Text) || string.IsNullOrWhiteSpace(colidx.Text))
            {
                MessageBox.Show("Debe seleccionar una tabla y columna");
            }
            if (tool.isfk(colfk.Text, tabfk.Text))
            {
                MessageBox.Show("Esta columna ya es un indice");
            }
            else
            {
                string dgq = "select name as Nombre, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbcreator = 'ADMINISTRATOR' and uniquerule = 'U'";
                string q = "create unique index " + colidx.Text + "_idx on " + tabidx.Text + "(" + colidx.Text + ")";
                tool.sendCmd(q);
                //MessageBox.Show(q);
                MessageBox.Show("Indice creado");
                tabidx.Text = "";
                colidx.Text = "";
                colidx.Items.Clear();
                tool.fillDataGrid(dgvidx, dgq);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
