namespace Movie
{

    public class Root
    {
        public List<Search> Search { get; set; }
        public string TotalResults { get; set; }
        public string Response { get; set; }  
        public override string ToString()
        {
            return $"InfoOfMovie:{Search},Total results:{TotalResults},Response:{Response}"; 
        }

    }

}
