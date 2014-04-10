using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public partial class Genre
    {
    
        public int GenreId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Test1 { set; get; }
        public List<Album> Album { set; get; }
    }
}