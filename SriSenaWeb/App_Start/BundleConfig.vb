Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
    ' For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/scripts/master").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/jquery-ui-{version}.js",
                    "~/Scripts/dojo.js",
                    "~/Scripts/MenuTopNav.js",
                    "~/Scripts/MenuMaster.js",
                    "~/Scripts/MenuDropdown.js"))

        bundles.Add(New StyleBundle("~/style/master").Include(
                    "~/Content/Site.css",
                    "~/Content/Content.css"))
    End Sub
End Class