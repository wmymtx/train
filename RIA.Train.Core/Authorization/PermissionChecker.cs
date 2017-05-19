using Abp.Authorization;
using RIA.Train.Authorization.Roles;
using RIA.Train.MultiTenancy;
using RIA.Train.Users;

namespace RIA.Train.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
