using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace DAL.Cache
{
    public class RedisConnection
    {
        private Lazy<ConnectionMultiplexer> lazyConnection;

        public RedisConnection(IConfiguration configuration)
        {
            lazyConnection = new Lazy<ConnectionMultiplexer>(() => 
            {
                return ConnectionMultiplexer.Connect(configuration.GetConnectionString("Cache"));
            });
        }

        public ConnectionMultiplexer Connection 
        {
            get 
            {
                return lazyConnection.Value;
            }
        }
    }
}
