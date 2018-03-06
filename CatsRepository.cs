namespace Cats.API
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;

    public class CatsRepository : Repository
    {
        public IEnumerable<Cats> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Cats>(
                    "select CatId, CatName, CatBreed, CatFood, CatStatus"
                    + "from Cats;"
                    , commandType: CommandType.Text);
            }

        }
    }

}