using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClothesImageService
    {
        IDataResult<List<ClothesImage>> GetAll();
        IDataResult<ClothesImage> GetById(int Id);
        IDataResult<List<ClothesImage>> GetImagesByClothesId(int Id);
        IResult Add(IFormFile file, ClothesImage image);
        IResult Delete(ClothesImage image);
        IResult Update(IFormFile file, ClothesImage image);
    }
}
