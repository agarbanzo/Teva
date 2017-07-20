using System.Web;
using System.Web.Mvc;

namespace VOCE_TEVA_Asthma_Single_Page_Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
