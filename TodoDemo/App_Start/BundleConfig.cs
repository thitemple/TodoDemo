using System.Web;
using System.Web.Optimization;

namespace TodoDemo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery.form").Include(
                "~/Scripts/jquery.form.js",
                "~/Scripts/toastr.js",
                "~/Scripts/jquery.loadmask.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css", 
                "~/Content/toastr.css",
                "~/Content/jquery.loadmask.css"));
        }
    }
}