﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;

namespace DB2PJ1
{
    public partial class CrearTablas : Form
    {

        DB2 tool = new DB2();

        public CrearTablas()
        {
            InitializeComponent();
            fillCombo(col1Tipo);
            fillCombo(col2Tipo);
            fillCombo(col3Tipo);
            fillCombo(col4Tipo);
            fillCombo(col5Tipo);

        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tabName.Text) && (string.IsNullOrWhiteSpace(col1Name.Text) || string.IsNullOrWhiteSpace(col2Name.Text) || string.IsNullOrWhiteSpace(col3Name.Text) || string.IsNullOrWhiteSpace(col4Name.Text) || string.IsNullOrWhiteSpace(col5Name.Text)))
            {
                System.Windows.Forms.MessageBox.Show("Ingresar nombre de tabla y al menos una columna");
            }
            else
            {
                string query = "create table " + tabName.Text + " (" + queryBuilder(col1Name, col1Tipo, col1Pk) + queryBuilder(col2Name, col2Tipo, col2Pk) + queryBuilder(col3Name, col3Tipo, col3Pk) + queryBuilder(col4Name, col4Tipo, col4Pk) + queryBuilder(col5Name, col5Tipo, col5Pk) + ")";
                string redTab = "select name from sysibm.systables where creator  = 'ADMINISTRATOR'";
                Console.WriteLine(query);
                tool.sendCmd(query);
                tool.fillDataGrid(this.dataGridView1, redTab);
            }

        }

        


        private string checkEmpty(TextBox t)
        {
            string value = "";
            if (!string.IsNullOrWhiteSpace(t.Text))
            {
                value = t.Text + ",";
            }
            return value;
        }

        private string queryBuilder(TextBox t, ComboBox c, CheckBox cb)
        {
            string value = "";
            if (!string.IsNullOrWhiteSpace(t.Text) && !string.IsNullOrWhiteSpace(c.Text) && cb.Checked == true)
            {
                if (checkIfOne())
                {
                    value = t.Text + " " + c.Text + " not null primary key";
                }
                else
                {
                    value = t.Text + " " + c.Text + " not null primary key";
                }
            }
            else if (!string.IsNullOrWhiteSpace(t.Text) && !string.IsNullOrWhiteSpace(c.Text))
            {
                value = "," + t.Text + " " + c.Text;
            }
            else if (!string.IsNullOrWhiteSpace(t.Text))
            {
                value = t.Text + ",";
            }
            return value;
        }

        private bool checkIfOne()
        {
            if (!string.IsNullOrEmpty(col1Name.Text) && (string.IsNullOrEmpty(col2Name.Text) && string.IsNullOrEmpty(col4Name.Text) && string.IsNullOrEmpty(col4Name.Text) && string.IsNullOrEmpty(col5Name.Text)))
            {
                return true;
            }
            else if (!string.IsNullOrEmpty(col2Name.Text) && (string.IsNullOrEmpty(col1Name.Text) && string.IsNullOrEmpty(col3Name.Text) && string.IsNullOrEmpty(col4Name.Text) && string.IsNullOrEmpty(col5Name.Text)))
            {
                return true;
            }
            else if (!string.IsNullOrEmpty(col3Name.Text) && (string.IsNullOrEmpty(col2Name.Text) && string.IsNullOrEmpty(col1Name.Text) && string.IsNullOrEmpty(col4Name.Text) && string.IsNullOrEmpty(col5Name.Text)))
            {
                return true;
            }
            else if (!string.IsNullOrEmpty(col4Name.Text) && (string.IsNullOrEmpty(col2Name.Text) && string.IsNullOrEmpty(col4Name.Text) && string.IsNullOrEmpty(col1Name.Text) && string.IsNullOrEmpty(col5Name.Text)))
            {
                return true;
            }
            else if (!string.IsNullOrEmpty(col5Name.Text) && (string.IsNullOrEmpty(col2Name.Text) && string.IsNullOrEmpty(col3Name.Text) && string.IsNullOrEmpty(col4Name.Text) && string.IsNullOrEmpty(col1Name.Text)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }





        private void fillCombo(ComboBox c)
        {
            c.Items.Add("VARCHAR(70)");
            c.Items.Add("CHARACTER(1)");
            c.Items.Add("INTEGER");
            c.Items.Add("DOUBLE");
            c.Items.Add("NUMERIC(10,2)");
        }

        private void col1Pk_CheckedChanged_1(object sender, EventArgs e)
        {
            if (col2Pk.Checked == true || col3Pk.Checked == true || col4Pk.Checked == true || col5Pk.Checked == true)
            {
                col1Pk.Checked = false;
            }

        }

        private void col2Pk_CheckedChanged(object sender, EventArgs e)
        {
            if (col1Pk.Checked == true || col3Pk.Checked == true || col4Pk.Checked == true || col5Pk.Checked == true)
            {
                col2Pk.Checked = false;
            }
        }

        private void col3Pk_CheckedChanged(object sender, EventArgs e)
        {
            if (col2Pk.Checked == true || col1Pk.Checked == true || col4Pk.Checked == true || col5Pk.Checked == true)
            {
                col3Pk.Checked = false;
            }
        }

        private void col4Pk_CheckedChanged(object sender, EventArgs e)
        {
            if (col2Pk.Checked == true || col3Pk.Checked == true || col1Pk.Checked == true || col5Pk.Checked == true)
            {
                col4Pk.Checked = false;
            }
        }

        private void col5Pk_CheckedChanged(object sender, EventArgs e)
        {
            if (col2Pk.Checked == true || col3Pk.Checked == true || col4Pk.Checked == true || col1Pk.Checked == true)
            {
                col5Pk.Checked = false;
            }
        }

        private void tabName_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
