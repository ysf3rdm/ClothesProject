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
    public class ClothesController : ControllerBase
    {
        IClothesService _clothesService;

        public ClothesController(IClothesService clothesService)
        {
            _clothesService = clothesService;
        }

        [HttpPost("add")]
        public IActionResult Add(Clothes clothes)
        {
            var result = _clothesService.Add(clothes);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {          
            var result = _clothesService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getclothesdetail")]
        public IActionResult GetClothesDetail()
        {
            var result = _clothesService.GetClothesDetail();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getclothesdetailbyid")]
        public IActionResult GetClothesDetailById(int Id)
        {
            var result = _clothesService.GetClothesDetailById(Id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getclothesdetailbysizeid")]
        public IActionResult GetClothesDetailBySizeId(int sizeId)
        {
            var result = _clothesService.GetClothesBySizeId(sizeId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getsizesbyclothesid")]
        public IActionResult GetClothesSizesById(int Id)
        {
            var result = _clothesService.GetSizesByClothesId(Id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbysizeandclothesid")]
        public IActionResult GetClothesBySizeAndClothesId(int clothesId , int sizeId)
        {
            var result = _clothesService.GetClothesBySizeAndClohtesId(clothesId,sizeId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
