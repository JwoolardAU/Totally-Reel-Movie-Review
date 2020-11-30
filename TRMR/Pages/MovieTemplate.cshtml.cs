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
    public class MovieTemplateModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _dbContext;

        public MovieTemplateModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public Movie CurrentMovie{get; set;} 
        public IEnumerable<Review> Reviews {get; set;} = new List<Review>();

        public IActionResult OnGet(int? id) //ARGUMENT NAME HAS TO MATCH QUERY STRING METADATA NAME (I.E. "id = blah")
        {
            if(id == null)
            {
                return NotFound();
            }

            CurrentMovie = _dbContext.Movies.Find(id);

            Reviews = _dbContext.Review.Where(s => s.Movie_Id == id);

            if(CurrentMovie  == null)
            {
                return NotFound();
            }

            return Page();        
        }


        [BindProperty]
        public Review TheReview { get; set; }


        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            _dbContext.Review.Add(TheReview);
            await _dbContext.SaveChangesAsync();

            return Redirect("./MovieTemplate?id=" + id);
        }




        
    }
}
