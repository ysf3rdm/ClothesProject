using System;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using System.Collections.Generic;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfClothesDal : EfEntityRepositoryBase<Clothes, ClothesContext>, IClothesDal
    {
        public List<ClothesSize> GetClothesSizesByClothesId(Expression<Func<Clothes, bool>> filter = null)
        {
            using (ClothesContext context = new ClothesContext())
            {
                IQueryable<ClothesSize> clothesDetails = from c in filter is null ? context.Clothes : context.Clothes.Where(filter)
                                                         join s in context.ClothesSizes
                                                         on c.SizeId equals s.Id
                                                         select new ClothesSize
                                                         {
                                                             Id = s.Id,
                                                             Size = s.Size,

                                                         };
                return clothesDetails.ToList();
            }
        }

        public List<ClothesDetail> GetClothesDetail(Expression<Func<Clothes, bool>> filter = null)
        {
            using (ClothesContext context = new ClothesContext())
            {
                IQueryable<ClothesDetail> clothesDetails = from c in filter is null ? context.Clothes : context.Clothes.Where(filter)
                                                           join t in context.Categories
                                                           on c.CategoryId equals t.CategoryId
                                                           join b in context.Brands
                                                           on c.BrandId equals b.Id
                                                           join x in context.ClothesSizes
                                                           on c.SizeId equals x.Id
                                                           select new ClothesDetail
                                                           {
                                                               Id = c.Id,
                                                               ClothesId = c.ClothesId,
                                                               CategoryId = t.CategoryId,
                                                               BrandId = b.Id,
                                                               SizeId = x.Id,
                                                               CategoryName = t.CategoryName,
                                                               BrandName = b.BrandName,
                                                               Size = x.Size,
                                                               ClothesName = c.ClothesName,
                                                               ClothesInStock = c.ClothesInStock,
                                                               ClothesPrice = c.ClothesPrice,
                                                               ImagePath = (from i in context.ClothesImages where i.ClothesId == c.ClothesId select i.ImagePath).FirstOrDefault(),
                                                           };


                return clothesDetails.ToList();
            }
        }
        
    }  
}
