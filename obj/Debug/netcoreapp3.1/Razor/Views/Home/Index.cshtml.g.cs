#pragma checksum "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a9557140c95ec150814e9867679432c63c877c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9557140c95ec150814e9867679432c63c877c2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c757f397e0f56937b2a8e3fb5d9e6ad7622f212", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElMercaditoWeb.Models.Slider>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div id=""carouselExampleIndicators"" class=""carousel slide mt-n5"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    </ol>

    <div class=""carousel-inner mb-4 mt-n4"">
        <div class=""carousel-item active"">


            <img");
            BeginWriteAttribute("src", " src=\"", 745, "\"", 773, 1);
#nullable restore
#line 24 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 751, ViewBag.datos[0].Img1, 751, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block w-100 blur"" height=""750"" alt=""..."">
            <div class=""carousel-caption align-middle mt-4"">
                <h1 class=""display-2  text-center centrado text-light"">Jhon'sMarket</h1>
                <h1 class=""display-5 text-center text-light"">Los  mejores productos del mercado</h1>
                <br>
");
#nullable restore
#line 29 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
                 if (SignInManager.IsSignedIn(User) == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-warning btn-lg text-light\" href=\"/Identity/Account/Login\">Inicia session</a>\n");
#nullable restore
#line 32 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <br>

                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
            </div>

        </div>
        <div class=""carousel-item"">
            <img");
            BeginWriteAttribute("src", " src=\"", 1643, "\"", 1671, 1);
#nullable restore
#line 50 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 1649, ViewBag.datos[0].Img2, 1649, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block w-100 blur"" height=""750"" alt=""..."">
            <div class=""carousel-caption align-middle mt-4"">
                <h1 class=""display-2  text-center centrado text-light"">Jhon'sMarket</h1>
                <h1 class=""display-5 text-center text-light"">Los  mejores productos del mercado</h1>
                <br>
");
#nullable restore
#line 55 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
                 if (SignInManager.IsSignedIn(User) == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-warning btn-lg text-light\" href=\"/Identity/Account/Login\">Inicia session</a>\n");
#nullable restore
#line 58 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
            </div>
        </div>
        <div class=""carousel-item"">
            <img");
            BeginWriteAttribute("src", " src=\"", 2548, "\"", 2576, 1);
#nullable restore
#line 75 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 2554, ViewBag.datos[0].Img3, 2554, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block w-100 blur"" height=""750"" alt=""..."">
            <div class=""carousel-caption align-middle mt-4"">
                <h1 class=""display-2  text-center centrado text-light"">Jhon'sMarket</h1>
                <h1 class=""display-5 text-center text-light"">Los  mejores productos del mercado</h1>
                <br>
");
#nullable restore
#line 80 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
                 if (SignInManager.IsSignedIn(User) == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-warning btn-lg text-light\" href=\"/Identity/Account/Login\">Inicia session</a>\n");
#nullable restore
#line 83 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
                <br>
            </div>
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<hr id=""acerca"">
<h1 class=""display-3 text-center"" id=""info""><b>Acerca de Nosotros</b></h1>
<hr>
<br>

<div class=""container"">
    <div class=""row"">

        <div class=""card col-lg-4 col-sm-12 "">
            <div class=""card-body text-center"">
       ");
            WriteLiteral("         <img src=\"https://image.flaticon.com/icons/svg/2921/2921726.svg\" height=\"75\"");
            BeginWriteAttribute("alt", " alt=\"", 4223, "\"", 4229, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 4230, "\"", 4238, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                <h6 class=""card-subtitle mb-2 mt-2""><b>Productos</b></h6>
                <p class=""card-text"">Nuestros productos son de la mejor calidad cultivados con amor traidos desde los mejores lugares para cosechar solo para ti y te puedes acceder a ellos con solo dar varios click y estos llegan a la puerta de tu casa </p>


            </div>
        </div>

        <div class=""card col-lg-4 col-sm-12"">
            <div class=""card-body text-center"">
                <img src=""https://image.flaticon.com/icons/svg/2947/2947532.svg"" height=""75""");
            BeginWriteAttribute("alt", " alt=\"", 4797, "\"", 4803, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 4804, "\"", 4812, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h6 class=""card-subtitle mb-2 mt-2""><b>Servicios</b></h6>
                <p class=""card-text"">Buscamos entregarle a nustros clientes el mejor servicio  para que estos se sientan satisfechos con lo que le damos nuestros servicios consisten en la entrega de productos a todas partes del mundo via nuestra pagina web</p>

            </div>
        </div>

        <div class=""card col-lg-4 col-sm-12 "">
            <div class=""card-body text-center"">
                <img src=""https://image.flaticon.com/icons/svg/921/921347.svg"" height=""75""");
            BeginWriteAttribute("alt", " alt=\"", 5371, "\"", 5377, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5378, "\"", 5386, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <br>
                <h6 class=""card-subtitle mb-2 mt-2""><b>Nosotros</b></h6>
                <p class=""card-text"">Nosotros somos una empresa que opera en linea y que hace posible que las personas puedan comprar sus productos del dia a dia con solo entrar a nuestra pagina y hacer varios clicks</p>


            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElMercaditoWeb.Models.Slider> Html { get; private set; }
    }
}
#pragma warning restore 1591