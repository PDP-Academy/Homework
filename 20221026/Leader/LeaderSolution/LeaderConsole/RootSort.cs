using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaderConsole
{
    public class RootSort
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public List<Rating> Ratings { get; set; }
        public string Type { get; set; }
        public string Production { get; set; }
        public string Response { get; set; }

        public override string ToString()
        {
            return String.Format("{0,28}|{1,10}|{2,30}|{3,30}|{4,25}|{5,35}|{6,10}|{7,10}|{8,10}|", Title, Year, Genre, Director, Language, Country, Type,Production, Response);

        }
    }
}
