using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScienceHub.Core.Abstarctions;
using ScienceHub.Core.Entities;
using ScienceHub.Data.Concretes;

namespace ScienceHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;
        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            ICollection<Article> articles = _articleService.GetAll();
            return Ok(articles);
        }
    }
}
