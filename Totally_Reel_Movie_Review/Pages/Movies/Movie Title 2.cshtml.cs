using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Totally_Reel_Movie_Review.Models;
using Totally_Reel_Movie_Review.Data;


namespace Totally_Reel_Movie_Review.Pages
{
public class Movie2Model : PageModel{
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _dbContext;

      public Movie2Model(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public Movie CurrentMovie{get; set;} 

        public void OnGet()
        {
           this.CurrentMovie= _dbContext.Movies.Find(2);
 
        }
}
}






