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
    public partial class adminShowRequest : UserControl
    {
        OracleConnection conn =new OracleConnection(regProfessor.ordb);
        public adminShowRequest()
        {
            InitializeComponent();
        }

        private void adminShowRequest_Load(object sender, EventArgs e)
        {

           

        }
        int h_id;
        public void prof_ID(int id)
        {

            prof_id.Text = id.ToString();
        }
        public void holi_type(int id)
        {
            h_id = id;
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select holidays.h_type from prof_holiday, holidays  where prof_holiday.h_id = :h_id";
            c.Parameters.Add("h_id", id);
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                holiday_type.Text = dr[0].ToString();
            }
            }
        public void start_d(string start)
        {
            start_date.Text = start;
        }
        public void end_d(string end)
        {
            end_date.Text = end;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update prof_holiday set status = 'accepted' where h_id= :H_id";
            c.Parameters.Add("H_id", h_id);
            c.CommandType = CommandType.Text;
            int x = c.ExecuteNonQuery();
            if (x != -1)
            {
                MessageBox.Show("Holiday Accepted");
            }
            accept.Enabled = false;
            decline.Enabled = false;
            accept.IdleFillColor = Color.FromArgb(35,32,35);
            accept.IdleForecolor = Color.FromArgb(35, 32, 35);
            accept.IdleLineColor= Color.FromArgb(35, 32, 35);
            decline.IdleFillColor = Color.FromArgb(35, 32, 35);
            decline.IdleForecolor = Color.FromArgb(35, 32, 35);
            decline.IdleLineColor = Color.FromArgb(35, 32, 35);
        }

        private void decline_Click(object sender, EventArgs e)
        {
            
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update prof_holiday set status = 'rejected' where h_id= :H_id";
            c.Parameters.Add("H_id", h_id);
            c.CommandType = CommandType.Text;
            int x = c.ExecuteNonQuery();
            if (x != -1)
            {
                MessageBox.Show("Holiday Rejected");
            }
            accept.Enabled = false;
            decline.Enabled = false;
            accept.IdleFillColor = Color.FromArgb(35, 32, 35);
            accept.IdleForecolor = Color.FromArgb(35, 32, 35);
            accept.IdleLineColor = Color.FromArgb(35, 32, 35);
            decline.IdleFillColor = Color.FromArgb(35, 32, 35);
            decline.IdleForecolor = Color.FromArgb(35, 32, 35);
            decline.IdleLineColor = Color.FromArgb(35, 32, 35);
        }
    }
}
