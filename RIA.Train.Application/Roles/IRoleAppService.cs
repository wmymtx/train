using System.Threading.Tasks;
using Abp.Application.Services;
using RIA.Train.Roles.Dto;

namespace RIA.Train.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
