#pragma checksum "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\Components\Cart\Huge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea315e69592c22b05d204e9c7ed364df0ae5b0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Components.Cart.Pages_Components_Cart_Huge), @"mvc.1.0.view", @"/Pages/Components/Cart/Huge.cshtml")]
namespace Shop.UI.Pages.Components.Cart
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
#line 1 "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\_ViewImports.cshtml"
using Shop.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea315e69592c22b05d204e9c7ed364df0ae5b0f", @"/Pages/Components/Cart/Huge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ab2ef2d163a6251af152bfc9b3c7e0d527a978", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_Cart_Huge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Application.Cart.GetCart.Response>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <h2> Huge Cart </h2>\r\n");
#nullable restore
#line 9 "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\Components\Cart\Huge.cshtml"
     foreach (var product in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 12 "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\Components\Cart\Huge.cshtml"
      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 13 "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\Components\Cart\Huge.cshtml"
      Write(product.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\Components\Cart\Huge.cshtml"
      Write(product.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 15 "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\Components\Cart\Huge.cshtml"
      Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <hr />\r\n");
#nullable restore
#line 17 "C:\Users\ACER\source\repos\Shop\Shop.UI\Pages\Components\Cart\Huge.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Application.Cart.GetCart.Response>> Html { get; private set; }
    }
}
#pragma warning restore 1591
