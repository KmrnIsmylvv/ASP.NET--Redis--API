using RedisAPI.Models;

namespace RedisAPI.Data
{
    public class RedisPlatformRepo : IPlatformRepo
    {
        public void CreatePlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new NotImplementedException();
        }

        public Platform GetPlatformById(string id)
        {
            throw new NotImplementedException();
        }
    }
}