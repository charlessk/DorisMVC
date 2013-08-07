using System.Web;
using System.Web.Optimization;

namespace Doris.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/doris").Include(
                        "~/Scripts/jquery-ui-{version}.js",                    
                        /*                    
                        "~/Scripts/jquery.ui.autocomplete.js",
                        "~/Scripts/jquery.ui.core.js.js",
                        "~/Scripts/jquery.ui.widget.js",
                        "~/Scripts/jquery.ui.button.js",     
                        "~/Scripts/jquery.ui.dialog.js",  
                        "~/Scripts/jquery.ui.mouse.js",*/
                        "~/Scripts/DorisScript.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/redmond/css").Include(
                        "~/Content/themes/redmond/jquery-ui.css",
                        "~/Content/themes/redmond/jquery.ui.all.css",
                         "~/Content/themes/redmond/jquery.ui.theme.css"
                        /*                   
                        "~/Content/themes/redmond/jquery.ui.accordion.css",                        
                        "~/Content/themes/redmond/jquery.ui.autocomplete.css",
                        "~/Content/themes/redmond/jquery.ui.base.css",
                        "~/Content/themes/redmond/jquery.ui.button.css",
                        "~/Content/themes/redmond/jquery.ui.core.css",
                        "~/Content/themes/redmond/jquery.ui.datepicker.css",
                        "~/Content/themes/redmond/jquery.ui.dialog.css",
                        "~/Content/themes/redmond/jquery.ui.menu.css",
                        "~/Content/themes/redmond/jquery.ui.progressbar.css",
                        "~/Content/themes/redmond/jquery.ui.resizable.css",
                        "~/Content/themes/redmond/jquery.ui.selectable.css",
                        "~/Content/themes/redmond/jquery.ui.slider.css",
                        "~/Content/themes/redmond/jquery.ui.spinner.css",
                        "~/Content/themes/redmond/jquery.ui.tabs.css",
                        "~/Content/themes/redmond/jquery.ui.tooltip.css"*/
                     ));
        }
    }
}