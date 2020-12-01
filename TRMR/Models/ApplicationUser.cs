using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace TRMR.Models
{
    public class ApplicationUser : IdentityUser //This classes serves as an extension to the built in Identity Model. 
    {                                           //We wanted more values in our AspNetUsers table to be able to call and manipulate for TRMR

        public string ReelName {get; set;}  // Acts as the "actual" username

        //PROFILE PAGE CONTENT
        public string FavMovie {get; set;} = "This TRMR user has not listed any favorite movie(s) as of yet";
        public string FavGenre {get; set;} = "This TRMR user has not listed any favorite genre(s) as of yet";
        public string Bio {get; set;} = "This TRMR user has not made any fun facts about themselves yet";

    }
} 
