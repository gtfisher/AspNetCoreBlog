using LiteDB;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace LiteDbSample.LiteDb
{
     public class LiteDbBlogService :  ILiteDbBlogService
    {

         private LiteDatabase _liteDb;

         public LiteDbBlogService(ILiteDbContext liteDbContext)
        {
            _liteDb = liteDbContext.Database;
        }
       public IEnumerable<Post> FindAll()
        {
            var result = _liteDb.GetCollection<Post>("Post")
                .FindAll();
            return result;
        }
        public Post FindOne(int id)
        {
            return _liteDb.GetCollection<Post>("Post")
                .Find(x => x.ID == id).FirstOrDefault();
        }

        public int Insert(Post post)
        {
            return _liteDb.GetCollection<Post>("Post")
                .Insert(post);
        }

        public bool Update(Post post)
        {
            return _liteDb.GetCollection<Post>("Post")
                .Update(post);
        }

        public int Delete(int id)
        {
            // return _liteDb.GetCollection<Post>("Post")
            //     .Delete(x => x.ID == id);
            return id;
        }

    }
}