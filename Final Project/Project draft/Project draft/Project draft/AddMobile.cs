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

namespace Project_draft
{
    public partial class AddMobile : Form
    {

        private DBConnection dbconnection = new DBConnection();

        byte[] img;

        string selectedBrand;
        int selectedBrandId;
        public AddMobile()
        {
            InitializeComponent();
        }

        private void addMobileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                //string brandName = brandTextBox.Text;
                string os = osTextBox.Text;
                string price = priceTextBox.Text;
                string description = descTextBox.Text;
                //img
                if (!(String.IsNullOrEmpty(name)))
                {
                    int result = dbconnection.insertMobile(name, os, description, int.Parse(price), selectedBrandId, img);

                    if (result > 0)
                    {
                        errorLabel.Text = "Mobile Details inserted successfully.";
                    }
                    else
                    {
                        errorLabel.Text = dbconnection.DBErrors;
                    }
                }
                else
                {
                    errorLabel.Text = "Enter all values";
                }

            }
            catch (Exception ex)
            {
                errorLabel.Text = $"{ex.Message} Error : {dbconnection.DBErrors} ";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
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
            }
        }

        private void AddMobile_Load(object sender, EventArgs e)
        {

            brandComboBox.ValueMember = "brandid";
            brandComboBox.DisplayMember = "brandname";
            brandComboBox.DataSource = dbconnection.selectBrandTable();
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBrandId = brandComboBox.SelectedIndex ;

        }
    }
}
