using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            //var cur = _context.Currency.ToList();

            var cur = (from _currencys in _context.Currency
                      select _currencys).ToList();
            return Ok(cur);
        }



        [HttpGet]
        [Route("/api/GetallCurrencyList")]
        public async Task<IActionResult> GetallCurrencyList()
        {
            ////var cur = _context.Currency.ToList();

            //var cur = (from _currencys in _context.Currency
            //           select _currencys).ToList();

            var cur = await _context.Currency.ToListAsync();
            return Ok(cur);
        }
    }   
}
