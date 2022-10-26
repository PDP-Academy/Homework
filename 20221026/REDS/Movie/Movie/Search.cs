namespace Movie
{
    public class Search
    {

        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
        public override string ToString()
        {
            return $" Title : {Title} Year : {Year} Imdb Id : {ImdbID} Type : {Type} Poster : {Poster}";
        }
    }
}
