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

        public void OnGet()
        {
            this.CurrentUser = _dbContext.User.Find("patrickarchy");//We need to find the user who matches the link that was clicked on
        }
    }
}
