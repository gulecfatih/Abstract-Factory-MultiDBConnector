using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_MultiDBConnector.Interface
{
    // Soyut Fabrika Arayüzü
    interface IDatabaseFactory
    {
        IDbConnection CreateConnection();
        IDbCommand CreateCommand(string query, IDbConnection connection);
    }

}
