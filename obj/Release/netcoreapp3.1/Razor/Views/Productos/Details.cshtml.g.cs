#pragma checksum "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb7969b1bffb9085e63e5242f5d813581122aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Details), @"mvc.1.0.view", @"/Views/Productos/Details.cshtml")]
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
#line 1 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\_ViewImports.cshtml"
using ElMercaditoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\_ViewImports.cshtml"
using ElMercaditoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb7969b1bffb9085e63e5242f5d813581122aa3", @"/Views/Productos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c757f397e0f56937b2a8e3fb5d9e6ad7622f212", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElMercaditoWeb.Models.Productos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Productos/Carrito"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTodos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container \">\n\n    <div class=\"container\">\n\n        <div class=\"row\">\n            <div class=\"col-8 text-center card\">\n                <img class=\"img-fluid text-center\"");
            BeginWriteAttribute("src", " src=\"", 261, "\"", 307, 1);
#nullable restore
#line 13 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml"
WriteAttributeValue(" ", 267, Html.DisplayFor(model => model.Imagen), 268, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"850\" width=\"800\" />\n            </div>\n            <div class=\"col-4 card text-center p-5\">\n                <h2 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                <hr />\n                <h5><span class=\"text-secondary\">Precio:</span>  ");
#nullable restore
#line 18 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>\n                <hr />\n                <h5");
            BeginWriteAttribute("class", " class=\"", 669, "\"", 677, 0);
            EndWriteAttribute();
            WriteLiteral("><span class=\"text-secondary\">Descripcion:</span>  ");
#nullable restore
#line 20 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml"
                                                                          Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <hr />\n                <h5><span class=\"text-secondary\">En stock:</span> ");
#nullable restore
#line 22 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml"
                                                             Write(Html.DisplayFor(model => model.Disponibilidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <hr />\n                <h5>Cantidad</h5>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eb7969b1bffb9085e63e5242f5d813581122aa37164", async() => {
                WriteLiteral("\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1083, "\"", 1135, 1);
#nullable restore
#line 26 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Details.cshtml"
WriteAttributeValue("", 1091, Html.DisplayFor(model => model.IdProductos), 1091, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  name=\"IdProductos\"/>\n                    <input type=\"number\" name=\"Cantidad\"/>\n                    <input type=\"submit\" value=\"Comprar\" class=\"btn btn-outline-success mt-4\"/>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                <hr />\n\n           \n                \n            </div>\n        </div>\n\n\n    </div>\n\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eb7969b1bffb9085e63e5242f5d813581122aa39480", async() => {
                WriteLiteral("Volver a la lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElMercaditoWeb.Models.Productos> Html { get; private set; }
    }
}
#pragma warning restore 1591