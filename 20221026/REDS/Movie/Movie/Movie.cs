namespace Movies
{

    public class Search
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
