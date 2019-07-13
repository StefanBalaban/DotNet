using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _command;

        public DbCommand(DbConnection connection, string command)
        {
            _connection = connection;
            _command = command;
        }
        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Command has been executed");
            _connection.Close();
        }
    }
}
