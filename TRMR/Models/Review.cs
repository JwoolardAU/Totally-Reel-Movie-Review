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
        public int User_Id{get; set;} //Should be changed to ReviewNumber
        
        [ForeignKey("User")]
        public String User_Name{get; set;} // ??? Some reference to the built in AspNetUser table for the current user (the one writing the review)

        public string User_Identification {get; set;} // Used to access specific user profile pages
        
        [ForeignKey("Movie")]
        public int Movie_Id{get; set;} //Get's filled in with @Model.CurrentMovie.Id

        public string Rating{ get; set; } //Get's filled in with "leave your rating" selector 

        public string Description {get; set;} //Get's filled in with "leave your own review" box
    }
}
