namespace Movies
{
    public class Movie
    { 
        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
        public override string ToString()
        {
            return $"'Film nomi':'{Title}'        'Chiqqan yili':'{Year}'";
        }

    }
}
