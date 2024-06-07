using Abstract_Factory_MultiDBConnector.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Abstract_Factory_MultiDBConnector.Factories
{
    class MySqlFactory : IDatabaseFactory
    {
        public IDbConnection CreateConnection()
        {
            return new MySqlConnection();
        }

        public IDbCommand CreateCommand(string query, IDbConnection connection)
        {
            return new MySqlCommand(query, (MySqlConnection)connection);
        }
    }
}
