using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace  TRMR.Models
{
    public class Movie
    {
        public int Id{get; set;}
        public string Title{get; set;}
        public string Synopsis { get; set; }
        public string Details {get; set;}
        public string Director{ get; set; }
        public string Genre{ get; set; }
        public string Starring{ get; set; }
        public string Age_Rating{ get; set; }

        [NotMapped]
        public List<string> Cast{ get; set; } = new List<string>();
        public DateTime ReleaseDate{get; set;}

        public List<Review> Reviews{get; set;} = new List<Review>();
    }
}
