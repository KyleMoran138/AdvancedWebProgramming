using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labs.Models {
    public class Author {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Biography { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}