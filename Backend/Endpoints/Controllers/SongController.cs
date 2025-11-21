using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Endpoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        private readonly IRepository<Song> _repository;

        public SongController(IRepository<Song> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Song>> GetAll()
        {
            return await _repository.GetAll().ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddSong([FromBody] Song song)
        {
            await _repository.Create(song);
            return Ok();
        }
    }
}

