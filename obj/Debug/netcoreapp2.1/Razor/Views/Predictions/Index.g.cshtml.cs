#pragma checksum "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b77b519ce26155df70c9e677978ca537473a294c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Predictions_Index), @"mvc.1.0.view", @"/Views/Predictions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Predictions/Index.cshtml", typeof(AspNetCore.Views_Predictions_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77b519ce26155df70c9e677978ca537473a294c", @"/Views/Predictions/Index.cshtml")]
    public class Views_Predictions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP.NET_Tesis.Prediction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 932, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
    Predictions
    </h1>
    <ol class=""breadcrumb"">
    <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
    <li class=""active"">Predictions</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box"">
        <div class=""box-header"">
            <h3 class=""box-title"">Today's Predictions</h3>
        </div>
        <!-- /.box-header -->
        <div class=""box-body"">
            <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
            <tr>
                <th>Id</th>
                <th>CompanyName</th>
                <th>CurrentPrice</th>
                <th>PredictedPrice</th>
                <th>Suggestion</th>
                <th>Accuracy</th>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 33 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1043, 50, true);
            WriteLiteral("                    <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1094, 37, false);
#line 36 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1163, 46, false);
#line 37 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1241, 47, false);
#line 38 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CurrentPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1320, 49, false);
#line 39 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PredictedPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1401, 45, false);
#line 40 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Suggestion));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1478, 43, false);
#line 41 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Accuracy));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 43 "c:\Users\brome\Documents\Proyecto Tesis\FrontApp Tesis\Views\Predictions\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1574, 209, true);
            WriteLiteral("            </table>\r\n        </div>\r\n        <!-- /.box-body -->\r\n        </div>\r\n        <!-- /.box -->\r\n    </div>\r\n    <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n   \r\n<!-- DataTables -->\r\n");
            EndContext();
            BeginContext(1783, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85b3db9673ef4ffa829be073aecc02f7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1868, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1870, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645a60f13caf4ce38d79988c17073c9d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1961, 110, true);
            WriteLiteral("\r\n<!-- page script -->\r\n<script>\r\n    $(function () {\r\n        $(\'#example1\').DataTable();\r\n    });\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP.NET_Tesis.Prediction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
