using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace project
{
    public partial class adminSeeAll : UserControl
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public adminSeeAll()
        {
            InitializeComponent();
        }

        private void adminSeeAll_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string constr= "Data source=orcl;User Id=scott; Password=tiger;";
            string cmdstr="";
           
            if (radioButton1.Checked)
                cmdstr = "select * from prof_holiday";
            else if (radioButton2.Checked)
                cmdstr = "select * from complaints";

            if (cmdstr != "")
            {
                adapter = new OracleDataAdapter(cmdstr, constr);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            else
            {
                MessageBox.Show("Please Check One Of The Radio Buttons");
            }
             
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Changes Saved Successfully");
        }
    }
}
