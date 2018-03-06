namespace Cats.API
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class Repository
    {
        private string connectionString = @"server=localhost;port=3306;database=Cats;user=root;password=P187lj6m!";
        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}