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
    public partial class profUpdateLecture : UserControl
    {
        public string crid1;
        public int cid;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public profUpdateLecture()
        {
            InitializeComponent();
        }

        private void profUpdateLecture_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select COURSE_NAME from COURSE where PROFESSOR_ID= :pid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("pid", login.id);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bunifuDropdown1.AddItem(dr[0].ToString());
            }
            dr.Close();
        }

        private void bunifuDropdown1_onItemSelected_1(object sender, EventArgs e)
        {

            string namee = bunifuDropdown1.selectedValue.ToString();

            char available = 'y';
            conn = new OracleConnection(ordb);
            conn.Open();
            bunifuDropdown2.Clear();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select CLASSROOM_ID,COURSE_ID,DESCRIPTION,C_DAY,C_TIME,TEACHING_YEAR from COURSE where COURSE_NAME= :cname";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("cname", namee);
            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                bunifuDropdown2.AddItem(dr2[0].ToString());
                crid1 = dr2[0].ToString();
                cid = int.Parse(dr2[1].ToString());
                label8.Text = dr2[1].ToString();
                bunifuMaterialTextbox1.Text = dr2[2].ToString();
                bunifuMaterialTextbox5.Text = dr2[3].ToString();
                bunifuMaterialTextbox2.Text = dr2[4].ToString();
                bunifuMaterialTextbox3.Text = dr2[5].ToString();
            }



            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ROOM_ID from CLASS_ROOM where STATUS = :ava ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ava", available.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bunifuDropdown2.AddItem(dr[0].ToString());
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
                cmd.CommandText = "UPDATECOURSE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cname", bunifuDropdown1.selectedValue.ToString());
                cmd.Parameters.Add("cinfo", bunifuMaterialTextbox1.Text.ToString());
                cmd.Parameters.Add("crid", int.Parse(bunifuDropdown2.selectedValue.ToString()));
                cmd.Parameters.Add("tye", bunifuMaterialTextbox3.Text.ToString());
                cmd.Parameters.Add("cday", bunifuMaterialTextbox5.Text.ToString());
                cmd.Parameters.Add("ctime", bunifuMaterialTextbox2.Text.ToString());
                cmd.ExecuteNonQuery();

                if (crid1 != bunifuDropdown2.selectedValue.ToString())
                {


                    cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "changeroom";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("crid1", int.Parse(crid1.ToString()));
                    cmd.Parameters.Add("crid2", int.Parse(bunifuDropdown2.selectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                    bunifuDropdown2.RemoveItem(bunifuDropdown2.selectedValue.ToString());
                }

                MessageBox.Show("Lecture Updated");

                bunifuMaterialTextbox1.Text = "Course Description";
                bunifuMaterialTextbox5.Text = "Course Day";
                bunifuMaterialTextbox2.Text = "Course Time";
                bunifuMaterialTextbox3.Text = "Course Year";

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


