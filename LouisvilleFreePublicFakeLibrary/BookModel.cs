using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouisvilleFreePublicFakeLibrary
{
    internal class BookModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public string CoverType { get; set; }
        public string Author { get; set; } 
        public IEnumerable<string> Genre { get; set; }

    }
}
