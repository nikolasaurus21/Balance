using Microsoft.AspNetCore.Mvc;
using Balance.Models;

namespace Balance.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class MBController : ControllerBase
    {
        private readonly MoneyBalanceContext _context;

        public MBController(MoneyBalanceContext moneyBalance)
        {
            _context = moneyBalance;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<MoneyBalanceDTO>> GetBalance(int Id)
        {
            
            var response = await _context.MoneyBalances.FindAsync(Id);

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);






        }
    }
}
