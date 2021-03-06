#pragma checksum "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cce3e79482d98336f9a188c2fc0ce9a4f5e1f5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
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
#line 1 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cce3e79482d98336f9a188c2fc0ce9a4f5e1f5e", @"/Views/Usuario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17c2e0408a02350d8ddf4750bc795df38837c66d", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
  
    ViewData["Title"] = "Listagem de usuário";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Listagem de usuário</h2>\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Login</th>\r\n            <th>Senha</th>\r\n            <th>Data de Nascimento</th>\r\n");
#nullable restore
#line 16 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
             if(Context.Session.GetInt32("IdUsuario") != null) 
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Operações</th>\r\n");
#nullable restore
#line 19 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
               Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
               Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
               Write(u.DataNascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
                 if(Context.Session.GetInt32("IdUsuario") != null)
                {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 968, "\"", 1000, 2);
            WriteAttributeValue("", 975, "/Usuario/Deletar?Id=", 975, 20, true);
#nullable restore
#line 34 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 995, u.Id, 995, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja excluir?\')\">Remover</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1116, 2);
            WriteAttributeValue("", 1092, "/Usuario/Editar?Id=", 1092, 19, true);
#nullable restore
#line 35 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1111, u.Id, 1111, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n                        </td>\r\n");
#nullable restore
#line 37 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Yasmin\Desktop\UC4A2\Views\Usuario\Listar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
