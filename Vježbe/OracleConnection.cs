using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {
                
        }
        public override void Open()
        {
            Console.WriteLine("The Oracle Server connection is open");
        }
        public override void Close()
        {
            Console.WriteLine("The Oracle Server connection is closed");
        }
    }
}
