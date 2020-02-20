using DotNetCore.Objects;
using DotNetCoreArchitecture.Database;
using DotNetCoreArchitecture.Domain;
using HRMS.Model;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using DotNetCore.Results;

namespace DotNetCoreArchitecture.Application
{
    public class CatogryApplicationService : ICatogryApplicationService
    {
        public CatogryApplicationService(ICatogryRepository CatogryRepository, IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            this.CatogryRepository = CatogryRepository;
        }

        private IUnitOfWork UnitOfWork { get; }

        private ICatogryRepository CatogryRepository { get; }

        public async Task<IDataResult<long>> AddAsync(CatogryModel itemModel)
        {
            var validation = new CatogryAddValidator().Validate(itemModel);

            if (validation.Failed)
            {
                return DataResult<long>.Fail(validation.Message);
            }
            var CatogryItem = CatogryEntityFactory.Create(itemModel.Description);


            await CatogryRepository.AddAsync(CatogryItem);
            await UnitOfWork.SaveChangesAsync();

            return DataResult<long>.Success(1);
        }

        public async Task<string> ListAsync()
        {
            var items = await CatogryRepository.ListSync();
            return items;
        }

    }

}
