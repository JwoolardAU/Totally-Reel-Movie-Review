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
    public class SelfProfileModel : PageModel
    {
        private readonly ILogger<ProfileModel> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public SelfProfileModel(UserManager<ApplicationUser> userManager, ILogger<ProfileModel> logger, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _logger = logger;
            _dbContext = dbContext;
        }

        public ApplicationUser CurrentUser  {get; set;}

        public async Task<IActionResult> OnGet() 
        {

            return Page();  

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // this.CurrentUser = await _userManager.GetUserAsync(User); //??? Not sure if this is the correct way of identifying current logged in user? 

            // _dbContext.ApplicationUser.Add(CurrentUser);     //I only want to update the specific ApplicationUser properties, not add another user
            // await _dbContext.SaveChangesAsync();             //Also " 'ApplicationDbContext' does not contain a definition for 'ApplicationUser' "

            return Redirect("./SelfProfile");
        }



    }
}
