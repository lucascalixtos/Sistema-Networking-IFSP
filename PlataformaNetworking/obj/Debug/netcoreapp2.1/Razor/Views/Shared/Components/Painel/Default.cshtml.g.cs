#pragma checksum "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "090fd9e55053133c42b6bee0fe608041f109de05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Painel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Painel/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Painel/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Painel_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090fd9e55053133c42b6bee0fe608041f109de05", @"/Views/Shared/Components/Painel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Painel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(45, 175, true);
            WriteLiteral("\r\n    <ul class=\"list-group list-group-flush\">\r\n        <li class=\"list-group-item\">\r\n            <div class=\"h6 text-muted\">Painel</div>\r\n            <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 220, "\"", 255, 1);
#line 9 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
WriteAttributeValue("", 227, Url.Action("Vagas", "Home"), 227, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(256, 904, true);
            WriteLiteral(@">
                <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-book"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                    <path fill-rule=""evenodd"" d=""M1 2.828v9.923c.918-.35 2.107-.692 3.287-.81 1.094-.111 2.278-.039 3.213.492V2.687c-.654-.689-1.782-.886-3.112-.752-1.234.124-2.503.523-3.388.893zm7.5-.141v9.746c.935-.53 2.12-.603 3.213-.493 1.18.12 2.37.461 3.287.811V2.828c-.885-.37-2.154-.769-3.388-.893-1.33-.134-2.458.063-3.112.752zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"" />
                </svg>
                Vagas
            </a>
");
            EndContext();
#line 15 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
              
                if (Model.GetType().Name == "Aluno")
                {

#line default
#line hidden
            BeginContext(1249, 44, true);
            WriteLiteral("                    <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1293, "\"", 1328, 1);
#line 18 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
WriteAttributeValue("", 1300, Url.Action("Vagas", "Home"), 1300, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1329, 502, true);
            WriteLiteral(@">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-bookmark"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M2 2a2 2 0 0 1 2-2h8a2 2 0 0 1 2 2v13.5a.5.5 0 0 1-.777.416L8 13.101l-5.223 2.815A.5.5 0 0 1 2 15.5V2zm2-1a1 1 0 0 0-1 1v12.566l4.723-2.482a.5.5 0 0 1 .554 0L13 14.566V2a1 1 0 0 0-1-1H4z"" />
                        </svg>
                        Candidaturas
                    </a>
");
            EndContext();
#line 24 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1865, 49, true);
            WriteLiteral("\r\n    </ul>\r\n\r\n\r\n    </li>\r\n    <!--Add aqui-->\r\n");
            EndContext();
#line 32 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
      
        if (Model.GetType().Name == "Aluno")
        {
            

#line default
#line hidden
            BeginContext(1992, 42, false);
#line 35 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
       Write(await Component.InvokeAsync("Habilidades"));

#line default
#line hidden
            EndContext();
#line 35 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
                                                       ;
        }

    

#line default
#line hidden
            BeginContext(2057, 11, true);
            WriteLiteral("\r\n</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
