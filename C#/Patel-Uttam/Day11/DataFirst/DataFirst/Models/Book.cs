using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirst.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int? Author { get; set; }

        public virtual Author AuthorNavigation { get; set; }
    }
}
