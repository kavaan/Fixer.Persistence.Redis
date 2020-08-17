using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Persistence.Redis.Builders
{
    internal sealed class RedisOptionsBuilder : IRedisOptionsBuilder
    {
        private readonly RedisOptions _options = new RedisOptions();

        public IRedisOptionsBuilder WithConnectionString(string connectionString)
        {
            _options.ConnectionString = connectionString;
            return this;
        }

        public IRedisOptionsBuilder WithInstance(string instance)
        {
            _options.Instance = instance;
            return this;
        }

        public RedisOptions Build()
            => _options;
    }
}
