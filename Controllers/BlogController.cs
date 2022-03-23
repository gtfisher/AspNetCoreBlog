using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDbSample.LiteDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.Models;


namespace blog2.Controllers;

 [ApiController]
 [Route("[controller]")]
  public class BlogController : ControllerBase
  {
       private readonly ILogger<BlogController> _logger;
       private readonly ILiteDbBlogService _blogDbService;

       public BlogController(ILogger<BlogController> logger, ILiteDbBlogService blogService)
       {
           _blogDbService = blogService;
           _logger = logger;
       } 

       [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _blogDbService.FindAll();
        }

        [HttpGet("{id}", Name = "FindOne")]
        public ActionResult<Post> Get(int id)
        {
            var result = _blogDbService.FindOne(id);
            if (result != default)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult<Post> Insert (Post dto)
        {
            var id = _blogDbService.Insert(dto);
            if (id != default )
                return CreatedAtRoute("FindOne", new { ID = id}, dto);
            else
                return BadRequest();
        }

        [HttpPut]
        public ActionResult<Post> Update(Post dto)
        {
            var result = _blogDbService.Update(dto);
            if (result)
                return NoContent();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult<Post> Delete(int id)
        {
            var result = _blogDbService.Delete(id);
            if (result > 0)
                return NoContent();
            else
                return NotFound();
        }


 
  }

  