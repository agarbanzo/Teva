using System.Web;
using System.Web.Optimization;

namespace VOCE_TEVA_Asthma_Single_Page_Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/main.css"));
            bundles.Add(new ScriptBundle("~/bundles/tevashared").Include(
                "~/Scripts/ga.js",
                "~/Scripts/vendor.js",
                "~/Scripts/main.js"));
        }
    }
}
