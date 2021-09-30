using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesSizesController : Controller
    {
        IClothesSizeService _clothesSizeService;

        public ClothesSizesController(IClothesSizeService clothesSizeService)
        {
            _clothesSizeService = clothesSizeService;
        }

        [HttpPost("add")]
        public IActionResult Add(ClothesSize size)
        {
            var result = _clothesSizeService.Add(size);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _clothesSizeService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
