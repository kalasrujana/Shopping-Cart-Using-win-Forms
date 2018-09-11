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
    interface IDBConnection<T>
    {
        DataTable selectTable(T sqlString);
        int updateTable(T sqlString);
    }
}
