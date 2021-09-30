using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CategoryImageManager : ICategoryImageService
    {
        ICategoryImageDal _categoryImageDal;

        public CategoryImageManager(ICategoryImageDal categoryImageDal)
        {
            _categoryImageDal = categoryImageDal;
        }

        public IResult Add(IFormFile file, CategoryImage image)
        {
            
            image.ImagePath = FileHelper.Add(file);
            image.Date = DateTime.Now;
            _categoryImageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Delete(CategoryImage image)
        {
            FileHelper.Delete(image.ImagePath);
            _categoryImageDal.Delete(image);
            return new SuccessResult();
        }

        public IDataResult<List<CategoryImage>> GetAll()
        {
            return new SuccessDataResult<List<CategoryImage>>(_categoryImageDal.GetAll());
        }

        public IDataResult<CategoryImage> GetById(int Id)
        {
            return new SuccessDataResult<CategoryImage>(_categoryImageDal.GetById(p => p.Id == Id));
        }

        public IDataResult<List<CategoryImage>> GetImagesByCategoryId(int Id)
        {
            var result = _categoryImageDal.GetAll(c => c.CategoryId == Id);
            if (result.Any())
            {
                return new SuccessDataResult<List<CategoryImage>>(result);
            }
            else
            {
                return new SuccessDataResult<List<CategoryImage>>(new List<CategoryImage>
            {
                new CategoryImage{  CategoryId = Id,  ImagePath = "\\Images\\default.jpg", Date = DateTime.Now }
            });
            }
        }

        public IResult Update(IFormFile file, CategoryImage image)
        {
            image.ImagePath = FileHelper.Update(_categoryImageDal.GetById(p => p.Id == image.Id).ImagePath, file);
            image.Date = DateTime.Now;
            _categoryImageDal.Update(image);
            return new SuccessResult();
        }
    }
}
