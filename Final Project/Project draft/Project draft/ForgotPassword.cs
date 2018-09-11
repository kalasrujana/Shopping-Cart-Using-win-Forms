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
    public partial class ForgotPassword : Form
    {
        //instantiating DBConnection class
        DBConnection dbconnection = new DBConnection();
        //declaring variable
        DataTable loginTable;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT USERNAME,PASSWORD,LOGINROLE FROM LOGINDETAILS WHERE USERNAME = '" + userNameTextBox.Text + "'";
            loginTable = dbconnection.selectTable(sqlString);

            if (userNameTextBox.Text == "" || passwordTextBox.Text == "" || confirmPasswordTextBox.Text == "")
            {
                // if any fields are missing
                MessageBox.Show("Please enter all the fields");
            }
            else { 
           
                if (loginTable == null || loginTable.Rows.Count == 0)
                {
                    //username doesnot exists
                    MessageBox.Show(" Username does not exist.");
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
                            string sqlString2 = "UPDATE LoginDetails set PASSWORD = '" + passwordTextBox.Text + "' WHERE USERNAME = '" +userNameTextBox.Text + "'" ;
                            int result = dbconnection.updateTable(sqlString2);
                            if (result > 0)
                            {
                                MessageBox.Show("Password Updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show(dbconnection.DBErrors);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " An error has occured.");
                        }
                    }

                }
            }
        }//end function submitButton_Click

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//end class
}//end namespace
