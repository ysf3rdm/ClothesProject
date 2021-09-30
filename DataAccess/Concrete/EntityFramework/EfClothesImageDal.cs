
using System;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfClothesImageDal : EfEntityRepositoryBase<ClothesImage, ClothesContext>, IClothesImageDal
    {
       
    }
}
