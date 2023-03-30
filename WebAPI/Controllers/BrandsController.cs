using Business.Abstract;
using Entitites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : Controller
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpPost("add")]
        public void Add(Brand brand)
        {
            _brandService.Add(brand);
        }
        [HttpDelete("delete")]
        public void Delete(Brand brand)
        {
            _brandService.Delete(brand);
        }

    }
}
