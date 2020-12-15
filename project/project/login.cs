using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Text.RegularExpressions;
namespace project
{
    public partial class login : Form

    {
        public static int id;
        public static string name;
        public static int year;
        public static int type;
        public static string mail;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        

        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            if (notnull_validate() && email_validate() && pass_validate())
            {
                
                conn = new OracleConnection(ordb);
                conn.Open();
                mail = email.Text.ToString();
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "select UTYPE from USERS where UEMAIL= :mail and UPASSWORD =:pass";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("mail", email.Text.ToString());
                c.Parameters.Add("pass", password.Text.ToString());
                OracleDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                    type = int.Parse(dr[0].ToString());

                    if (type == 0 || type == 1)
                    {
                        c = new OracleCommand();
                        c.Connection = conn;
                        c.CommandText = "select MEMBER_ID, FIRST_NAME,last_name from STAFF where MEMBER_EMAIL= :mail and MEMBER_PASSWORD =:pass";
                        c.CommandType = CommandType.Text;
                        c.Parameters.Add("mail", email.Text.ToString());
                        c.Parameters.Add("pass", password.Text.ToString());
                        dr = c.ExecuteReader();
                        if (dr.Read())
                        {
                            id = int.Parse(dr[0].ToString());
                            name = dr[1].ToString() + " " + dr[2].ToString();
                        }

                    }

                    else if (type == 2)
                    {
                        c = new OracleCommand();
                        c.Connection = conn;
                        c.CommandText = "select STUD_ID, FIRST_NAME,last_name,STUD_YEAR from STUDENT where STUD_EMAIL= :mail and STUD_PASSWORD =:pass";
                        c.CommandType = CommandType.Text;
                        c.Parameters.Add("mail", email.Text.ToString());
                        c.Parameters.Add("pass", password.Text.ToString());
                        dr = c.ExecuteReader();
                        if (dr.Read())
                        {
                            id = int.Parse(dr[0].ToString());
                            name = dr[1].ToString() + " " + dr[2].ToString();
                            year = int.Parse(dr[3].ToString());
                        }

                    }
                    // 
                    this.Hide();
                    MsgLoginSuccess m = new MsgLoginSuccess();
                    m.ShowDialog();

                    this.Close();


                }
                else
                {

                    MsgLoginFailed mf = new MsgLoginFailed();
                    mf.ShowDialog();
                    this.Show();
                }

                dr.Close();

            }

        }



        private void login_Load(object sender, EventArgs e)
        {
            

        }
        public bool notnull_validate()
        {

            if (String.IsNullOrEmpty(email.Text.ToString()))
            {
                MessageBox.Show("Enter Your Email Please!");
                return false;
            }
            if (String.IsNullOrEmpty(password.Text.ToString()))
            {
                MessageBox.Show("Enter Your Password Please!");
                return false;
            }
           else
            {
                return true;
            }
        }
        public bool pass_validate()
        {
            var input = password.Text.ToString();




            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one lower case letter.");
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one upper case letter.");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                MessageBox.Show("Password should not be less than 8 or greater than 15 characters.");
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one numeric value.");
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one special case character.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool email_validate()
        {

            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(email.Text.ToString(), pattern))
            {
                MessageBox.Show("Enter a Valid Email Address");
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}
