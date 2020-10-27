using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace  TRMR.Models
{
    public class User
    {
        [Key]
        public String User_Id{get; set;}
        public DateTime Created{get; set;}
        [Required]
        public string Email{get; set;}
        [Required]
        public string Password{get; set;}
        public List<Review> Reviews{get; set;} = new List<Review> ();
        public String Status{get; set;}
        public String Tags {get; set;} 

    }
}
