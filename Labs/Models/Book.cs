using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labs.Models {
    public class Book {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public String Title { get; set; }
        public String Isbn { get; set; }
        public String Synopsis { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
        public virtual Author Author{ get; set; }
    }
}