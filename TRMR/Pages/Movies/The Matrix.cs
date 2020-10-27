using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TRMR.Models;
using TRMR.Data;


namespace TRMR.Pages
{
public class Movie4Model : PageModel{
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _dbContext;

      public Movie4Model(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public Movie CurrentMovie{get; set;} 
        public IEnumerable<Review> Reviews {get; set;} = new List<Review>();

        public void OnGet()
        {
           
           this.CurrentMovie= _dbContext.Movies.Find(4);
 
            this.Reviews =  _dbContext.Review .Where(s => s.Movie_Id == 4).ToList();
        }
    
        
        }}




