using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qaf_mvc.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string PhotoUrl { get; set; }
        public IEnumerable<string> Details { get; set; }

    }
}
