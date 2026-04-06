using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csMysqlImageCrud
{
    internal class MysqlDatabaseConnection
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharpimagecrud;");

        //function to get connection

        public MySqlConnection getDatabaseConnection()
        {
            return connection;
        }

    }
}
