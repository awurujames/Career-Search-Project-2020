#pragma checksum "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16d499eee0a2f7046b750887c7ab47606282c2a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_JobInformations_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/JobInformations/Index.cshtml")]
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
#line 1 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\_ViewImports.cshtml"
using Career_Search_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\_ViewImports.cshtml"
using Career_Search_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\_ViewImports.cshtml"
using Career_Search_Project.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\_ViewImports.cshtml"
using Career_Search_Project.Areas.Admin.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16d499eee0a2f7046b750887c7ab47606282c2a3", @"/Areas/Admin/Views/JobInformations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e17e1345f7a9ebf2a0b36c8e86ed5e8bfbe44a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_JobInformations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Career_Search_Project.Areas.Admin.Models.JobInformation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Job Information</h3>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d499eee0a2f7046b750887c7ab47606282c2a35757", async() => {
                WriteLiteral("Add Job Info");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FunctionalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgeLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsOfExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Requirements));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Responsibility));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Renumeration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Industry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 58 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FunctionalArea.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgeLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsOfExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Requirements));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Responsibility));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Renumeration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Industry.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d499eee0a2f7046b750887c7ab47606282c2a317046", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d499eee0a2f7046b750887c7ab47606282c2a319261", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d499eee0a2f7046b750887c7ab47606282c2a321482", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 105 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Areas\Admin\Views\JobInformations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Career_Search_Project.Areas.Admin.Models.JobInformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591