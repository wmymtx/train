using Abp.Web.Mvc.Views;

namespace RIA.Train.Web.Views
{
    public abstract class TrainWebViewPageBase : TrainWebViewPageBase<dynamic>
    {

    }

    public abstract class TrainWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TrainWebViewPageBase()
        {
            LocalizationSourceName = TrainConsts.LocalizationSourceName;
        }
    }
}