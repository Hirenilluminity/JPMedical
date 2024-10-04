using System.Web;
using System.Web.Optimization;

namespace JPMedical
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/jquery.min.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/owl.carousel.min.js",
                      "~/Scripts/js/progressbar.js",
                      "~/Scripts/js/isotope.pkgd.min.js",
                      "~/Scripts/js/jquery.countTo.min.js",
                      "~/Scripts/js/jquery.magnific-popup.min.js",
                      "~/Scripts/js/wow.min.js",
                      "~/Content/rev/js/rbtools.min.js",
                      "~/Content/rev/js/rs6.min.js",
                      "~/Scripts/js/rev-custom.js",
                      "~/Scripts/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/rev/fonts/pe-icon-7-stroke/css/pe-icon-7-stroke.css",
                      "~/Content/rev/fonts/font-awesome/css/font-awesome.css",
                      "~/Content/rev/css/rs6.css",
                      "~/Content/css/owl.carousel.min.css",
                      "~/Content/css/progressbar.css",
                      "~/Content/css/animations.min.css",
                      "~/Content/css/magnific-popup.min.css",
                      "~/Content/fonts/font-awesome/css/all.min.css",
                      "~/Content/fonts/flaticon/flaticon.css",
                      "~/Content/css/ionicons.min.css",
                      "~/Content/fonts/themify-icons/themify-icons.css",
                      "~/Content/css/style.css",
                      "~/Content/css/responsive.css"));
        }
    }
}
