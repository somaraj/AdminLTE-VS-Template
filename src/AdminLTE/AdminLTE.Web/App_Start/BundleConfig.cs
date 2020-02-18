using System.Web;
using System.Web.Optimization;

namespace AdminLTE.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/plugins/jquery/jquery.js",
                        "~/plugins/bootstrap/js/bootstrap.bundle.js",
                        "~/scripts/adminlte.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/plugins/fontawesome-free/css/all.css",
                      "~/Content/css/adminlte.css"));
        }
    }
}
