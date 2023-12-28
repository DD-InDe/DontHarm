using DontHarmAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DontHarmAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DontHarmContext _context;

        public AuthController(DontHarmContext context) => _context = context;

        [HttpGet("{login},{password}")]
        public async Task<ActionResult<Employee>> Auth(string login, string password)
        {
            Employee employee = await _context.Employees.Include(c=>c.Role).FirstOrDefaultAsync(c => c.Login == login);
            if (employee == null)
            {
                return NotFound("Пользователь не найден");
            }
            else
            {
                if (employee.Pas != password)
                {
                    await PostHistory(employee, HttpContext, false);
                    return Unauthorized("Неверный пароль");
                }
                else
                {
                    await PostHistory(employee, HttpContext, true);
                    return Ok(employee);
                }
            }
        }

        private async Task PostHistory(Employee employee,HttpContext context, bool success)
        {
            LoginHistory loginHistory = new LoginHistory() { Employee = employee, Successfully = success, LogDate = DateTime.Now };
            await _context.LoginHistories.AddAsync(loginHistory);
            await _context.SaveChangesAsync();
        }
    }
}