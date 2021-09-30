using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ClothesManager:IClothesService
    {
        IClothesDal _clothesDal;
        public ClothesManager(IClothesDal clothesDal)
        {
            _clothesDal = clothesDal;            
        }

        public IResult Add(Clothes clothes)
        {
            _clothesDal.Add(clothes);
            return new SuccessResult(Messages.ClothesAdded);
        }

        public IResult Delete(Clothes clothes)
        {
            _clothesDal.Delete(clothes);
            return new SuccessResult(Messages.ClothesDeleted);
        }

        public IDataResult<List<Clothes>> GetAll()
        {
            return new SuccessDataResult<List<Clothes>>(_clothesDal.GetAll());
        }

        public IDataResult<List<ClothesDetail>> GetClothesBySizeAndClohtesId(int clothesId, int sizeId)
        {
            return new SuccessDataResult<List<ClothesDetail>>(_clothesDal.GetClothesDetail(p => p.ClothesId == clothesId & p.SizeId == sizeId));
        }

        public IDataResult<List<ClothesDetail>> GetClothesBySizeId(int sizeId)
        {
            return new SuccessDataResult<List<ClothesDetail>>(_clothesDal.GetClothesDetail(p => p.SizeId == sizeId));
        }

        public IDataResult<List<ClothesDetail>> GetClothesDetail()
        {
            return new SuccessDataResult<List<ClothesDetail>>(_clothesDal.GetClothesDetail());
        }

        public IDataResult<List<ClothesDetail>> GetClothesDetailById(int Id)
        {
            return new SuccessDataResult<List<ClothesDetail>>(_clothesDal.GetClothesDetail(p=> p.ClothesId == Id));
        }

        public IDataResult<List<ClothesSize>> GetSizesByClothesId(int clothesId)
        {
            return new SuccessDataResult<List<ClothesSize>>(_clothesDal.GetClothesSizesByClothesId(c=> c.ClothesId == clothesId));
        }

        public IResult Update(Clothes clothes)
        {
            _clothesDal.Update(clothes);
            return new SuccessResult(Messages.ClothesUpdated);
        }
    }
}
