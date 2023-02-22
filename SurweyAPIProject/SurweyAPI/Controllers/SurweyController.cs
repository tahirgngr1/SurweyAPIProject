using DataAccess;
using DataAccess.Implements;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurweyAndLists;

namespace SurweyAPI.Controllers
{
    public class SurweyController : Controller
    {
        private readonly SurweyDbContext _context;
        private readonly ISurweyRepository repository;
        public SurweyController(ISurweyRepository repository) 
        {
            this.repository = repository;
            _context = new SurweyDbContext();
        }
        [HttpGet("/findSurweys")]
        public List<Surwey> GetSurweys()
        {
           return repository.GetAll();
           
        }
        [HttpPost("/saveSurweys")]
        public async Task<ActionResult<Surwey>> PostSurwey(Surwey surwey)
        {
            _context.Surweys.Add(surwey);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSurweys), new {id = surwey.Id}, surwey);
        }
    }
}
