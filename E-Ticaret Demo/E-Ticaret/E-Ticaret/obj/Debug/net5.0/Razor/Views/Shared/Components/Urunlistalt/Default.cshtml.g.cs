#pragma checksum "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1858dfc7ce7db8e63e642faca7f98003cec480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Urunlistalt_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Urunlistalt/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1858dfc7ce7db8e63e642faca7f98003cec480", @"/Views/Shared/Components/Urunlistalt/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b90afa22f2d39f49481c4d82148e4f59b3a190", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Urunlistalt_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ETicaretDB.DTO.UrunListDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml"
 foreach (var item in Model)
{




#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- product -->\n                    <div class=\"product\">\n                        <div class=\"product-img\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ae1858dfc7ce7db8e63e642faca7f98003cec4803970", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 245, "~/", 245, 2, true);
#nullable restore
#line 11 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml"
AddHtmlAttributeValue("", 247, item.KucukYol, 247, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""product-label"">
                                <span class=""sale"">-30%</span>
                                <span class=""new"">Yeni</span>
                            </div>
                        </div>
                        <div class=""product-body"">
                            <p class=""product-category"">");
#nullable restore
#line 18 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml"
                                                   Write(item.KategoriAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <h3 class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 19 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml"
                                                            Write(item.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                            <h4 class=\"product-price\">");
#nullable restore
#line 20 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml"
                                                 Write(item.SatisFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<del class=""product-old-price"">$990.00</del></h4>
                            <div class=""product-rating"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                            </div>
                            <div class=""product-btns"">
                                <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">Favorilere Ekle</span></button>
                                <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">Karşılaştır</span></button>
                                <a class=""fa fa-eye"" alt=""Hızlı Bakış""");
            BeginWriteAttribute("href", " href=\"", 1655, "\"", 1686, 2);
            WriteAttributeValue("", 1662, "/Urun/Index/", 1662, 12, true);
#nullable restore
#line 31 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml"
WriteAttributeValue("", 1674, item.UrunId, 1674, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></a>

                            </div>
                        </div>
                        <div class=""add-to-cart"">
                            <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i>Sepete Ekle</button>
                        </div>
                    </div>
                    <!-- /product -->
                    <!-- product -->
");
            WriteLiteral("                    <!-- /product -->\n                    <!-- product -->\n");
            WriteLiteral("                    <!-- /product -->\n                    <!-- product -->\n");
            WriteLiteral("                    <!-- /product -->\n                    <!-- product -->\n");
            WriteLiteral("                    <!-- /product -->\n");
#nullable restore
#line 52 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Shared\Components\Urunlistalt\Default.cshtml"
            
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