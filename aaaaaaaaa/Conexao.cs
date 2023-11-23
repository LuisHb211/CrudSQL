using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace FormsMySQL
{
    internal class Conexao
    {
        private MySqlConnection connection;
        private string connectionStrings;

        public MySqlConnection Connection1 { get => connection; set => connection = value; }
        public string ConnectionStrings { get => connectionStrings; set => connectionStrings = value; }


        public string ConnString()
        {
            var connString = "Server=127.0.0.1;User ID=root;Password=@Luisinho21;Database=poo";
            return connString;
        }
    }
}