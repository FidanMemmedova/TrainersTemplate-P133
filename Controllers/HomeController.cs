using Microsoft.AspNetCore.Mvc;
using Practice.DataAccessLayer;
using Practice.Models;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Course> courses = _context.courses.ToList();
            return View(courses);
        }
    }
}
