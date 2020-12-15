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
    public partial class regProfessor : UserControl
    {

       public static string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        

        public regProfessor()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            if (notnull_validate() && email_validate() &&pass_validate())
            {
                OracleCommand c = new OracleCommand();
                OracleCommand c1 = new OracleCommand();
                c.Connection = conn;
                c1.Connection = conn;
                c.CommandText = "insert into users values (:email,:password,1)";
                c.Parameters.Add("email", email.Text.ToString());
                c.Parameters.Add("password", password.Text.ToString());
                c.CommandType = CommandType.Text;
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    c1.CommandText = "insert into staff values (staff_id.nextval,:first,:last,:email,:password)";
                    c1.Parameters.Add("first", first_name.Text.ToString());
                    c1.Parameters.Add("last", last_name.Text.ToString());
                    c1.Parameters.Add("email", email.Text.ToString());
                    c1.Parameters.Add("password", password.Text.ToString());
                    c1.CommandType = CommandType.Text;
                    int s = c1.ExecuteNonQuery();
                    if (s != -1)
                    {
                        MsgRegisterProfSuccess mrp = new MsgRegisterProfSuccess();
                        mrp.Show();

                    }
                    else
                    {
                        MsgRegisterProfFailure mrf = new MsgRegisterProfFailure();
                        mrf.Show();
                    }
                }
                else
                {
                    MsgRegisterProfFailure mrf = new MsgRegisterProfFailure();
                    mrf.Show();
                }
                email.Text = "";
                first_name.Text = "";
                last_name.Text = "";
                password.Text = "";
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
            if (!Regex.IsMatch(email.Text.ToString(),pattern))
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
                MessageBox.Show( "Password should contain at least one lower case letter.");
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

        private void regProfessor_Load(object sender, EventArgs e)
        {

        }
    }
    
}
