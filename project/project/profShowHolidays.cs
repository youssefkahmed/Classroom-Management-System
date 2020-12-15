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
    public partial class profShowHolidays : UserControl
    {
        String connStr = "Data source=orcl;User Id=scott;Password=tiger;";

        public profShowHolidays()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void profShowHolidays_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int h_id;
            profShowHoliday pSH;

            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getHolidays";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("professorID", login.id);
            cmd.Parameters.Add("holidayID", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                h_id = int.Parse(dr[0].ToString());
                pSH = new profShowHoliday();
                pSH.setHolidayID(h_id);
                flowLayoutPanel1.Controls.Add(pSH);

            }
            dr.Close();

            conn.Close();


            /* profShowHoliday psh = new profShowHoliday();
             flowLayoutPanel1.Controls.Add(psh);*/
        }
    }
}
