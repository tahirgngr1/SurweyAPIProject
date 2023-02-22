using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurweyAndLists;

namespace SurweyAPI.Controllers
{
    public class SurweyController : Controller
    {
        private readonly SurweyDbContext _context;
        public SurweyController(SurweyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Surwey>>> GetSurweys()
        {
            return await _context.Surweys.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Surwey>> PostSurwey(Surwey surwey)
        {
            _context.Surweys.Add(surwey);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSurweys), new {id = surwey.Id}, surwey);
        }
    }
}
