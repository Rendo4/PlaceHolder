#pragma checksum "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fed1f8a6501323bca92e8f295124605c35a9eaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 1 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\_ViewImports.cshtml"
using DottiesApothecary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\_ViewImports.cshtml"
using DottiesApothecary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
using DottiesApothecary.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fed1f8a6501323bca92e8f295124605c35a9eaa", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cc25d0bbdcffea8474e516e87492bcfdc1eafe", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Register a new user</h2>\r\n<hr />\r\n");
#nullable restore
#line 11 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Register\" />\r\n");
#nullable restore
#line 23 "C:\Users\maste\documents\DottiesApothecarry.Solution\DottiesApothecary\Views\Account\Register.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591