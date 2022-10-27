using System;
namespace task2;
public class Root
    {
        public Root(string status, int totalResults, List<Article> articles)
        {
            this.Status = status;
            this.TotalResults = totalResults;
            this.Articles = articles;
        }
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }