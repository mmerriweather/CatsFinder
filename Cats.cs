namespace Cats.API
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class Cats
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatBreed { get; set; }
        public string CatFood { get; set; }
        public string CatStatus { get; set; }
    }
}