using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClothesSizeService
    {
        IResult Add(ClothesSize size);
        IResult Delete(ClothesSize size);
        IResult Update(ClothesSize size);
        IDataResult<List<ClothesSize>> GetAll();
    }
}
