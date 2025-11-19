using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Endpoint.Controllers
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
        public async Task<IActionResult> AddSong(string artist, string title, int length, int likes)
        {
            await _repository.Create(new Song(artist, title, length, likes));
            return Ok();
        }
    }
}
