using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuseumTest.Domain.Entities;
using MuseumTest.Services.ICustomServices;

namespace MuseumTest.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuseumsController : ControllerBase
    {
        IMuseumService _museumsService { get; set; }

        public MuseumsController(IMuseumService museumService)
        {
            _museumsService = museumService;
        }

        [HttpPost,Route("Create")]
        public IActionResult Create(Museum museum)
        {
            try
            {
                _museumsService.GetCrud().Insert(museum);
                return new JsonResult(true);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [HttpPost, Route("Update")]
        public IActionResult Update(Museum museum)
        {
            try
            {
                _museumsService.GetCrud().Update(museum);
                return new JsonResult(true);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [HttpPost, Route("Delete")]
        public IActionResult Delete(Museum museum)
        {
            try
            {
                _museumsService.GetCrud().Delete(museum);
                return new JsonResult(true);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }

        [HttpGet, Route("GetAllMuseums")]
        public IActionResult GetAllMuseums()
        {
            try
            {
                var museums = _museumsService.GetCrud().GetAll();
                return new JsonResult(museums);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }


        [HttpPost, Route("GetMuseumsType")]
        public IActionResult GetMuseumsType(Type type)
        {
            try
            {
                var museums = _museumsService.GetMuseumsType(type.type);
                return new JsonResult(museums);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        }
    }

    public class Type
    {
        public string type { get; set; }
    }
}
