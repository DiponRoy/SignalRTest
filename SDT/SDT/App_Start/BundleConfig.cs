using System.Web;
using System.Web.Optimization;

namespace SDT
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css",
                "~/Content/toastr.css",
                "~/Content/App/site.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/js/core").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.signalR-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootbox.js",
                "~/Scripts/toastr.js",
                "~/Scripts/spin.js",
                "~/Scripts/amplify.js",
                "~/Scripts/underscore.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/js/ko").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js",
                "~/Scripts/knockout.mapping-latest.js",
                "~/Scripts/knockout.activity.js",
                "~/Scripts/knockout.command.js",
                "~/Scripts/knockout.dirtyFlag.js",
                "~/Scripts/TrafficCop.js",
                "~/Scripts/infuser.js",
                "~/Scripts/koExternalTemplateEngine.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/js/requirejs").Include(
                "~/Scripts/require.js",
                "~/Scripts/App/config.requirejs.js"
                ));
        }
    }
}