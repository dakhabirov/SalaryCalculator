#pragma checksum "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dc5a3a80a2f2333c033e769cb9e423cb9f90bfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salaries_Show), @"mvc.1.0.view", @"/Views/Salaries/Show.cshtml")]
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
#nullable restore
#line 1 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\_ViewImports.cshtml"
using SalaryCalc.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\_ViewImports.cshtml"
using SalaryCalc.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\_ViewImports.cshtml"
using SalaryCalc.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\_ViewImports.cshtml"
using SalaryCalc.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc5a3a80a2f2333c033e769cb9e423cb9f90bfa", @"/Views/Salaries/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f41c1ccdcfc522bb38ce9c32275f44150e3757a", @"/Views/_ViewImports.cshtml")]
    public class Views_Salaries_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Salary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n<div class=\"container text-center mt-4 mb-4\">\n    <div class=\"section-title mt-3 mb-3\">\n        <h3>Заработная плата за ");
#nullable restore
#line 5 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml"
                           Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" месяц ");
#nullable restore
#line 5 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml"
                                              Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" год</h3>\n        <h4><label style=\"font-weight: bold\">");
#nullable restore
#line 6 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml"
                                        Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> рублей</h4>\n    </div>\n</div>\n<div class=\"mb-5 list-group\">\n    <h5>Продажи</h5>\n");
#nullable restore
#line 11 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml"
     foreach (Sale sale in ViewBag.Sales)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dc5a3a80a2f2333c033e769cb9e423cb9f90bfa5775", async() => {
#nullable restore
#line 13 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml"
                                                                                                                       Write(sale.DateAdded);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml"
                                                                                                      WriteLiteral(sale.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 14 "C:\Users\dakha\source\repos\SaleMonitoring\SaleMonitoring\Views\Salaries\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salary> Html { get; private set; }
    }
}
#pragma warning restore 1591
