using System.Web;
using System.Web.Optimization;

namespace ToDoodle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/assets/js/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/assets/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/js/bootstrap.js",
                      "~/assets/js/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/assets/js/app.custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                      "~/assets/js/vue.min.js",
                      "~/assets/js/vue.schema.js",
                      "~/assets/js/vue.app.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/css/font-awesome.min.css",
                      "~/assets/css/bootstrap.css",
                      "~/assets/css/site.css"));
        }
    }
}
