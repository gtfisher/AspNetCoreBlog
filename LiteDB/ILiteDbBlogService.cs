using LiteDB;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace LiteDbSample.LiteDb
{
     public interface ILiteDbBlogService
    {
        int Delete(int id);
        IEnumerable<Post> FindAll();
        Post FindOne(int id);
        int Insert(Post post);
        bool Update(Post post);
    }
}