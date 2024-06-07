using Abstract_Factory_MultiDBConnector.Factories;
using Abstract_Factory_MultiDBConnector.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_MultiDBConnector
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SqlServer için fabrika kullanımı
            IDatabaseFactory sqlServerFactory = new SqlServerFactory();

            using (IDbConnection sqlServerConnection = sqlServerFactory.CreateConnection())
            {
                sqlServerConnection.ConnectionString = "sql_server_connection_string";
                sqlServerConnection.Open();

                using (IDbCommand sqlServerCommand = sqlServerFactory.CreateCommand("SELECT * FROM TableName", sqlServerConnection))
                {
                    // İşlemler
                }
                sqlServerConnection.Close();
            }


            // MySql için fabrika kullanımı
            IDatabaseFactory mySqlFactory = new MySqlFactory();

            using (IDbConnection mySqlConnection = mySqlFactory.CreateConnection())
            {
                mySqlConnection.ConnectionString = "mysql_connection_string";
                mySqlConnection.Open();

                using (IDbCommand mySqlCommand = mySqlFactory.CreateCommand("SELECT * FROM TableName", mySqlConnection))
                {
                    // İşlemler
                }
                mySqlConnection.Close();
            }

            // PostgreSql için fabrika kullanımı
            IDatabaseFactory postgreSqlFactory = new PostgreSqlFactory();

            using (IDbConnection postgreSqlConnection = postgreSqlFactory.CreateConnection())
            {
                postgreSqlConnection.ConnectionString = "postgre_sql_connection_string";
                postgreSqlConnection.Open();

                using (IDbCommand postgreSqlCommand = postgreSqlFactory.CreateCommand("SELECT * FROM TableName", postgreSqlConnection))
                {
                    // İşlemler
                }
                postgreSqlConnection.Close();
            }
        }
    }
}
