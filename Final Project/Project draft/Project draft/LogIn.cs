using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Configuration;

namespace MobileStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Shows a message if any of the fields are empty
            if(usernameTextbox.Text=="" || passwordTextBox.Text=="")
            {
                MessageBox.Show("Username or Password not entered, Please enter both and try again");
            }
            else
            {
                DBConnection dbconnection = new DBConnection();
                string sqlString = "select UserName,Password,LoginRole from LoginDetails where UserName='" + usernameTextbox.Text + "' and Password='" + passwordTextBox.Text + "'";
                DataTable mobileLoginTable = dbconnection.selectTable(sqlString);
                if (mobileLoginTable.Rows.Count == 1)
                {
                    if (mobileLoginTable.Rows[0][2].ToString() == "Admin")
                    {
                      
                        AdminAccount adminAccount = new AdminAccount();
                        adminAccount.Show();
                        this.Hide();
                    }
                    else if (mobileLoginTable.Rows[0][2].ToString()=="User")
                    {
                        UserAccountMainForm userAccount = new UserAccountMainForm();
                        userAccount.uName = usernameTextbox.Text;
                        userAccount.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please signup to register");
                    }
                }
                else
                {
                    MessageBox.Show("Entered UserId or Password is incorrect, Please type again.");
                }
            }
        }//end function loginButton_Click

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //for the full window
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.AcceptButton = loginButton;
        }//end function Login_Load
    }//end class
}//end namespace
