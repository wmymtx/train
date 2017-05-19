using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RIA.Train.MultiTenancy.Dto;

namespace RIA.Train.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
