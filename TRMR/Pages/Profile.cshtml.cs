using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using TRMR.Models;
using TRMR.Data;

namespace TRMR.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ILogger<ProfileModel> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileModel(UserManager<ApplicationUser> userManager, ILogger<ProfileModel> logger, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _logger = logger;
            _dbContext = dbContext;
        }

        // public User CurrentUser{get; set;} //Needs to be changed from hardcoded "User" to "ApplicationUser"

        public ApplicationUser CurrentUser  {get; set;}

        //public IActionResult OnGet(string userName) //ARGUMENT NAME HAS TO MATCH QUERY STRING METADATA NAME (I.E. "userName = blah")
        public async Task<IActionResult> OnGet(string useriden) //ARGUMENT NAME HAS TO MATCH QUERY STRING METADATA NAME (I.E. "userName = blah")
        {
           

            if(useriden == null)
            {
                return NotFound();
            }

            //this.CurrentUser = _dbContext.User.Find(userName);
            this.CurrentUser = await _userManager.FindByIdAsync(useriden); 
            
 
            if(CurrentUser  == null)
            {
                return NotFound();
            }

            return Page();  

        }
    }
}
