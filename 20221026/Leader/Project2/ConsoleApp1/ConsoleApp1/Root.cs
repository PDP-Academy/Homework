using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Root
    {
        public string? Status { get; set; }
        public int? TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }
}
