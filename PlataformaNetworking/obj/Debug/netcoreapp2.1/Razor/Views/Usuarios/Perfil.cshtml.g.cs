#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73daea1da294c3abd7c7c53d8bb6a89331a47b1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Perfil), @"mvc.1.0.view", @"/Views/Usuarios/Perfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Perfil.cshtml", typeof(AspNetCore.Views_Usuarios_Perfil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73daea1da294c3abd7c7c53d8bb6a89331a47b1a", @"/Views/Usuarios/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAlterarImagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    string usuario = Model.Nome + " " + Model.Sobrenome;
    //string curso = Model.Curso;
    string email = Model.Email;
    string nascimento = Model.DataNascimento.ToString("MM/dd/yyyy");
    string imagemPerfil = Model.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.ProfilePictureUrl;

#line default
#line hidden
            BeginContext(393, 165, true);
            WriteLiteral("\r\n<h2>Perfil</h2>\r\n\r\n<div class=\"w3-card w3-round w3-white col-lg-6\" style=\"padding: 20px;\">\r\n    <div class=\"w3-container\">\r\n        <div class=\"w3-content\"><h3><b>");
            EndContext();
            BeginContext(559, 7, false);
#line 15 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                  Write(usuario);

#line default
#line hidden
            EndContext();
            BeginContext(566, 136, true);
            WriteLiteral("</b></h3></div>\r\n        <p class=\"w3-center\">\r\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 702, "\"", 721, 1);
#line 18 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 708, imagemPerfil, 708, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(722, 516, true);
            WriteLiteral(@" class=""w3-circle imagemPerfil"" alt=""Avatar"" id=""imagemPerfilAlterar"">
                <div class=""overlay"">
                    <a href=""#"" class=""icon"" title=""User Profile"">
                        <i class=""fa fa-camera""></i>
                    </a>
                </div>
                <input type=""file"" name=""uploadFotoPerfil"" class=""d-none"" accept=""image/png, image/jpeg"" id=""campoUploadImagem"" />
            </div>
        </p>
        <div class=""formAlterarImagemUsuario d-none"">
            ");
            EndContext();
            BeginContext(1238, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887ecf5e74a84e1bbb99450ddce0b034", async() => {
                BeginContext(1281, 87, true);
                WriteLiteral("\r\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1368, "\"", 1400, 1);
#line 29 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 1376, Model.ProfilePictureUrl, 1376, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1401, 17, true);
                WriteLiteral(" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1425, 244, true);
            WriteLiteral("\r\n        </div>\r\n        <hr>\r\n        <p>\r\n            <i class=\"fa fa-pencil fa-fw w3-margin-right w3-text-theme\"></i>Estudante de \r\n        </p>\r\n\r\n        <p>\r\n            <i class=\"fa fa-envelope fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1670, 5, false);
#line 38 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                          Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1675, 113, true);
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <i class=\"fa fa-birthday-cake fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1789, 10, false);
#line 41 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                               Write(nascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 280, true);
            WriteLiteral(@"
        </p>
        
    </div><br />
    <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">Editar</button>
</div>

<!-- The Modal -->
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

");
            EndContext();
#line 53 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
             using (Html.BeginForm("Edit", "Usuarios"))
            {

#line default
#line hidden
            BeginContext(2151, 261, true);
            WriteLiteral(@"                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Editar Usuário</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>
");
            EndContext();
            BeginContext(2431, 23, false);
#line 61 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2456, 186, true);
            WriteLiteral("                <!-- Modal body -->\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-horizontal\">\r\n                        <hr />\r\n                        ");
            EndContext();
            BeginContext(2643, 64, false);
#line 66 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2734, 33, false);
#line 67 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2767, 82, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2850, 93, false);
#line 70 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2943, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3031, 93, false);
#line 72 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3159, 82, false);
#line 73 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3241, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3392, 98, false);
#line 78 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Sobrenome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3490, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3578, 98, false);
#line 80 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Sobrenome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3676, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3711, 87, false);
#line 81 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Sobrenome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3798, 72, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n");
            EndContext();
            BeginContext(4417, 80, true);
            WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4498, 94, false);
#line 94 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4592, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4680, 94, false);
#line 96 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4774, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4809, 83, false);
#line 97 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4892, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(5043, 103, false);
#line 102 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.DataNascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5146, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(5234, 103, false);
#line 104 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.DataNascimento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5337, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5372, 92, false);
#line 105 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5464, 445, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <!-- Modal footer -->
                    <div class=""modal-footer"">
                        <input type=""submit"" value=""Salvar"" class=""btn btn-primary"" />
                        <input type=""button"" value=""Cancelar"" class=""btn btn-danger"" data-dismiss=""modal"" />

                    </div>

                </div>
");
            EndContext();
#line 118 "C:\Users\thiag\Desktop\FACULDADE\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\Caderno-Digital-Colaborativo\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
            }

#line default
#line hidden
            BeginContext(5924, 30, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5975, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5985, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd3125922384f7d91597e15db639d8e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6029, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            BeginContext(6038, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
