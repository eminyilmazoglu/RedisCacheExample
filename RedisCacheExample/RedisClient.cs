using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.Options;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheExample
{
    public class RedisClient
    {
        public RedisCache RedisCache;
        public RedisClient()
        {
            var redisOptions = new RedisCacheOptions
            {
                ConfigurationOptions = new ConfigurationOptions
                {
                    EndPoints = { { "127.0.0.1", 6379 } },
                    // Password = "" // create yapilirken sifre girmedik...
                }
            };

            var opts = Options.Create(redisOptions);
            RedisCache = new Microsoft.Extensions.Caching.StackExchangeRedis.RedisCache(opts);
        }
    }
}
