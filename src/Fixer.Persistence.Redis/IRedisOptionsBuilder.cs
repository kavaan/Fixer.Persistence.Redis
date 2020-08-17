using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Persistence.Redis
{
    public interface IRedisOptionsBuilder
    {
        IRedisOptionsBuilder WithConnectionString(string connectionString);
        IRedisOptionsBuilder WithInstance(string instance);
        RedisOptions Build();
    }
}
