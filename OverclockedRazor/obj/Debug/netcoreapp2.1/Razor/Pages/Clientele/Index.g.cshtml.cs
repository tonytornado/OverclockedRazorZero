#pragma checksum "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59cc1175bd7725c2c4eef81ef6455c70b1f445e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OverclockedRazor.Pages.Clientele.Pages_Clientele_Index), @"mvc.1.0.razor-page", @"/Pages/Clientele/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Clientele/Index.cshtml", typeof(OverclockedRazor.Pages.Clientele.Pages_Clientele_Index), null)]
namespace OverclockedRazor.Pages.Clientele
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\_ViewImports.cshtml"
using OverclockedRazor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59cc1175bd7725c2c4eef81ef6455c70b1f445e0", @"/Pages/Clientele/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0548cc906f2423a6dd5f621ea1f01e22793c4a29", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientele_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f92d4aecde8440bb269af582d826df6", async() => {
                BeginContext(152, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(166, 100, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(267, 55, false);
#line 17 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(322, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(390, 54, false);
#line 20 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].LastName));

#line default
#line hidden
            EndContext();
            BeginContext(444, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(512, 51, false);
#line 23 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Email));

#line default
#line hidden
            EndContext();
            BeginContext(563, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(631, 49, false);
#line 26 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].DOB));

#line default
#line hidden
            EndContext();
            BeginContext(680, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(748, 50, false);
#line 29 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].BSex));

#line default
#line hidden
            EndContext();
            BeginContext(798, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(866, 52, false);
#line 32 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Height));

#line default
#line hidden
            EndContext();
            BeginContext(918, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(986, 52, false);
#line 35 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1106, 51, false);
#line 38 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Chest));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1225, 51, false);
#line 41 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Waist));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1344, 49, false);
#line 44 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Hip));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1461, 50, false);
#line 47 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Neck));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1579, 53, false);
#line 50 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Forearm));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1700, 52, false);
#line 53 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Tricep));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1820, 51, false);
#line 56 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Bicep));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1939, 51, false);
#line 59 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Thigh));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2058, 50, false);
#line 62 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Client[0].Calf));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 90, true);
            WriteLiteral("\r\n                </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 68 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
 foreach (var item in Model.Client) {

#line default
#line hidden
            BeginContext(2237, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2286, 44, false);
#line 71 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2330, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2386, 43, false);
#line 74 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2485, 40, false);
#line 77 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2525, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2581, 38, false);
#line 80 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(2619, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2675, 39, false);
#line 83 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BSex));

#line default
#line hidden
            EndContext();
            BeginContext(2714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2770, 41, false);
#line 86 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Height));

#line default
#line hidden
            EndContext();
            BeginContext(2811, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2867, 41, false);
#line 89 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(2908, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2964, 40, false);
#line 92 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Chest));

#line default
#line hidden
            EndContext();
            BeginContext(3004, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3060, 40, false);
#line 95 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Waist));

#line default
#line hidden
            EndContext();
            BeginContext(3100, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3156, 38, false);
#line 98 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hip));

#line default
#line hidden
            EndContext();
            BeginContext(3194, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3250, 39, false);
#line 101 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Neck));

#line default
#line hidden
            EndContext();
            BeginContext(3289, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3345, 42, false);
#line 104 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Forearm));

#line default
#line hidden
            EndContext();
            BeginContext(3387, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3443, 41, false);
#line 107 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tricep));

#line default
#line hidden
            EndContext();
            BeginContext(3484, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3540, 40, false);
#line 110 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bicep));

#line default
#line hidden
            EndContext();
            BeginContext(3580, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3636, 40, false);
#line 113 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Thigh));

#line default
#line hidden
            EndContext();
            BeginContext(3676, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3732, 39, false);
#line 116 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Calf));

#line default
#line hidden
            EndContext();
            BeginContext(3771, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3826, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c81e85b8bdb44ea8b03ba75aa89ea67f", async() => {
                BeginContext(3871, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
                                       WriteLiteral(item.ID);

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
            BeginContext(3879, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3899, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "785b65d3f837405f9ca28956d5bd2a9e", async() => {
                BeginContext(3947, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
                                          WriteLiteral(item.ID);

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
            BeginContext(3958, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3978, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1beec70d2f74a43a141297d0cfc193c", async() => {
                BeginContext(4025, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 121 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
                                         WriteLiteral(item.ID);

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
            BeginContext(4035, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 124 "C:\Users\TonyT\Documents\GitHub\OverclockedRazorZero\OverclockedRazor\Pages\Clientele\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4074, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OverclockedRazor.Pages.Clientele.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OverclockedRazor.Pages.Clientele.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OverclockedRazor.Pages.Clientele.IndexModel>)PageContext?.ViewData;
        public OverclockedRazor.Pages.Clientele.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
