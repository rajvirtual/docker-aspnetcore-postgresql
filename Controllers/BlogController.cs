using dockerapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
namespace dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591
    public class BlogController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public BlogController(ApiDbContext context)
        {
            _context = context;
        }
#pragma warning restore CS1591

        /// <summary>
        /// This method shows all blogs
        /// </summary>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/Blog
        /// </remarks> 
        [HttpGet]
        public object Get()
        {
            return _context.Blogs.Where(b => b.Title.Contains("Title")).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description
            }).ToList();
        }

        /// <summary>
        /// This method shows all blogs by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/Blog/title1
        /// </remarks>
        [HttpGet("{title}")]
        public object GetByTitle(string title)
        {
            return _context.Blogs.Where(b => b.Title == title).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description
            }).ToList();
        }

    }
}