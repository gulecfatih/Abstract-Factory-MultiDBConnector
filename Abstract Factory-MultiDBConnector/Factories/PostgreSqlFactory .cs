using Abstract_Factory_MultiDBConnector.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_MultiDBConnector.Factories
{
    class PostgreSqlFactory : IDatabaseFactory
    {
        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection();
        }

        public IDbCommand CreateCommand(string query, IDbConnection connection)
        {
            return new NpgsqlCommand(query, (NpgsqlConnection)connection);
        }
    }
}
