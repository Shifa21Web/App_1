using Microsoft.AspNetCore.Mvc;

namespace App_1
{
    [Route("api/[controller]")]
    [ApiController]

    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CurrencyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/api/GetallCurrency")]
        public IActionResult GetallCurrency()
        {
            var cur = _context.Currency.ToList();
            return Ok(cur);
        }
    }   
}
