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
    public partial class ListarIndices : Form
    {

        DB2 tool = new DB2();
        public ListarIndices()
        {

            InitializeComponent();
            string q = "select colname as PK, tabname as Tabla from syscat.keycoluse where tabschema = 'ADMINISTRATOR'";
            string qfk = "select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname ";
            string qi = "select name as Indice, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbcreator = 'ADMINISTRATOR' and uniquerule = 'U'";
            tool.fillDataGrid(dgvpk, q);
            tool.fillDataGrid(dgvfk, qfk);
            tool.fillDataGrid(dgvind, qi);
            InitializeComponent();
        }

        private void dgvind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvpk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
