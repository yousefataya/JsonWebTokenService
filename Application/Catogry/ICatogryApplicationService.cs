using DotNetCore.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HRMS.Model;
using DotNetCore.Results;

namespace DotNetCoreArchitecture.Application
{
    public interface ICatogryApplicationService
    {
        Task<IDataResult<long>> AddAsync(CatogryModel itemModel);

        Task<string> ListAsync();

    }
}
