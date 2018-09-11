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
    class MobileClass
    {
        //declaring sqlconnection
        private SqlConnection mobileConnection;
        //intializing a connection string
        string mobileConnectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

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
            finally
            {
                mobileConnection.Close();
            }
        }//closegetTable
    }
}