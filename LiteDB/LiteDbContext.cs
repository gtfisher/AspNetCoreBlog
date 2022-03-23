using LiteDB;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiteDbSample.LiteDb
{
    public class LiteDbContext : ILiteDbContext 
    {
        public LiteDatabase Database { get; }

        public LiteDbContext(IOptions<LiteDbOptions> options)
        {   
            Console.WriteLine("LiteDbContext called");
            // Database = new LiteDatabase(options.Value.DatabaseLocation);
            Database = new LiteDatabase("Data/Blog.db");
        }
    }
}