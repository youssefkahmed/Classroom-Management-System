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
    public partial class adminShowRequests : UserControl
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public adminShowRequests()
        {
            InitializeComponent();
        }

        private void adminShowRequests_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select h_id,start_date,end_date,prof_id from prof_holiday where status = :status";
            c.Parameters.Add("status", "pending");
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                adminShowRequest asr = new adminShowRequest();
                
                asr.holi_type(int.Parse(dr[0].ToString()));
                asr.start_d(dr[1].ToString());
                asr.end_d(dr[2].ToString());
                asr.prof_ID(int.Parse(dr[3].ToString()));
                flowLayoutPanel1.Controls.Add(asr);

            }
            conn.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
