using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MobileStore
{
    class DBConnection : IDBConnection<string>
    {

        //defining connectionString and SqlConnection
        private SqlConnection mobileConnection;
        string connectionString = ConfigurationManager.ConnectionStrings["MobileStore.Properties.Settings.MobileAppConnection"].ConnectionString;

        private SqlDataAdapter mobileAdapter;
        public string DBErrors { get; set; }

        //method to get connection
        public SqlConnection getConnection()
        {
            mobileConnection = new SqlConnection(connectionString);
            return mobileConnection;
        }

        //method to open connection
        public void openConnection()
        {
            if (mobileConnection.State == ConnectionState.Closed)
            {
                mobileConnection.Open();
            }

        }

        //method to close connection
        public void closeConnection()
        {
            mobileConnection.Close();
        }

        //method to insert data into mobile table
        public int insertMobile(string name, string os, string description, int price,int brandid, byte[] image)
        {
            string sqlString = "INSERT INTO PRODUCTDETAILS (PRODUCTNAME, BRANDID, OS, DESCRIPTION, PRICE,PRODUCTIMAGE) values(@name,@brandid, @os, @description, @price,@image);";
            SqlCommand insertCommand = new SqlCommand(sqlString, this.getConnection());

            int queryResult = 0;
            try
            {
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@brandid", brandid);
                insertCommand.Parameters.AddWithValue("@os", os);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.Parameters.AddWithValue("@price", price);
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

        //method to update the table
        public int updateTable(string sqlString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sqlString, mobileConnection);
                this.openConnection();
                return cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                DBErrors = ex.Message;
                return 0;
            }

            finally
            {
                this.closeConnection();
            }
        }//end updateMobile method

        //method to reveiw data from a table
        public DataTable selectTable(string sqlString)
        {
            DataTable table = new DataTable();
            SqlCommand brandSelectCommand = new SqlCommand(sqlString, this.getConnection());

            try
            {
                DataSet brandDataSet = new DataSet();
                mobileAdapter = new SqlDataAdapter(brandSelectCommand);
                this.openConnection();
                mobileAdapter.Fill(brandDataSet);
                table = brandDataSet.Tables[0];
                return table;
            }
            catch (Exception ex)
            {
                DBErrors = ex.Message;
                return table;
            }
            finally {

                this.closeConnection();
                brandSelectCommand.Dispose();
            }
        }//end selectTable

        // This method is used to insert new User
        public int insertUser(string sqlString) {
            try
            {
                SqlCommand cmd = new SqlCommand(sqlString, mobileConnection);
                this.openConnection();
                return cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                DBErrors = ex.Message;
                return 0;
            }

            finally
            {
                this.closeConnection();
            }

        }//end function insertUser

    }//end class DBConnection
}//end namespace