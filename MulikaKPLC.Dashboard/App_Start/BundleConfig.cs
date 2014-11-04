using System.Web.Optimization;

namespace MulikaKPLC.Dashboard
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/morrischarts").Include(
                "~/Scripts/raphael.js",
                "~/Scripts/plugins/morris/morris.js"));

            bundles.Add(new ScriptBundle("~/bundles/sparkline").Include(
                "~/Scripts/plugins/sparkline/jquery.sparkline.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jvectormap").Include(
                "~/Scripts/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                "~/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new ScriptBundle("~/bundles/utilityplugins").Include(
                "~/Scripts/plugins/jqueryKnob/jquery.knob.js",
                "~/Scripts/plugins/daterangepicker/daterangepicker.js",
                "~/Scripts/plugins/datepicker/bootstrap-datepicker.js",
                "~/Scripts/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                "~/Scripts/plugins/iCheck/icheck.min.js"));

            bundles.Add(new StyleBundle("~/Content/jvectormap/css").Include(
                 "~/Content/jvectormap/jquery-jvectormap-1.2.2.css"));

            bundles.Add(new StyleBundle("~/Content/daterangepicker/css").Include(
                 "~/Content/daterangepicker/daterangepicker-bs3.css"));
            bundles.Add(new StyleBundle("~/Content/datepicker/css").Include(
                 "~/Content/datepicker/datepicker.css"));
            bundles.Add(new StyleBundle("~/Content/datatables/css").Include(
                "~/Content/datatables/datatables.bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap-wysihtml5/css").Include(
                "~/Content/bootstrap-wysihtml5/bootstrap3-wysihtml5.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap-slider/css").Include(
                "~/Content/bootstrap-slider/slider.css"));

            bundles.Add(new ScriptBundle("~/bundles/MulikaApp").Include(
                "~/Scripts/AdminLTE/app.js",
                "~/Scripts/AdminLTE/dashboard.js",
                "~/Scripts/AdminLTE/demo.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/Site.css"));

            //Kendo Css Bundles
            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/kendo/2014.2.1008/kendo.common.min.css",
                "~/Content/kendo/2014.2.1008/kendo.mobile.all.min.css",
                "~/Content/kendo/2014.2.1008/kendo.dataviz.min.css",
                "~/Content/kendo/2014.2.1008/kendo.bootstrap.min.css",
                "~/Content/kendo/2014.2.1008/kendo.dataviz.bootstrap.min.css"));
            //Kendo js Bundles
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/2014.2.1008/jquery.min.js",
                "~/Scripts/kendo/2014.2.1008/kendo.all.min.js",
                "~/Scripts/kendo/2014.2.1008/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/fontawesome/css").Include(
                "~/Content/font-awesome.css"));
            bundles.Add(new StyleBundle("~/Content/ionicons/css").Include(
                "~/Content/ionicons.css"
                ));
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
