using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace  TRMR.Models
{
    public class Review
    {
        [Key]
        public int User_Id{get; set;}
        
        [ForeignKey("User")]
        public String User_Name{get; set;}
        
        [ForeignKey("Movie")]
        public int Movie_Id{get; set;}
        public string Rating{ get; set; }
        public string Description {get; set;}
    }
}
