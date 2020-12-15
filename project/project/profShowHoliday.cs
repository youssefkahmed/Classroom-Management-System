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
    public partial class profShowHoliday : UserControl
    {
        String connStr = "Data source=orcl;User Id=scott;Password=tiger;";
        int holidayID = 0;
        public void setHolidayID(int ID) {
            holidayID = ID;
        }


        public profShowHoliday()
        {
            InitializeComponent();
        }

        private void profShowHoliday_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT status, start_date, end_date FROM prof_holiday WHERE h_id = :holidayID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("holidayID", holidayID);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = dr[0].ToString();   
                label7.Text = dr[1].ToString();   
                label8.Text = dr[2].ToString();  
            }
            dr.Close();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT h_type FROM holidays WHERE h_id = :holidayID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("holidayID", holidayID);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label5.Text = dr[0].ToString();
            }
            dr.Close();

            conn.Close();
        }
    }
}
