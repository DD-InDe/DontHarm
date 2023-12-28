using DontHarmAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DontHarmAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginHistoryController : ControllerBase
    {
        private readonly DontHarmContext _context;

        public LoginHistoryController(DontHarmContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<List<LoginHistory>>> GetHistory()
        {
            return await _context.LoginHistories.Include(c=>c.Employee).ToListAsync();
        }
    }
}