using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheExample
{
    public interface IDistributedCacheManager
    {
        byte[] Get(string key);
        T Get<T>(string key);
        void Set(string key, object value);
        void Refresh(string key);
        bool Any(string key);
        void Remove(string key);
    }
}
