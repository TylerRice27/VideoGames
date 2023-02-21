namespace VideoGames.Repositories
{
    public class GamesRepository
    {
        private readonly IDbConnection _db;

        public GamesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Game> Get()
        {
            string sql = @"SELECT * FROM games";
            return _db.Query<Game>(sql).ToList();

        }
    }
}