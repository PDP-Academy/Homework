using System;
namespace task3
{
    public class Country
    {
        public Country(string country_id, float probability)
        {
            this.Country_id = country_id;
            this.Probability = probability;
        }
        public string Country_id { get; set; }
        public float Probability { get; set; }
    }
}

