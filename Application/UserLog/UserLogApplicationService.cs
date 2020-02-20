using DotNetCoreArchitecture.Database;
using DotNetCoreArchitecture.Domain;
using HRMS.Model;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Application
{
    public sealed class UserLogApplicationService : IUserLogApplicationService
    {
        public UserLogApplicationService(IUserLogRepository userLogRepository)
        {
            UserLogRepository = userLogRepository;
        }

        private IUserLogRepository UserLogRepository { get; }

        public async Task AddAsync(UserLogModel userLogModel)
        {
            var userLogEntity = UserLogEntityFactory.Create(userLogModel);

            await UserLogRepository.AddAsync(userLogEntity);
        }
    }
}
