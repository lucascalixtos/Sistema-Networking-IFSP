#pragma checksum "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d42d04ba3a9218a78f252349d528053a5723abc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vagas), @"mvc.1.0.view", @"/Views/Home/Vagas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Vagas.cshtml", typeof(AspNetCore.Views_Home_Vagas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42d04ba3a9218a78f252349d528053a5723abc0", @"/Views/Home/Vagas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vagas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
  
    ViewData["Title"] = "Vagas";
    //string uploadimagem = Model.UploadPictureUrl == null ? "~/images/avatar3.png" : Model.UploadPictureUrl;

#line default
#line hidden
            BeginContext(208, 174, true);
            WriteLiteral("\n\n<!-- Page Container -->\n<div class=\"container-fluid gedf-wrapper mt-3\">\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            <div class=\"card\">\n                ");
            EndContext();
            BeginContext(383, 38, false);
#line 13 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
           Write(await Component.InvokeAsync("Usuario"));

#line default
#line hidden
            EndContext();
            BeginContext(421, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(439, 37, false);
#line 14 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
           Write(await Component.InvokeAsync("Painel"));

#line default
#line hidden
            EndContext();
            BeginContext(476, 79, true);
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"col-md-6 gedf-main\">\n\n\n\n");
            EndContext();
#line 21 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
              

                if (Model.Usuario.GetType().Name == "Empresa")
                {
                    

#line default
#line hidden
            BeginContext(673, 45, false);
#line 25 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("PublicacaoVaga"));

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                  
                }
            

#line default
#line hidden
            BeginContext(751, 48, true);
            WriteLiteral("\n\n            <!--chamar View component aqui-->\n");
            EndContext();
#line 31 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
              
                if (Model.Usuario.GetType().Name == "Empresa")
                {
                    

#line default
#line hidden
            BeginContext(916, 50, false);
#line 34 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("ConteudoVagaEmpresa"));

#line default
#line hidden
            EndContext();
#line 34 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                       
                }

                else if (Model.Usuario.GetType().Name == "Aluno")
                {
                    

#line default
#line hidden
            BeginContext(1091, 48, false);
#line 39 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("ConteudoVagaAluno"));

#line default
#line hidden
            EndContext();
#line 39 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                     
                }
            

#line default
#line hidden
            BeginContext(1172, 36, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1225, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1230, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce95b19ce614af2a76888391b181cb5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1274, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
