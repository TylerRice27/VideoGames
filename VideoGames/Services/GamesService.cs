namespace VideoGames.Services
{
    public class GamesService
    {
        private readonly GamesRepository _gr;

        public GamesService(GamesRepository gr)
        {
            _gr = gr;
        }

        internal List<Game> Get()
        {
            return _gr.Get();
        }
    }
}