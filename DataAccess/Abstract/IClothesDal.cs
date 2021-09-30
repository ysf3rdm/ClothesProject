
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IClothesDal : IEntityRepository<Clothes>
    {
        List<ClothesDetail> GetClothesDetail(Expression<Func<Clothes, bool>> filter = null);
        List<ClothesSize> GetClothesSizesByClothesId(Expression<Func<Clothes, bool>> filter = null);
    }
}