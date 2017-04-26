using System.Collections.Generic;
using System.Web.Optimization;

namespace TestBundle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            /*
             * See this part of code for the sample. Here's what you can do.
            */

            var jqueryList = new List<string>
            {
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate*"
            };

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include(jqueryList.ToArray())
                .Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"));

            //This is another sample 
            bundles.Add(new ScriptBundle("~/testscrip1")
                .Include(jqueryList.ToArray())
                .Include("~/Scripts/testscrip1.js"));

            //This third sample

            bundles.Add(new ScriptBundle("~/testscrip2")
              .Include(jqueryList.ToArray())
              .Include("~/Scripts/testscrip1.js"));

        }
    }
}
