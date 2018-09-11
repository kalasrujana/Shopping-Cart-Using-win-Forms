using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore
{
    public partial class SignUp : Form
    {
        //instantiating DBConnection class
        DBConnection dbconnection = new DBConnection();
        private DataTable loginTable;
        public SignUp()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT USERNAME,PASSWORD,LOGINROLE FROM LOGINDETAILS WHERE USERNAME = '" + usernameTextBox.Text + "'";
            loginTable = dbconnection.selectTable(sqlString);

            if (loginTable != null && loginTable.Rows.Count == 0) {

                if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || confirmPasswordTextBox.Text == "")
                {
                    // if any fields are missing
                    MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                    {
                        //password doesnot match confirm password
                        MessageBox.Show("Password doesnot match with the confirm password");
                    }
                    else
                    {
                        try
                        {
                            string sqlString2 = "insert into LoginDetails (Username, Password,LoginRole) values ('"+ usernameTextBox.Text + "','" + passwordTextBox.Text + "','User')";
                            int userInsert = dbconnection.insertUser(sqlString2);
                            if (userInsert == 1)
                            {
                                MessageBox.Show("An account has been created for you");
                                this.Close();
                                //Page loads to Login Form
                                Login login = new Login();
                                login.Show();
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " An error has occured.");
                        }
                    }

                }
            }else
            {
                //username already exists
                MessageBox.Show(" Username already exists. Please enter another one.");
            }
        }//end function submitButton_Click

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //Page loads to Login Form
            Login login = new Login();
            login.Show();

        }
    }//end class
}//end namespace
