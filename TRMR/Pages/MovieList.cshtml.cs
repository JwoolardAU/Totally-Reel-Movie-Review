using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using TRMR.Models;
using TRMR.Data;

namespace TRMR.Pages
{
    public class MovieListModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _dbContext;
        public MovieListModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public List<Movie> Movies = new List<Movie>();
        public void OnGet()
        {
            this.Movies.AddRange(_dbContext.Movies);
         }
    }
}
