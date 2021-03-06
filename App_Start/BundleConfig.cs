﻿using System.Web;
using System.Web.Optimization;

namespace NominasSAT
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, consulte http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/admin").Include(
                        "~/assets/js/jquery-ui-1.10.3.min.js", "~/assets/js/AdminLTE/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                        "~/Scripts/messages.js", "~/Scripts/common.js"));

            bundles.Add(new ScriptBundle("~/bundles/nomina").Include(
                        "~/Scripts/nomina.js" ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*", "~/Scripts/plugins/datatables/jquery.dataTables.min.js", "~/Scripts/jquery.resizableColumns.min.js", "~/Scripts/bootstrap-datepicker.js"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js", "~/Scripts/bootbox.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/Content/jquery.resizableColumns.css", "~/Content/datepicker.css"));
        }
    }
}
