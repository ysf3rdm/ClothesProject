using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryImageService
    {
        IDataResult<List<CategoryImage>> GetAll();
        IDataResult<CategoryImage> GetById(int Id);
        IDataResult<List<CategoryImage>> GetImagesByCategoryId(int Id);
        IResult Add(IFormFile file, CategoryImage image);
        IResult Delete(CategoryImage image);
        IResult Update(IFormFile file, CategoryImage image);
    }
}
