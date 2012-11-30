﻿using System.Web;
using System.Web.Optimization;

namespace ConferenceManagement.Api
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/backbone").Include(
                       "~/Scripts/underscore.js", "~/Scripts/backbone.js", "~/Scripts/handlebar.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

           

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css","~/Content/bootstrap-responsive.css","~/Content/site.css"));

        }
    }
}