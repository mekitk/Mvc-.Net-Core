#pragma checksum "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e16f55b1a381b9ba78fabbb9f67653debeb686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urunfiltreleme_Search), @"mvc.1.0.view", @"/Views/Urunfiltreleme/Search.cshtml")]
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
#nullable restore
#line 3 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e16f55b1a381b9ba78fabbb9f67653debeb686", @"/Views/Urunfiltreleme/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b90afa22f2d39f49481c4d82148e4f59b3a190", @"/Views/_ViewImports.cshtml")]
    public class Views_Urunfiltreleme_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<ETicaretDB.DTO.UrunListDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-to-cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
  
    ViewData["Title"] = "Arama";
    Layout = "~/Views/Shared/KategoriLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <!-- product -->\r\n");
#nullable restore
#line 14 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
     foreach (var urun in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4 col-xs-6\">\r\n            <div class=\"product\">\r\n                <div class=\"product-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "53e16f55b1a381b9ba78fabbb9f67653debeb6865710", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 432, "~/", 432, 2, true);
#nullable restore
#line 19 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
AddHtmlAttributeValue("", 434, urun.KucukYol, 434, 14, false);

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
                        <span class=""new"">NEW</span>
                    </div>
                </div>
                <div class=""product-body"">
                    <p class=""product-category"">");
#nullable restore
#line 26 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
                                           Write(urun.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h3 class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 27 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
                                                    Write(urun.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                    <h6 class=\"product-price\">");
#nullable restore
#line 28 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
                                         Write(urun.Ozellikler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h4 class=\"product-price\">");
#nullable restore
#line 29 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
                                         Write(urun.SatisFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<del class=""product-old-price"">4000</del></h4>

                    <div class=""product-rating"">
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                    </div>
                    <div class=""product-btns"">
                        <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                        <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                        <a class=""fa fa-eye""");
            BeginWriteAttribute("href", " href=\"", 1751, "\"", 1782, 2);
            WriteAttributeValue("", 1758, "/Urun/Index/", 1758, 12, true);
#nullable restore
#line 41 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
WriteAttributeValue("", 1770, urun.UrunId, 1770, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"add-to-cart\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e16f55b1a381b9ba78fabbb9f67653debeb68610175", async() => {
                WriteLiteral("<i class=\"fa fa-shopping-cart\"></i> sepete ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
                                                                WriteLiteral(urun.UrunId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- /product -->\r\n</div>\r\n");
#nullable restore
#line 53 "C:\Users\M3ki\source\repos\E-Ticaret\E-Ticaret\Views\Urunfiltreleme\Search.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<ETicaretDB.DTO.UrunListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
