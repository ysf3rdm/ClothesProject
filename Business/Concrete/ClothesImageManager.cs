using Business.Abstract;
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
    public class ClothesImageManager : IClothesImageService
    {
        IClothesImageDal _clothesImageDal;

        public ClothesImageManager(IClothesImageDal clothesImageDal)
        {
            _clothesImageDal = clothesImageDal;
        }

        public IResult Add(IFormFile file, ClothesImage image)
        {

            image.ImagePath = FileHelper.Add(file);
            image.Date = DateTime.Now;
            _clothesImageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Delete(ClothesImage image)
        {
            FileHelper.Delete(image.ImagePath);
            _clothesImageDal.Delete(image);
            return new SuccessResult();
        }

        public IDataResult<List<ClothesImage>> GetAll()
        {
            return new SuccessDataResult<List<ClothesImage>>(_clothesImageDal.GetAll());
        }

        public IDataResult<ClothesImage> GetById(int Id)
        {
            return new SuccessDataResult<ClothesImage>(_clothesImageDal.GetById(p => p.Id == Id));
        }

        public IDataResult<List<ClothesImage>> GetImagesByClothesId(int Id)
        {
            var result = _clothesImageDal.GetAll(c => c.ClothesId == Id);
            if (result.Any())
            {
                return new SuccessDataResult<List<ClothesImage>>(result);
            }
            else
            {
                return new SuccessDataResult<List<ClothesImage>>(new List<ClothesImage>
            {
                new ClothesImage{  ClothesId = Id,  ImagePath = "\\Images\\default.jpg", Date = DateTime.Now }
            });
            }
        }

        public IResult Update(IFormFile file, ClothesImage image)
        {
            image.ImagePath = FileHelper.Update(_clothesImageDal.GetById(p => p.Id == image.Id).ImagePath, file);
            image.Date = DateTime.Now;
            _clothesImageDal.Update(image);
            return new SuccessResult();
        }
    }
}
