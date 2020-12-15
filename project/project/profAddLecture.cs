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

    public partial class profAddLecture : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public profAddLecture()
        {
            InitializeComponent();
        }

        private void profAddLecture_Load(object sender, EventArgs e)
        {
            char available = 'y';
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ROOM_ID from CLASS_ROOM where STATUS = :ava";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ava", available.ToString());
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
                cmd.CommandText = "addcoourse";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cname", bunifuMaterialTextbox4.Text.ToString());
                cmd.Parameters.Add("cinfo", bunifuMaterialTextbox1.Text.ToString());
                cmd.Parameters.Add("pid", login.id);
                cmd.Parameters.Add("crid", int.Parse(bunifuDropdown1.selectedValue.ToString()));
                cmd.Parameters.Add("tyear", int.Parse(bunifuMaterialTextbox3.Text.ToString()));
                cmd.Parameters.Add("cday", bunifuMaterialTextbox5.Text.ToString());
                cmd.Parameters.Add("ctime", bunifuMaterialTextbox2.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Added Succesfully");

                bunifuDropdown1.ResetText();

                bunifuDropdown1.RemoveItem(bunifuDropdown1.selectedValue.ToString());
                bunifuMaterialTextbox4.Text = "Course Name";
                bunifuMaterialTextbox3.Text = "Course Year";
                bunifuMaterialTextbox1.Text = "Course Description";
                bunifuMaterialTextbox5.Text = "Course Day";
                bunifuMaterialTextbox2.Text = "Course Time";

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
