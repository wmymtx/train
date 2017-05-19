using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using RIA.Train.Authorization;
using RIA.Train.MultiTenancy;

namespace RIA.Train.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : TrainControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}