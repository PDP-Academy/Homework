namespace Movies
{

    public class Movie
    {
        public List<Movie> Searc { get; set; }
        public string TotalResults { get; set; }
        public string Response { get; set; }  
        public override string ToString()
        {
            return $"InfoOfMovie:{Searc},Total results:{TotalResults},Response:{Response}"; 
        }

    }
}
