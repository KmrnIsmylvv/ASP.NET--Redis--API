using Microsoft.AspNetCore.Mvc;
using RedisAPI.Data;
using RedisAPI.Models;

namespace RedisAPI.Controllers
{
    public class PlatformsController : BaseApiController
    {
        private readonly IPlatformRepo _repo;
        public PlatformsController(IPlatformRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("{id}", Name = "GetPlatformById")]
        public ActionResult<Platform> GetPlatformById(string id)
        {
            var platform = _repo.GetPlatformById(id);

            if (platform != null)
                return Ok(platform);

            return NotFound();
        }

        [HttpPost]
        public ActionResult<Platform> CreatePlatform(Platform platform)
        {
            _repo.CreatePlatform(platform);

            return CreatedAtRoute(nameof(GetPlatformById), new { Id = platform.Id }, platform);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Platform>> GetPlatforms()
        {
            return Ok(_repo.GetAllPlatforms());
        }

    }

}