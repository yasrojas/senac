#pragma checksum "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb0c8d3e623b05620a1a8b4872b7b219eedd4cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PacotesTuristicos_Vitrine), @"mvc.1.0.view", @"/Views/PacotesTuristicos/Vitrine.cshtml")]
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
#line 1 "C:\Users\Yasmin\Desktop\UC4A2\Views\_ViewImports.cshtml"
using UC4A2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasmin\Desktop\UC4A2\Views\_ViewImports.cshtml"
using UC4A2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb0c8d3e623b05620a1a8b4872b7b219eedd4cb", @"/Views/PacotesTuristicos/Vitrine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17c2e0408a02350d8ddf4750bc795df38837c66d", @"/Views/_ViewImports.cshtml")]
    public class Views_PacotesTuristicos_Vitrine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PacotesTuristicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
  
    ViewData["Title"] = "Vitrine";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Vitrine</h2>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Origem</th>
            <th>Destino</th>
            <th>Atrativos</th>
            <th>Saida</th>
            <th>Retorno</th>
            <th>Usuario</th>
");
#nullable restore
#line 19 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
             if(Context.Session.GetInt32("IdUsuario") != null) 
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Opera????es</th>\r\n");
#nullable restore
#line 22 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
         foreach (PacotesTuristicos pt in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Saida.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Retorno.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
               Write(pt.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
                 if(Context.Session.GetInt32("IdUsuario") != null)
                {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1182, "\"", 1225, 2);
            WriteAttributeValue("", 1189, "/PacotesTuristicos/Deletar?Id=", 1189, 30, true);
#nullable restore
#line 40 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
WriteAttributeValue("", 1219, pt.Id, 1219, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja excluir?\')\">Remover</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1310, "\"", 1352, 2);
            WriteAttributeValue("", 1317, "/PacotesTuristicos/Editar?Id=", 1317, 29, true);
#nullable restore
#line 41 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
WriteAttributeValue("", 1346, pt.Id, 1346, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n                        </td>\r\n");
#nullable restore
#line 43 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Yasmin\Desktop\UC4A2\Views\PacotesTuristicos\Vitrine.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PacotesTuristicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
