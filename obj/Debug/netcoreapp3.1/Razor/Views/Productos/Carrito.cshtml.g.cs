#pragma checksum "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Carrito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ce03c1226faa690dce30e6a968e0c87b6839d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Carrito), @"mvc.1.0.view", @"/Views/Productos/Carrito.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ce03c1226faa690dce30e6a968e0c87b6839d6", @"/Views/Productos/Carrito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c757f397e0f56937b2a8e3fb5d9e6ad7622f212", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Carrito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("ViewBag.carro\n");
#nullable restore
#line 2 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Carrito.cshtml"
 for (int i = 0; i < ViewBag.cuenta;i++)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 5 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Carrito.cshtml"
   Write(ViewBag.carro[i].Producto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Cantida:");
#nullable restore
#line 5 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Carrito.cshtml"
                                             Write(ViewBag.carro[i].Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n");
#nullable restore
#line 6 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Carrito.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Carrito.cshtml"
Write(ViewBag.carro[0].Producto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Productos\Carrito.cshtml"
Write(ViewBag.carro[0].Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
