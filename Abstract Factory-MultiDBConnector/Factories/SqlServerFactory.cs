using Abstract_Factory_MultiDBConnector.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_MultiDBConnector.Factories
{
    // Somut Fabrikalar
    class SqlServerFactory : IDatabaseFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public IDbCommand CreateCommand(string query, IDbConnection connection)
        {
            return new SqlCommand(query, (SqlConnection)connection);
        }
    }

}
