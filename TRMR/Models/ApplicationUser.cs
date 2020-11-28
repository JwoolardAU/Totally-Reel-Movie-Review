using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace TRMR.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[Required] // may need to be added with a new migration&update
        public string ReelName {get; set;}  
    }
}
