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
    public partial class studSendComplaint : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public studSendComplaint()
        {
            InitializeComponent();
        }

        private void studSendComplaint_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Send_Complaint";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("Stud_id", login.id);
            c.Parameters.Add("Description", textBox1.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("Your Complaint is sent");
        }
    }
}
