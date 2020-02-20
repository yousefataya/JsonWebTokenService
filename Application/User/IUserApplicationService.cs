using DotNetCore.Objects;
using DotNetCore.Results;
using HRMS.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Application
{
    public interface IUserApplicationService
    {
        Task<IDataResult<long>> AddAsync(AddUserModel addUserModel);

        Task<IDataResult<long>> DeleteAsync(long userId);

        Task InactivateAsync(long userId);

        Task<PagedList<UserModel>> ListAsync(PagedListParameters parameters);

        Task<IEnumerable<UserModel>> ListAsync();

        Task<UserModel> SelectAsync(long userId);

        Task<IDataResult<TokenModel>> SignInAsync(SignInModel signInModel);

        Task SignOutAsync(SignOutModel signOutModel);

        Task<IResult> UpdateAsync(UpdateUserModel updateUserModel);
    }
}
