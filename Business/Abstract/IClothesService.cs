using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClothesService 
    {
        IDataResult<List<ClothesDetail>> GetClothesBySizeId(int sizeId);
        IDataResult<List<ClothesDetail>> GetClothesBySizeAndClohtesId(int clothesId, int sizeId);
        IDataResult<List<ClothesDetail>> GetClothesDetailById(int Id);
        IDataResult<List<ClothesDetail>> GetClothesDetail();
        IDataResult<List<ClothesSize>> GetSizesByClothesId(int clothesId);
        IResult Add(Clothes clothes);
        IResult Delete(Clothes clothes);
        IResult Update(Clothes clothes);
        IDataResult<List<Clothes>> GetAll();
    }
}
