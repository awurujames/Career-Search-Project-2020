#pragma checksum "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b89393357ed80b6208fb90f7cff9f54920053961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllJobSeeker), @"mvc.1.0.view", @"/Views/Home/AllJobSeeker.cshtml")]
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
#line 1 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\_ViewImports.cshtml"
using Career_Search_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\_ViewImports.cshtml"
using Career_Search_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\_ViewImports.cshtml"
using Career_Search_Project.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89393357ed80b6208fb90f7cff9f54920053961", @"/Views/Home/AllJobSeeker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f421dc7db76e6afa377eaec6ebbb0af7608b7e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllJobSeeker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobSeeker>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
  
    ViewData["Title"] = "All Jobs";
    Layout = "_Layout3";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""inner-banner"" style=""backend:#242c36 url(https://via.placeholder.com/1920x600)no-repeat;"">
    <div class=""container"">
        <div class=""caption"">
            <h2>Get your jobs</h2>
            <p>Get your Popular jobs <span>202 New job</span></p>
        </div>
    </div>
</section>

<section class=""jobs"">
    <div class=""container"">
        <div class=""row heading"">
            <h2>Find Popular Jobs</h2>
            <p>Your Easy Way Of Getting Jobs</p>
        </div>
        <div class=""companies"">
            <div class=""company-list"">
                <div class=""row"">
                    <div class=""col-md-2 col-sm-2"">
                        <div class=""company-logo"">
                            <img src=""img/google.png"" class=""img-responsive""");
            BeginWriteAttribute("alt", " alt=\"", 899, "\"", 905, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-10 col-sm-10\">\r\n                        <div class=\"company-content\">\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"company-list\">\r\n");
#nullable restore
#line 40 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-md-2 col-sm-2\">\r\n                            <div class=\"company-logo\">\r\n                                <img src=\"img/microsoft.png\" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 1919, "\"", 1925, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-10 col-sm-10\">\r\n                            <div class=\"company-content\">\r\n                                <h3>");
#nullable restore
#line 51 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"part-time\">");
#nullable restore
#line 51 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
                                                                 Write(item.Qualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                <p><span class=\"company-name\"><i class=\"fa fa-briefcase\"></i>");
#nullable restore
#line 52 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
                                                                                        Write(item.Skills);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"company-location\"><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 52 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
                                                                                                                                                                          Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"package\"><i class=\"fa fa-money\"></i>");
#nullable restore
#line 52 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
                                                                                                                                                                                                                                              Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 56 "C:\CodebitAcademyFolder\ASP.NET Core\Career Search Project\Career Search Project\Views\Home\AllJobSeeker.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"company-list\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-2 col-sm-2\">\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"col-md-10 col-sm-10\">\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"company-list\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-2 col-sm-2\">\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"col-md-10 col-sm-10\">\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"company-list\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-2 col-sm-2\">\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"col-md-10 col-sm-10\">\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <input type=\"button\" class=\"btn brows-btn\" value=\"Brows All Jobs\" />\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobSeeker>> Html { get; private set; }
    }
}
#pragma warning restore 1591
