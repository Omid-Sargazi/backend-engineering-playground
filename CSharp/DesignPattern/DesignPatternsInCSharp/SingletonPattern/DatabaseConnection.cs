using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.SingletonPattern
{
    public class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> _instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private DatabaseConnection()
        {
            Console.WriteLine("Database connection established.");
        }

        public static DatabaseConnection Instance => _instance.Value;

        public void Query(string sql)
        {
            Console.WriteLine($"Executing SQL: {sql}");
        }
    }

}
