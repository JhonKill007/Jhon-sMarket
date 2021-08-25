#pragma checksum "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094d2aa923877aefaaaa3ea4543b69abc20a6237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Mapa), @"mvc.1.0.view", @"/Views/Clientes/Mapa.cshtml")]
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
#line 4 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094d2aa923877aefaaaa3ea4543b69abc20a6237", @"/Views/Clientes/Mapa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c757f397e0f56937b2a8e3fb5d9e6ad7622f212", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Mapa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ElMercaditoWeb.Models.Clientes>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<br />\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094d2aa923877aefaaaa3ea4543b69abc20a62373998", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Tarea8</title>
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.6.0/dist/leaflet.css"" />
    <script src=""https://unpkg.com/leaflet@1.6.0/dist/leaflet.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094d2aa923877aefaaaa3ea4543b69abc20a62375262", async() => {
                WriteLiteral(@"
    
    <div class=""container"">

        <div class=""container"">
            <div id=""map"" style=""height:600px"" class=""border border-warning""></div>
        </div>
        

        <script>
            var map = L.map('map').fitWorld();



            L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                attribution: '&copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors'
            }).addTo(map);


        </script>

");
#nullable restore
#line 41 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
         if ((await AuthorizationService.AuthorizeAsync(User, "Admin")).Succeeded)
         {
            Int32 cont = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script>\n                    map.flyTo([");
#nullable restore
#line 47 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Lat));

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 47 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Long));

#line default
#line hidden
#nullable disable
                WriteLiteral("], 14);\n                        L.marker([");
#nullable restore
#line 48 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                             Write(Html.DisplayFor(modelItem => item.Lat));

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 48 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Long));

#line default
#line hidden
#nullable disable
                WriteLiteral("]).addTo(map)\n                            .bindPopup(\'Usuario: ");
#nullable restore
#line 49 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
                WriteLiteral(", Nombre: ");
#nullable restore
#line 49 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                                                                                                 Write(Html.DisplayFor(modelItem => item.NombrePersona));

#line default
#line hidden
#nullable disable
                WriteLiteral(", Direccion: ");
#nullable restore
#line 49 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                                                                                                                                                               Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\n                            .openPopup();\n    </script>\n");
#nullable restore
#line 71 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NombrePersona));

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lat));

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Long));

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
                                                                
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Jhon David\source\repos\ElMercaditoWeb\ElMercaditoWeb\Views\Clientes\Mapa.cshtml"
              
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ElMercaditoWeb.Models.Clientes>> Html { get; private set; }
    }
}
#pragma warning restore 1591