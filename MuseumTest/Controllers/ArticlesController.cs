using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuseumTest.Domain.Entities;
using MuseumTest.Services.ICustomServices;

namespace MuseumTest.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        IArticleService _articlesService { get; set; }

        public ArticlesController(IArticleService articlesService)
        {
            _articlesService = articlesService;
        }

        [HttpPost, Route("Create")]
        public IActionResult Create(Article article)
        {
            try
            {
                _articlesService.GetCrud().Insert(article);
                return new JsonResult(true);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [HttpPost, Route("Remove")]
        public IActionResult Remove(Article article)
        {
            try
            {
                _articlesService.GetCrud().Remove(article);
                return new JsonResult(true);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [HttpPost, Route("Edit")]
        public IActionResult Edit(Article article)
        {
            try
            {
                _articlesService.GetCrud().Update(article);
                return new JsonResult(true);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [HttpPost, Route("GetMuseumsArticle")]
        public IActionResult GetMuseumsArticle(Museum museum)
        {
            try
            {
                var articles = _articlesService.GetArticles(museum);
                return new JsonResult(articles);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }
    }
}
