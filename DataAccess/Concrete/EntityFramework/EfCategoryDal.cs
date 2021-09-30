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
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ClothesContext>, ICategoryDal
    {
        public List<CategoryDetail> GetCategoryDetail(Expression<Func<Category, bool>> filter = null)
        {
            using (ClothesContext clothesContext = new ClothesContext())
            {
                IQueryable<CategoryDetail> categoryDetail = from c in filter is null ? clothesContext.Categories : clothesContext.Categories.Where(filter)
                                                            join i in clothesContext.CategoryImages
                                                            on c.CategoryId equals i.CategoryId
                                                            select new CategoryDetail
                                                            {
                                                                CategoryId = c.CategoryId,
                                                                CategoryName = c.CategoryName,
                                                                ImagePath = i.ImagePath,                                                               
                                                            };
                return categoryDetail.ToList();
            }
        }
    }
}
