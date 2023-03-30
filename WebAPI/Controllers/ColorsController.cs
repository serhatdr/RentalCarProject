using Business.Abstract;
using Entitites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : Controller
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpPost("add")]
        public void Add(Color color)
        {
            _colorService.Add(color);
        }
        [HttpDelete("delete")]
        public void Delete(Color color)
        {
            _colorService.Delete(color);
        }
        [HttpPut("update")]
        public void Update(Color color)
        {
            _colorService.Update(color);
        }
    }
}
