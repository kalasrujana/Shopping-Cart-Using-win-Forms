using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace MobileStore
{
    class MobileClass
    {
        //declaring sqlconnection
        private SqlConnection mobileConnection;
        //intializing a connection string
        string mobileConnectionString = ConfigurationManager.ConnectionStrings["MobileStore.Properties.Settings.MobileAppConnection"].ConnectionString;

        String selectBrand;
        //this method is used to get data which is especially for select statement
        public DataSet getDataSet(string sqlString)
        {
            DataSet MobileDataSet = new DataSet();
            try
            {
                mobileConnection = new SqlConnection(mobileConnectionString);
                SqlDataAdapter MobileDataAdapter = new SqlDataAdapter(sqlString, mobileConnection);
                mobileConnection.Open();
                MobileDataAdapter.Fill(MobileDataSet);
                return MobileDataSet;
            }

            finally
            {
                mobileConnection.Close();
            }
        }

        // this  is a getTable method used to get a specific table for accessing rows and columns 
        public DataTable getTable(string sqlString)
        {
            DataTable mobileDt = new DataTable();
            try
            {
                mobileConnection = new SqlConnection(mobileConnectionString);
                SqlDataAdapter mobileDa = new SqlDataAdapter(sqlString, mobileConnection);
                mobileConnection.Open();
                mobileDa.Fill(mobileDt);
                return mobileDt;
            }
            catch (Exception ex)
            {

                DBConnection dbConnection = new DBConnection();
                dbConnection.DBErrors = ex.Message;
                return mobileDt;
            }
            finally
            {
                mobileConnection.Close();
            }
        }//closegetTable

        //to load the table product details into gridview on load
        public void loadGridviewDetails(DataGridView datagridview)
        {
            string sqlquery = "select ProductID,BrandID,ProductName,ProductImage,OS, Description, Price from ProductDetails order by ProductID";
            DataTable mobileDataTable = getTable(sqlquery);
            datagridview.Rows.Clear();
            foreach (DataRow item in mobileDataTable.Rows)
            {
                //row will be added and index is stored
                int numberofRows = datagridview.Rows.Add();
                //assigning Brand Names
                if (item["BrandID"].ToString() == "1") { selectBrand = "Apple"; }
                if (item["BrandID"].ToString() == "2") { selectBrand = "Motorola"; }
                if (item["BrandID"].ToString() == "3") { selectBrand = "Samsung"; }
                //to put the checkbox as not ticked
                datagridview.Rows[numberofRows].Cells[0].Value = false;
                //passing the db columns to gridview on load
                datagridview.Rows[numberofRows].Cells[1].Value = item["ProductName"].ToString();
                datagridview.Rows[numberofRows].Cells[2].Value = selectBrand;
                //to pass binary data from database to show on gridview image
                byte[] imgBytes = (byte[])item["ProductImage"];
                datagridview.Rows[numberofRows].Cells[3].Value = imgBytes;
                datagridview.Rows[numberofRows].Cells[4].Value = item["OS"].ToString();
                datagridview.Rows[numberofRows].Cells[5].Value = item["Description"].ToString();
                //datagridview.Rows[numberofRows].Cells[6].Value = item["Quantity"].ToString(); bhramara
                datagridview.Rows[numberofRows].Cells[6].Value = "$" + item["Price"].ToString();
                //put selection mode of gridview to row select

            }
        }

        //to load gridview on search button
        public void searchAndloadGridviewDetails(DataGridView datagridview, string sqlquery)
        {
            DataTable mobileDataTable = getTable(sqlquery);
            datagridview.Rows.Clear();
            foreach (DataRow item in mobileDataTable.Rows)
            {
                //row will be added and index is stored
                int numberofRows = datagridview.Rows.Add();
                if (item["BrandID"].ToString() == "1") { selectBrand = "Apple"; }
                if (item["BrandID"].ToString() == "2") { selectBrand = "Motorola"; }
                if (item["BrandID"].ToString() == "3") { selectBrand = "Samsung"; }
                //to put the checkbox as not ticked
                datagridview.Rows[numberofRows].Cells[0].Value = false;
                //passing the db columns to gridview on load
                datagridview.Rows[numberofRows].Cells[1].Value = item["ProductName"].ToString();
                datagridview.Rows[numberofRows].Cells[2].Value = selectBrand;
                //to pass binary data from database to show on gridview image
                byte[] imgBytes = (byte[])item["ProductImage"];
                datagridview.Rows[numberofRows].Cells[3].Value = imgBytes;
                datagridview.Rows[numberofRows].Cells[4].Value = item["OS"].ToString();
                datagridview.Rows[numberofRows].Cells[5].Value = item["Description"].ToString();
               // datagridview.Rows[numberofRows].Cells[6].Value = item["Quantity"].ToString();
                datagridview.Rows[numberofRows].Cells[6].Value = item["Price"].ToString();
                //put selection mode of gridview to row select
            }
        }

        //to insert cart details  to ordereded products table in database
        public int insertMobile(string brandName,string productName, int price, int quantity, string username)
        {
            DBConnection dbConnection = new DBConnection();
            string sqlString = "INSERT INTO OrderedProducts (BrandName,ProductName,Price,Quantity,UserName) values(@brandName,@productName,@price,@quantity,@username);";
            SqlCommand insertCommand = new SqlCommand(sqlString, dbConnection.getConnection());

            int queryResult = 0;

            try
            {
                insertCommand.Parameters.AddWithValue("@brandName", brandName);
                insertCommand.Parameters.AddWithValue("@productName", productName);
                insertCommand.Parameters.AddWithValue("@price", price);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);
                insertCommand.Parameters.AddWithValue("@username", username);
                dbConnection.openConnection();
                queryResult = insertCommand.ExecuteNonQuery();
                return queryResult;
            }
            catch (Exception ex)
            {
                dbConnection.DBErrors = ex.Message;
                return queryResult;
            }
            finally
            {
                dbConnection.closeConnection();
                insertCommand.Dispose();
            }
        }//end of insertMobile method

    }//end class
}//end namespace