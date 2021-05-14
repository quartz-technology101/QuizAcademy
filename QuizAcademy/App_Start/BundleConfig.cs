using System.Web;
using System.Web.Optimization;

namespace QuizAcademy
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/toastr.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js"));


            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

          

           

            bundles.Add(new StyleBundle("~/Content/css").Include(                  
                      "~/Content/style.css",
                      "~/Content/navbar.css"));

            bundles.Add(new StyleBundle("~/content/csslib").Include(
                "~/Content/bootstrap.css",           
                "~/content/toastr.css",
                "~/content/datatables/css/datatables.bootstrap.css"));
        }
    }
}
