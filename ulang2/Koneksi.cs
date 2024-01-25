using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ulang2
{
    internal class Koneksi
    {
        public SqlConnection getConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = LAPTOP-BNI2LLE9\\SQLEXPRESS; Initial catalog = posDB; Integrated Security =True;";
            return conn;
        }
    }
}
