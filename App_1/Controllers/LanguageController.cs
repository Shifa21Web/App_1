using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

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



        [HttpGet("{id:int}")]
        public  async Task<IActionResult> getcurrencybyidAsync([FromRoute] int id)
        {
            var sys =await  _context.Language.FindAsync(id);
            return Ok(sys);
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> getcurrencybyNameAsync([FromRoute] string name)
        {
            var sys = await _context.Language.Where(x=>x.Title == name).FirstOrDefaultAsync();
            return Ok(sys);
        }



        [HttpPost("All")]
        public async Task<IActionResult> getcurrencybyAllAsync([FromBody] List<int> ids)
        {
            //var ids = new List<int> { 1 };
            var sys = await _context.Language.Where(x=>ids.Contains(x.Id)).
                ToListAsync();
            return Ok(sys);
        }


        [HttpPost("bOOKS")]
        public async Task<IActionResult> AddNewBook([FromBody] Book model)
        {

           // model.Title = "Good Habit";
            _context.Book.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

    }
}

