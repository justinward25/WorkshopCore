#pragma checksum "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "585d9e3dbdfb9e57d3c6adc5f12fe88a848ca439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Index), @"mvc.1.0.view", @"/Views/Request/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Request/Index.cshtml", typeof(AspNetCore.Views_Request_Index))]
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
#line 1 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\_ViewImports.cshtml"
using WorkshopCore;

#line default
#line hidden
#line 2 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\_ViewImports.cshtml"
using WorkshopCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585d9e3dbdfb9e57d3c6adc5f12fe88a848ca439", @"/Views/Request/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c090e9d286e56d35d0fa29343295213c47af3ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkshopCore.Models.Request>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 22, true);
            WriteLiteral("\r\n<h2>Request</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
 using (Html.BeginForm("Create", "Request", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(172, 23, false);
#line 11 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(199, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(238, 24, false);
#line 14 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.Label("First Name"));

#line default
#line hidden
            EndContext();
            BeginContext(262, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(273, 74, false);
#line 15 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.TextBoxFor(model => model.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(347, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(400, 23, false);
#line 18 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.Label("Last Name"));

#line default
#line hidden
            EndContext();
            BeginContext(423, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(434, 73, false);
#line 19 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.TextBoxFor(model => model.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(507, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(560, 19, false);
#line 22 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.Label("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(579, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(590, 70, false);
#line 23 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(660, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(671, 47, false);
#line 24 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(718, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(771, 22, false);
#line 27 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.Label("Comments"));

#line default
#line hidden
            EndContext();
            BeginContext(793, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(804, 73, false);
#line 28 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.TextAreaFor(model => model.Comment, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(877, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(888, 49, false);
#line 29 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.ValidationMessageFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(937, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(990, 26, false);
#line 32 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.Label("Attach Files"));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1027, 89, false);
#line 33 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
   Write(Html.TextBoxFor(model => model.FilePath, new { @class = "form-control", @type = "file" }));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1132, 61, true);
            WriteLiteral("    <button class=\"btn btn-success\">Submit Request</button>\r\n");
            EndContext();
#line 37 "C:\Users\wjust\Documents\projects\WorkshopCore\WorkshopCore\Views\Request\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1196, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkshopCore.Models.Request> Html { get; private set; }
    }
}
#pragma warning restore 1591
