#pragma checksum "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d83b86c2d6d2128d78fe5dc25f20733a64cf96f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cela_Listar), @"mvc.1.0.view", @"/Views/Cela/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cela/Listar.cshtml", typeof(AspNetCore.Views_Cela_Listar))]
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
#line 1 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet.Models;

#line default
#line hidden
#line 3 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d83b86c2d6d2128d78fe5dc25f20733a64cf96f4", @"/Views/Cela/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fecf74b6f845a01516f2af22f52e385d474bc242", @"/Views/_ViewImports.cshtml")]
    public class Views_Cela_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Cela>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detalhar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(60, 155, true);
            WriteLiteral("\n<h2>Celas</h2>\n\n<table class=\"table\">\n    <tr>\n        <th>Nome</th>\n        <th>Área</th>\n        <th>Quantidade Máxima</th>\n        <th></th>\n    </tr>\n");
            EndContext();
#line 16 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(254, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(284, 9, false);
#line 19 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(293, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(316, 9, false);
#line 20 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(item.Area);

#line default
#line hidden
            EndContext();
            BeginContext(325, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(348, 21, false);
#line 21 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(item.QuantidadeMaxima);

#line default
#line hidden
            EndContext();
            BeginContext(369, 39, true);
            WriteLiteral("</td>\n            <td>\n                ");
            EndContext();
            BeginContext(408, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19bf2ac4bac415a9ee271c73233408c", async() => {
                BeginContext(509, 46, true);
                WriteLiteral("\n                    Detalhes\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
                         WriteLiteral(item.CelaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(559, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 29 "C:\Users\Lucas\Desktop\Luan\_Thiago\2TDSF-master\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(598, 10, true);
            WriteLiteral("</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Cela>> Html { get; private set; }
    }
}
#pragma warning restore 1591
