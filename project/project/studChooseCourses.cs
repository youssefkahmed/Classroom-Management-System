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
    public partial class studChooseCourses : UserControl
    {
        public int courseid;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public studChooseCourses()
        {
            InitializeComponent();
        }

        private void studChooseCourses_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select COURSE_NAME , COURSE_ID from COURSE where TEACHING_YEAR = :year";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("year", login.year);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bunifuDropdown1.AddItem(dr[0].ToString());
                
            }
            dr.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into ENROLLED_COURSE values(:sid,:cid)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("sid", login.id);
                cmd.Parameters.Add("cid", courseid);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("You have successfully Enrolled into " + bunifuDropdown1.selectedValue);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You have Already Enrolled into " + bunifuDropdown1.selectedValue);
            }

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select COURSE_ID,DESCRIPTION from COURSE where COURSE_NAME= :coursenamee";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("coursenamee", bunifuDropdown1.selectedValue.ToString());
            OracleDataReader dr = c.ExecuteReader();
            dr = c.ExecuteReader();
            if (dr.Read())
            {
                courseid = int.Parse(dr[0].ToString());
                label1.Text = dr[1].ToString();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
