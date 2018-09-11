using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Project_draft
{
    class DBConnection
    {

        //defining connectionString and SqlConnection
        private SqlConnection mobileConnection;
        string connectionString = ConfigurationManager.ConnectionStrings["Project_draft.Properties.Settings.MobileAppConnection"].ConnectionString;

        private SqlDataAdapter mobileAdapter;
        public string DBErrors { get; set; }

        //method to get connection
        public SqlConnection getConnection()
        {
            mobileConnection = new SqlConnection(connectionString);
            return mobileConnection;

        }

        //method to open connection
        private void openConnection()
        {

            if (mobileConnection.State == ConnectionState.Closed)
            {

                mobileConnection.Open();
            }


        }

        //method to close connection
        private void closeConnection()
        {
            mobileConnection.Close();

        }

        //method to insert data into mobile table
        public int insertMobile(string name, string os, string description, int price,int brandid, byte[] image)
        {

            string sqlString = "INSERT INTO MOBILEDETAILS (NAME, BRANDID, OS, DESCRIPTION, PRICE,IMAGE) values(@name,@brandid, @os, @description, @price,@image);";
            SqlCommand insertCommand = new SqlCommand(sqlString, this.getConnection());

            int queryResult = 0;

            try
            {
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@brandid", brandid);
                insertCommand.Parameters.AddWithValue("@os", os);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.Parameters.AddWithValue("@price", price);
                //insertCommand.Parameters.AddWithValue("@image", image);
                insertCommand.Parameters.AddWithValue("@image", SqlDbType.VarBinary).Value = image;

                this.openConnection();
                queryResult = insertCommand.ExecuteNonQuery();
                return queryResult;
            }
            catch (Exception ex)
            {

                DBErrors = ex.Message;
                return queryResult;

            }
            finally
            {
                this.closeConnection();
                insertCommand.Dispose();

            }
        }//end of insertMobile method

        public string updateMobile(DataTable brandTable)
        {
            try
            {
                this.openConnection();
                mobileAdapter.Update(brandTable);
                return "Mobile details are updated successfully";
            }
            finally
            {
                this.closeConnection();
            }

        }//end updateMobile method

        public DataTable selectBrandTable()
        {
            DataTable brandTable = new DataTable();
            string sqlString = "SELECT BRANDID, BRANDNAME from BRANDDETAILS";
            SqlCommand brandSelectCommand = new SqlCommand(sqlString, this.getConnection());

            try
            {
                DataSet brandDataSet = new DataSet();
                mobileAdapter = new SqlDataAdapter(brandSelectCommand);
                this.openConnection();
                mobileAdapter.Fill(brandDataSet);
                brandTable = brandDataSet.Tables[0];
                return brandTable;
            }
            catch (Exception ex)
            {
                DBErrors = ex.Message;
                return brandTable;

            }
            finally {

                this.closeConnection();
                brandSelectCommand.Dispose();
            }
        }//end selectBrandTable




    }
}