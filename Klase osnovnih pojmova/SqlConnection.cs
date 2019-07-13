using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("The SQL Server connection is open");

        }
        public override void Close()
        {
            Console.WriteLine("The SQL Server connection is closed");
        }
    }
}
