#pragma checksum "C:\Users\Erick Cano\paginaweb\firstAPP\Views\personal\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced6290b18fa9c49a82eef158e5dc0db75ff8bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_personal_index), @"mvc.1.0.view", @"/Views/personal/index.cshtml")]
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
#line 1 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\_ViewImports.cshtml"
using firstAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\_ViewImports.cshtml"
using firstAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced6290b18fa9c49a82eef158e5dc0db75ff8bb8", @"/Views/personal/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d29ed7d91974d35dd90dce9c72af2891f6e46c", @"/Views/_ViewImports.cshtml")]
    public class Views_personal_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<personal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>pagina personal</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\personal\index.cshtml"
Write(Html.LabelFor(m=>m.name, "Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 5 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\personal\index.cshtml"
                              Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
#nullable restore
#line 7 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\personal\index.cshtml"
Write(Html.LabelFor(m=>m.lastname, "Lastname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 7 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\personal\index.cshtml"
                                      Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n\r\n");
#nullable restore
#line 9 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\personal\index.cshtml"
Write(Html.LabelFor(m=>m.age, "Age"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\Erick Cano\paginaweb\firstAPP\Views\personal\index.cshtml"
                            Write(Model.age);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
