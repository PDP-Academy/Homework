using System;
namespace task2;
public class Root
    {
        public string status { get; set; }
        public string message { get; set; }
        public int totalResults { get; set; }
        public List<Article> articles { get; set; }
        public List<Source> sources { get; set; }
}