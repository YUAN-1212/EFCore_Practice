using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCore.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleContext articleContext;

        public ArticleController(ArticleContext articleContext)
        {
            this.articleContext = articleContext;
        }

        // GET: api/<ArticleController>
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return articleContext.Articles;
        }

        // POST api/<ArticleController>
        [Route("~/api/Article/post")]
        [HttpPost]
        public void Post(Article article)
        {
            articleContext.Add(article);
            articleContext.SaveChanges();

        }

       
    }
}
