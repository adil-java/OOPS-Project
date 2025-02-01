using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MyLibraryMS
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\oops project\MyLibraryMS\MyLibraryMS\Mylibrarydb.mdf"";Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        
    }
}
