using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Smartphone_Management.DAO
{
    public class ConncectToPhucSQL
    {
        public MySqlConnection conn = null;

        public ConncectToPhucSQL()
        {
            if (conn == null)
            {
               this.conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=smartphonemanagement;Uid=root;");
            }
        }

        public MySqlConnection GetConnection()
        {
            return conn;

        }
    }
}
