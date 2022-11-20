using MySql.Data.MySqlClient;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Management.DAO
{
    public class ConnectToPhucMySQL
    {
        public string server = "127.0.0.1";
        public string database = "smartphonemanagement";
        public string username = "phuc";
        public string password = "phuc";
        static MySqlConnection conn = null;

        public static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=smartphonemanagement;Uid=root;");
            }
            return conn;

        }

        static QueryFactory db = null;

        public static QueryFactory Db() 
        {
            if(db == null)
            {
                var compiler = new MySqlCompiler();
                db = new QueryFactory(GetConnection(), compiler);
            }
            return db;
        
        }

    }
}
