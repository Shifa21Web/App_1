using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LanguageController : Controller
    {
        private readonly AppDbContext _context;
        public LanguageController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/api/GetAllLanguages")]
        public IActionResult GetAllLanguages()
        {
            // var lan = _context.Language.ToList();

            var lan = (from languages in _context.Language
                       select languages).ToList();
            return Ok(lan);
        }



        [HttpGet("{id}")]
        public  async Task<IActionResult> getcurrencybyidAsync([FromRoute] int id)
        {
            var sys = _context.Language.FindAsync(id);
            return Ok(sys);
        }

    }
}

