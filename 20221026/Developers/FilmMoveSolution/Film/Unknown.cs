using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

<<<<<<< HEAD

namespace Film
{
    public class Unknown
    {
        static void Main(string[] args)
        {

        }
    }

    class LeftRigth<T>
    {
        public void SHow(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                if (i + 1 % 10 == 0)
                {
                    Console.WriteLine("<- Oraqaga || Oldinga ->");
                    int key = (int)Console.ReadKey().Key;
                    if (key == 39 && i != list.Count - 1)
                    {
                        continue;
                    }
                    else if (key == 37 && i != 0)
                    {
                        i -= 10;
                    }
                }
            }

        }
    }

    class unknown
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public int Genre { get; set; }
        public int Director { get; set; }
        public int Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public rating[] Ratings { get; set; }
        public string Metascore { get; set; }

        [JsonPropertyName("imdbRating")]
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public string Response { get; set; }

    }
    class rating
    {
        public string Source { get; set; }
        public string Value { get; set; }

    }
}
=======
        class unknown
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string Rated { get; set; }
            public string Released { get; set; }
            public string Runtime { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public string Writer { get; set; }
            public string Actors { get; set; }
            public string Plot { get; set; }
            public string Language { get; set; }
            public string Country { get; set; }
            public string Awards { get; set; }
            public string Poster { get; set; }
            public rating[] Ratings { get; set; }
            public string Metascore { get; set; }

            [JsonPropertyName("imdbRating")]
            public string ImdbRating { get; set; }
            public string ImdbVotes { get; set; }
            public string ImdbID { get; set; }
            public string Type { get; set; }
            public string DVD { get; set; }
            public string BoxOffice { get; set; }
            public string Production { get; set; }
            public string Website { get; set; }
            public string Response { get; set; }

        }
        class rating
        {
            public string Source { get; set; }
            public string Value { get; set; }

        }
>>>>>>> 527e6d95b920c443abd4f29f2c25d5ae28f9c223
