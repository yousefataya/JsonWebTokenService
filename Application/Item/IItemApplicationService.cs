using DotNetCore.Objects;
using DotNetCore.Results;
using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Application
{
    public interface IItemApplicationService
    {
        Task<IDataResult<long>> AddAsync(ItemModel itemModel);

        Task<string> ListAsync();

        Task<ItemModel> FindBySync(Guid id);

        Task<IDataResult<long>> UpdateAsync(ItemModel itemModel, Guid id);
    }
}
