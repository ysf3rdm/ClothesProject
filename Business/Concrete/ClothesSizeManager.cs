using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ClothesSizeManager:IClothesSizeService
    {
        IClothesSizeDal _clothesSizeDal;
        public ClothesSizeManager(IClothesSizeDal clothesSizeDal)
        {
            _clothesSizeDal = clothesSizeDal;
        }

        public IResult Add(ClothesSize size)
        {
            _clothesSizeDal.Add(size);
            return new SuccessResult(Messages.SizeAdded);
        }

        public IResult Delete(ClothesSize size)
        {
            _clothesSizeDal.Delete(size);
            return new SuccessResult(Messages.SizeDeleted);
        }

        public IDataResult<List<ClothesSize>> GetAll()
        {
            return new SuccessDataResult<List<ClothesSize>>(_clothesSizeDal.GetAll());
        }

        public IResult Update(ClothesSize size)
        {
            _clothesSizeDal.Update(size);
            return new SuccessResult(Messages.SizeUpdated);
        }
    }
}
