using System;
using System.Collections.Generic;
using System.Linq;

namespace Pratik_LinqJoin
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
    }
}
