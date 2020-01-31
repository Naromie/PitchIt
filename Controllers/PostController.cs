using Microsoft.AspNetCore.Mvc;
using PitchIt.Data;
using PitchIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitchIt.Controllers
{
    public class PostController :Controller
    {
        private ApplicationDbContext context;
        public PostController(ApplicationDbContext dbContext)
        {
            this.context = dbContext;
        }
        // Get:/Controller

        public IActionResult Index()
        {
            IList<Post> posts = context.Posts;

            return View(posts);
        }
    }
}
