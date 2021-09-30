using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        User GetByMail(string email);
        IDataResult<List<OperationClaim>> GetClaims(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult UpdateUser(UserDetailDto user);
        IDataResult<List<User>> GetAll();
    }
}
