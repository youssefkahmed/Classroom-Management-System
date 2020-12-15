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
    public partial class profRequestHoliday : UserControl
    {
        String connStr = "Data source=orcl;User Id=scott;Password=tiger;";
        
        public profRequestHoliday()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try { 
            int profID = login.id;
            int holidayID = 0;
            String holidayType = bunifuDropdown1.selectedValue.ToString();
            String startDate = bunifuDatepicker1.Value.ToString("dd-MMM-yy");
            String endDate = bunifuDatepicker2.Value.ToString("dd-MMM-yy");

                OracleConnection conn = new OracleConnection(connStr);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "getHolidayID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("holidayType", holidayType);
                cmd.Parameters.Add("holidayID", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try { holidayID = Convert.ToInt32(cmd.Parameters["holidayID"].Value.ToString());}
                catch { holidayID = 0; }
                
                
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "INSERT INTO prof_holiday (h_id, start_date, end_date, prof_id) " +
                    "VALUES (:holidayID, :start_d, :end_d, :profID)";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("holidayID", holidayID);
                cmd2.Parameters.Add("start_d", startDate);
                cmd2.Parameters.Add("end_d", endDate);
                cmd2.Parameters.Add("profID", profID);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Holiday Requested Successfully");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Please make sure you filled all the required fields, and that the end date is after the start date." +
                    "Note: If You Have Previously Requested This Type Of Holiday Before, You Cannot Request It Again");
                //MessageBox.Show(ex.ToString());

            }
        }

        private void profRequestHoliday_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT h_type FROM Holidays";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bunifuDropdown1.AddItem(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

        }
    }
}
