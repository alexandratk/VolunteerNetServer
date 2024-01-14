using Newtonsoft.Json;
using StackExchange.Redis;

namespace DAL.Cache
{
    public class CacheService: ICacheService
    {
        private readonly IDatabase redisDb;

        public CacheService(RedisConnection redisConnection)
        {
            this.redisDb = redisConnection.Connection.GetDatabase(); ;
        }

        public T GetData<T>(string key)
        {
            var value = redisDb.StringGet(key);
            if (!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<T>(value);
            }

            return default;
        }

        public async Task<T> GetDataAsync<T>(string key)
        {
            var value = await redisDb.StringGetAsync(key);
            if (!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<T>(value);
            }

            return default;
        }

        public bool RemoveData(string key)
        {
            bool _isKeyExist = redisDb.KeyExists(key);
            if (_isKeyExist == true)
            {
                return redisDb.KeyDelete(key);
            }
            return false;
        }

        public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            var isSet = redisDb.StringSet(key, JsonConvert.SerializeObject(value), expiryTime);
            return isSet;
        }
    }
}
