#pragma checksum "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9c37ee8334ce86fc41fca1ece91fa8a3e8bf6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Habilidades_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Habilidades/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Habilidades/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Habilidades_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9c37ee8334ce86fc41fca1ece91fa8a3e8bf6f", @"/Views/Shared/Components/Habilidades/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Habilidades_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlataformaNetworking.Models.Habilidade>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(133, 28, true);
            WriteLiteral("<div class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 161, "\"", 185, 2);
            WriteAttributeValue("", 166, "habilidade-", 166, 11, true);
#line 9 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
WriteAttributeValue("", 177, item.Id, 177, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(186, 7, true);
            WriteLiteral(">\r\n    ");
            EndContext();
            BeginContext(194, 19, false);
#line 10 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
Write(item.NomeHabilidade);

#line default
#line hidden
            EndContext();
            BeginContext(213, 35, true);
            WriteLiteral("   <span class=\"badge badge-light\">");
            EndContext();
            BeginContext(249, 18, false);
#line 10 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
                                                      Write(item.Recomendacoes);

#line default
#line hidden
            EndContext();
            BeginContext(267, 44, true);
            WriteLiteral("</span>\r\n    <span class=\"btn btn-secondary\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 311, "\"", 335, 2);
            WriteAttributeValue("", 316, "recomendar-", 316, 11, true);
#line 11 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
WriteAttributeValue("", 327, item.Id, 327, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 336, "\"", 381, 5);
            WriteAttributeValue("", 346, "recomendar(", 346, 11, true);
#line 11 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
WriteAttributeValue("", 357, item.Id, 357, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 365, ",", 365, 1, true);
#line 11 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
WriteAttributeValue(" ", 366, item.IdAluno, 367, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 380, ")", 380, 1, true);
            EndWriteAttribute();
            BeginContext(382, 50, true);
            WriteLiteral(" style=\"display: none\">Recomendar</span>\r\n</div>\r\n");
            EndContext();
            BeginContext(450, 41, true);
            WriteLiteral("    <script>\r\n        $(\"#habilidade-\" + ");
            EndContext();
            BeginContext(492, 7, false);
#line 17 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(499, 663, true);
            WriteLiteral(@").css(""cursor"", ""default"");

        async function recomendar(idHabilidade, idAluno) {
            var parametros = {
                IdHabilidade: idHabilidade,
                idAluno: idAluno
            };

            $.ajax({
                datatype: 'json',
                contentType: ""application/json"",
                type: ""POST"",
                url: ""/Usuarios/RecomendaHabilidade"",
                data: JSON.stringify(parametros),
                async: true,
                success: function (data) {
                    document.location.reload();
                }
            });
        }

        $(""#habilidade-"" + ");
            EndContext();
            BeginContext(1163, 7, false);
#line 38 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1170, 54, true);
            WriteLiteral(").click(function () {\r\n            $(\"#recomendar-\" + ");
            EndContext();
            BeginContext(1225, 7, false);
#line 39 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1232, 41, true);
            WriteLiteral(").toggle();\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 42 "C:\Users\vinic\Desktop\Vini\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Habilidades\Default.cshtml"
}

#line default
#line hidden
            BeginContext(1276, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PlataformaNetworking.Models.Habilidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591
