﻿Imports System.Web.Optimization

Public Module BundleConfig
    ' 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
        ' 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/respond.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css"))

        ' 将 EnableOptimizations 设为 false 以进行调试。有关详细信息，
        ' 请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        BundleTable.EnableOptimizations = True
    End Sub
End Module

