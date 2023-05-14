using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
    }
    public class DatabaseAccess
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=SPIDERMAN\SQLEXPRESS;Initial Catalog=Pharmacity;Integrated Security=True");
    }
}
