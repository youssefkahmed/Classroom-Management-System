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
using System.Text.RegularExpressions;
namespace project
{
    
    public partial class regStudent : UserControl
    {
        public static string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn=new OracleConnection(ordb);
        public regStudent()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (notnull_validate() && email_validate() && pass_validate())
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into USERS values (:UEMAIL,:UPASSWORD,2)";
                cmd.Parameters.Add("UEMAIL", email.Text.ToString());
                cmd.Parameters.Add("UPASSWORD", password.Text.ToString());
                int x = cmd.ExecuteNonQuery();
                if (x != -1)
                {
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "insert into STUDENT values (STUDENT_ID.nextval,:first_name,:last_name,:stud_year,:stud_email,:stud_password)";
                    cmd2.Parameters.Add("first_name", first_name.Text);
                    cmd2.Parameters.Add("last_name", last_name.Text);
                    cmd2.Parameters.Add("stud_year", year.SelectedItem);
                    cmd2.Parameters.Add("stud_email", email.Text);
                    cmd2.Parameters.Add("stud_password", password.Text);

                    int r = cmd2.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("New Student is added");
                    }
                }

                conn.Close();
            }
        }
        public bool notnull_validate()
        {

            if (String.IsNullOrEmpty(first_name.Text.ToString()))
            {
                MessageBox.Show("Enter a First Name Please!");
                return false;
            }
            if (String.IsNullOrEmpty(last_name.Text.ToString()))
            {
                MessageBox.Show("Enter a Last Name Please!");
                return false;
            }
            if (String.IsNullOrEmpty(email.Text.ToString()))
            {
                MessageBox.Show("Enter an Email Please!");
                return false;
            }
            if (String.IsNullOrEmpty(password.Text.ToString()))
            {
                MessageBox.Show("Enter a Password Please!");
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
    }
}
