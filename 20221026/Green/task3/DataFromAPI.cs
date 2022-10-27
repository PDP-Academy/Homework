using System;
namespace task3
{
    public class DataFromAPI
    {
        public DataFromAPI(List<Country> country, string name)
        {
            this.Name = name;
            this.Country = country;
        }

        public List<Country> Country { get; set; }
        public string Name { get; set; }
    }
}

