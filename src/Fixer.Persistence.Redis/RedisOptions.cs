using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Persistence.Redis
{
    public class RedisOptions
    {
        public string ConnectionString { get; set; } = "localhost";
        public string Instance { get; set; }
    }
}
