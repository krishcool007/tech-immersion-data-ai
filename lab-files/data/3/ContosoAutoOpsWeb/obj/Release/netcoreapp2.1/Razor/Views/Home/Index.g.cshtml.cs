#pragma checksum "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91ab4279fff24bc9138106cc8f1768f5daec483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\_ViewImports.cshtml"
using ContosoAutoOpsWeb;

#line default
#line hidden
#line 2 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\_ViewImports.cshtml"
using ContosoAutoOpsWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91ab4279fff24bc9138106cc8f1768f5daec483", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ca36d78f57ac136547ee8a35d532fb03b7b5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoAutoOpsWeb.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "ContosoAuto - Products";

#line default
#line hidden
            BeginContext(109, 193, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <h2>Products</h2>\n        <table class=\"table\">\n            <thead>\n                <tr>\n                    <th>\n                        ");
            EndContext();
            BeginContext(303, 40, false);
#line 14 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(343, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(420, 49, false);
#line 17 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProductNumber));

#line default
#line hidden
            EndContext();
            BeginContext(469, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(546, 41, false);
#line 20 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(587, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(664, 52, false);
#line 23 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SafetyStockLevel));

#line default
#line hidden
            EndContext();
            BeginContext(716, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(793, 48, false);
#line 26 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ReorderPoint));

#line default
#line hidden
            EndContext();
            BeginContext(841, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(918, 48, false);
#line 29 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.StandardCost));

#line default
#line hidden
            EndContext();
            BeginContext(966, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1043, 45, false);
#line 32 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ListPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 120, true);
            WriteLiteral("\n                    </th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 38 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1271, 82, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1354, 39, false);
#line 42 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1482, 48, false);
#line 45 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1619, 40, false);
#line 48 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1748, 51, false);
#line 51 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SafetyStockLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1888, 47, false);
#line 54 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ReorderPoint));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2024, 47, false);
#line 57 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StandardCost));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2160, 44, false);
#line 60 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ListPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2292, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f923cacb81c14f59875799934a24cb5c", async() => {
                BeginContext(2354, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                                                             WriteLiteral(item.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2365, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 66 "Y:\tech-immersion-data-ai\lab-files\data\3\ContosoAutoOpsWeb\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2440, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoAutoOpsWeb.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
