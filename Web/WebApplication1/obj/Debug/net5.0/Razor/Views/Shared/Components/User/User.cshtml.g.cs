#pragma checksum "D:\Coding\C#\Web\WebApplication1\Views\Shared\Components\User\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1709911bcf51461b00363252b2dc0569cbdf12b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_User_User), @"mvc.1.0.view", @"/Views/Shared/Components/User/User.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1709911bcf51461b00363252b2dc0569cbdf12b9", @"/Views/Shared/Components/User/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3281d7acb4dd7f2af62139ba297faf35e8720c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_User_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModel.Person>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\C#\Web\WebApplication1\Views\Shared\Components\User\User.cshtml"
 if (Model.IsLoggedIn) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>Welcome: ");
#nullable restore
#line 3 "D:\Coding\C#\Web\WebApplication1\Views\Shared\Components\User\User.cshtml"
           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 4 "D:\Coding\C#\Web\WebApplication1\Views\Shared\Components\User\User.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>Please, log in</p>\r\n");
#nullable restore
#line 7 "D:\Coding\C#\Web\WebApplication1\Views\Shared\Components\User\User.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModel.Person> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591