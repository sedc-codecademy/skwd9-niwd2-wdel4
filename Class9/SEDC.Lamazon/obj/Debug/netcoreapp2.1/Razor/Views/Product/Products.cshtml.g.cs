#pragma checksum "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc68f71977e30f0a4a4546e9959614279946bc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Products), @"mvc.1.0.view", @"/Views/Product/Products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Products.cshtml", typeof(AspNetCore.Views_Product_Products))]
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
#line 1 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\_ViewImports.cshtml"
using SEDC.Lamazon;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\_ViewImports.cshtml"
using SEDC.Lamazon.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc68f71977e30f0a4a4546e9959614279946bc2", @"/Views/Product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40fe909bafb5d24d51dfc8611fa622b1aeb256b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(31, 49, true);
            WriteLiteral("\r\n\r\n<h1>Products</h1>\r\n\r\n<div class=\"products\">\r\n");
            EndContext();
#line 7 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(124, 45, true);
            WriteLiteral("        <div class=\"thumbnail\">\r\n            ");
            EndContext();
            BeginContext(169, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3704a4791e34d4694354d88f5dc384e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 201, "~/images/Products/product-", 201, 26, true);
#line 10 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml"
AddHtmlAttributeValue("", 227, product.Id, 227, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 240, ".png", 240, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(248, 57, true);
            WriteLiteral("\r\n            <div class=\"caption\">\r\n                <h3>");
            EndContext();
            BeginContext(306, 12, false);
#line 12 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(318, 27, true);
            WriteLiteral("</h3>\r\n                <h4>");
            EndContext();
            BeginContext(346, 19, false);
#line 13 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml"
               Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(365, 27, true);
            WriteLiteral("</h4>\r\n                <h5>");
            EndContext();
            BeginContext(393, 13, false);
#line 14 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml"
               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(406, 57, true);
            WriteLiteral(" $</h5>\r\n                <p>\r\n                    <button");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 463, "\"", 482, 1);
#line 16 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml"
WriteAttributeValue("", 471, product.Id, 471, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(483, 116, true);
            WriteLiteral(" class=\"btn btn-primary productItem\">Add to cart</button>\r\n                </p>\r\n            </div>\r\n       </div>\r\n");
            EndContext();
#line 20 "C:\Users\User\Desktop\Class9Wed\SEDC.Lamazon\Views\Product\Products.cshtml"
     }

#line default
#line hidden
            BeginContext(607, 700, true);
            WriteLiteral(@"</div>

<script type=""text/javascript"">

    let products = document.getElementsByClassName(""products"")[0];
    products.addEventListener('click', function (e) {
        e.stopPropagation();
        let target = e.target;

        let targetId = target.classList.contains('productItem') ? target.value : null;

        if (targetId != null) {
            addToCart(targetId);
        }
    });

    function addToCart(targetId) {
        fetch(""/Order/AddProduct?productId="" + targetId, {
            method: ""post""
        })
            .then(res => {

                alert(""Successfully added!"");


            })
            .catch(err => alert(err));
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
