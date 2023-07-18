using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    
    public class ProducersController : Controller
    {

        //first inject the AppDbContext
        private readonly AppDBContext _context;
        public ProducersController(AppDBContext context)
        {
                _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducer = await _context.Producers.ToListAsync();
            return View(allProducer);
        }
    }
}
