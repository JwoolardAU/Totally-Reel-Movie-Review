using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TRMR.Models;
using TRMR.Data;

namespace TRMR.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ILogger<ProfileModel> _logger;
        private readonly ApplicationDbContext _dbContext;

        public ProfileModel(ILogger<ProfileModel> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public User CurrentUser{get; set;} 

        public IActionResult OnGet(string userName) //ARGUMENT NAME HAS TO MATCH QUERY STRING METADATA NAME (I.E. "userName = blah")
        {
           

             if(userName == null)
            {
                return NotFound();
            }

            this.CurrentUser = _dbContext.User.Find(userName);

            if(CurrentUser  == null)
            {
                return NotFound();
            }

            return Page();  

        }
    }
}
