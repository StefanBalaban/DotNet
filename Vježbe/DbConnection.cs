using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (!String.IsNullOrWhiteSpace(connectionString))
            {
                _connectionString = connectionString;
                Console.WriteLine("The connection string is: " + connectionString);
            }
                
                
            else
                throw new ArgumentNullException();
        }
        public abstract void Open();
        public abstract void Close();
    }
}
