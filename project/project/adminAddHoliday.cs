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
    public partial class adminAddHoliday : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public adminAddHoliday()
        {
            InitializeComponent();
        }

        private void adminAddHoliday_Load(object sender, EventArgs e)
        {
            //conn = new OracleConnection(ordb);
            //conn.Open();
            //OracleCommand c = new OracleCommand();
            //c.Connection = conn;
            //c.CommandText = "select  h_type from Holidays";
            //OracleDataReader dr = c.ExecuteReader();
            //while (dr.Read())
            //{
            //    holiday_type.AddItem(dr[0].ToString());
            //}
            //dr.Close();

        }

        private void holiday_type_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            int h_id = 0;
            string h_type = type.Text.ToString();
            string start = start_date.Value.ToString("dd-MMM-yy");
            string end = end_date.Value.ToString("dd-MMM-yy");
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert into Holidays values (holiday_id.nextval,:type)";
            c.Parameters.Add("type", h_type);
            int x = c.ExecuteNonQuery();
            if (x != -1)
            {
                OracleCommand c1 = new OracleCommand();
                c1.Connection = conn;
                c1.CommandText = "select h_id from Holidays where h_type = :type";
                c1.Parameters.Add("type", h_type);
                OracleDataReader dr = c1.ExecuteReader();
                if (dr.Read())
                {
                    // MessageBox.Show(dr[0].ToString());

                    h_id = int.Parse(dr[0].ToString());
                }
                dr.Close();
                OracleCommand c2 = new OracleCommand();
                c2.Connection = conn;
                c2.CommandText = "select distinct Staff.member_id from staff , users where users.utype=1";
                OracleDataReader dr1 = c2.ExecuteReader();
                OracleCommand c3 = new OracleCommand();
                c3.Connection = conn;
                int res, s;
                while (dr1.Read())
                {
                    c3 = new OracleCommand();
                    c3.Connection = conn;
                    //Hwa El Loop De Kant Mfrod Ad e ? 2 بس ASl Hwa 3ada f Awl Iteration Drb fel Tania Y3ni el Code Tmm
                   // Tmm Kda  شكرا جدا جدا جدا La Mfish Haga Minf34 N3ml Aktr mn Query 3ala Nfs el Command f Kan Lazm N3ml New تما
                    s = int.Parse(dr1[0].ToString());
                    string st = "accepted";
                    c3.CommandText = "insert into prof_holiday values (:h_id,:status,:start_d,:end_d, :prof)";
                    c3.Parameters.Add("h_id", h_id);
                    c3.Parameters.Add("status", st);
                    c3.Parameters.Add("start_d", Convert.ToDateTime(start));
                    c3.Parameters.Add("end_d", Convert.ToDateTime(end));
                    c3.Parameters.Add("prof", s);
                    c3.CommandType = CommandType.Text;
                    res = c3.ExecuteNonQuery();
                   
                       
                    

                }
                MessageBox.Show("Holiday Added to all professors Successfully");
                dr1.Close();

            }




           


        }
    }

}
