namespace LeaderConsole
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public override string ToString()
        {
            return $"Title : {Title}         Year : {Year}";
        }
    }
}
