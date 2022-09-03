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

        [HttpGet]
        public async Task<ActionResult<MoneyBalanceDTO>> GetBalance(double id)
        {
            
            var response = await _context.MoneyBalances.FindAsync(id);

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);






        }
    }
}
