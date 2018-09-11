using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore
{
    public partial class AddMobile : Form
    {

        //instantiating the variables 
        byte[] img;
        int selectedBrandId;
        
        //instanting the DBConnection class
        private DBConnection dbconnection = new DBConnection();
        public AddMobile()
        {
            InitializeComponent();
        }

        private void addMobileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string os = osTextBox.Text;
                string price = priceTextBox.Text;
                string description = descTextBox.Text;
     
                if (!(String.IsNullOrEmpty(name)) && !(String.IsNullOrEmpty(os))
                    && !(String.IsNullOrEmpty(price)) && !(String.IsNullOrEmpty(description)))
                {
                    // if all the values are entered
                    int result = dbconnection.insertMobile(name, os, description, int.Parse(price), selectedBrandId, img);

                    if (result > 0)
                    {
                         MessageBox.Show("Mobile Details inserted successfully.");
                        infoLabel.Text = "";
                        nameTextBox.Text = "";
                        osTextBox.Text = "";
                        priceTextBox.Text = "";
                        descTextBox.Text = "";
                        brandComboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Please enter all the values.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all values");
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Price should be a number.");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show( $"{ex.Message} Error : {dbconnection.DBErrors} ");
            }
        }//end of addMobileButton_Click

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"D:\";
            openFile.Filter = "[JPEG, JPG]|*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                img = new byte[stream.Length];
                stream.Read(img, 0, Convert.ToInt32(stream.Length));

                stream.Dispose();
                infoLabel.Text = "Image Uploaded";
            }
        }//end function uploadImageButton_Click

        private void AddMobile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            brandComboBox.ValueMember = "brandid";
            brandComboBox.DisplayMember = "brandname";
            string sqlString = "SELECT BRANDID, BRANDNAME from BRANDDETAILS";
            brandComboBox.DataSource = dbconnection.selectTable(sqlString);
            brandComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }// end function AddMobile_Load

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBrandId = brandComboBox.SelectedIndex ;

        }
    }//end class
}//end namespace
