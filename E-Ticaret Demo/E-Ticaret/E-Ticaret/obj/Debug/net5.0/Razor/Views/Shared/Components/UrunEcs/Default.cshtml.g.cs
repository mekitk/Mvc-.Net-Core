#pragma checksum "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\UrunEcs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b839119994aa501db750a9fe265673664fc703f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UrunEcs_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UrunEcs/Default.cshtml")]
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
#line 1 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\_ViewImports.cshtml"
using E_Ticaret;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\_ViewImports.cshtml"
using E_Ticaret.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b839119994aa501db750a9fe265673664fc703f", @"/Views/Shared/Components/UrunEcs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b90afa22f2d39f49481c4d82148e4f59b3a190", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UrunEcs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ETicaretDB.DTO.UrunListDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AnaTasarim/img/product07.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Products tab & slick -->\r\n\r\n");
#nullable restore
#line 4 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\UrunEcs\Default.cshtml"
 foreach (var item in Model)
{







            

                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- product widget -->\r\n                        <div class=\"product-widget\">\r\n                            <div class=\"product-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4b839119994aa501db750a9fe265673664fc703f4432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"product-body\">\r\n                                <p class=\"product-category\">");
#nullable restore
#line 22 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\UrunEcs\Default.cshtml"
                                                       Write(item.KategoriAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <h3 class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 23 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\UrunEcs\Default.cshtml"
                                                                Write(item.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
                            </div>
                        </div>
                        <!-- /product widget -->
                        <!-- product widget -->
");
#nullable restore
#line 29 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\UrunEcs\Default.cshtml"
                        
              
            

          

           

      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ETicaretDB.DTO.UrunListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
