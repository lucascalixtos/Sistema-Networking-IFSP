#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ab666d0296a84075d04f21ad1f270bd1e1c7b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_MeuPerfil), @"mvc.1.0.view", @"/Views/Usuarios/MeuPerfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/MeuPerfil.cshtml", typeof(AspNetCore.Views_Usuarios_MeuPerfil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ab666d0296a84075d04f21ad1f270bd1e1c7b7", @"/Views/Usuarios/MeuPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_MeuPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAlterarImagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAmizade"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    string usuario = Model.Nome + " " + Model.Sobrenome;
    string curso = Model.Curso;
    string email = Model.Email;
    string nascimento = Model.DataNascimento.ToString("MM/dd/yyyy");
    string imagemPerfil = Model.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.ProfilePictureUrl;

#line default
#line hidden
            BeginContext(391, 165, true);
            WriteLiteral("\r\n<h2>Perfil</h2>\r\n\r\n<div class=\"w3-card w3-round w3-white col-lg-6\" style=\"padding: 20px;\">\r\n    <div class=\"w3-container\">\r\n        <div class=\"w3-content\"><h3><b>");
            EndContext();
            BeginContext(557, 7, false);
#line 15 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                  Write(usuario);

#line default
#line hidden
            EndContext();
            BeginContext(564, 136, true);
            WriteLiteral("</b></h3></div>\r\n        <p class=\"w3-center\">\r\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 700, "\"", 719, 1);
#line 18 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
WriteAttributeValue("", 706, imagemPerfil, 706, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(720, 516, true);
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
            BeginContext(1236, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcc8568e0ea6435788feb725578bb792", async() => {
                BeginContext(1279, 87, true);
                WriteLiteral("\r\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1366, "\"", 1398, 1);
#line 29 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
WriteAttributeValue("", 1374, Model.ProfilePictureUrl, 1374, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1399, 17, true);
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
            BeginContext(1423, 134, true);
            WriteLiteral("\r\n        </div>\r\n        <hr>\r\n        <p>\r\n            <i class=\"fa fa-pencil fa-fw w3-margin-right w3-text-theme\"></i>Estudante de ");
            EndContext();
            BeginContext(1558, 5, false);
#line 34 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                                    Write(curso);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 110, true);
            WriteLiteral("\r\n        </p>\r\n\r\n        <p>\r\n            <i class=\"fa fa-envelope fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1674, 5, false);
#line 38 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                          Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1679, 113, true);
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <i class=\"fa fa-birthday-cake fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1793, 10, false);
#line 41 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                               Write(nascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 146, true);
            WriteLiteral("\r\n        </p>\r\n\r\n    </div><br />\r\n        <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#myModal\">Editar</button><br />\r\n    ");
            EndContext();
            BeginContext(1949, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144d3a6972924a869b5b003fafef6b4c", async() => {
                BeginContext(1986, 64, true);
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"IdUsuario2\" name=\"IdUsuario2\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2050, "\"", 2067, 1);
#line 47 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
WriteAttributeValue("", 2058, Model.Id, 2058, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2068, 119, true);
                WriteLiteral(" />\r\n        <button onclick=\"SolicitaAmizade()\" type=\"submit\" class=\"btn btn-primary\">Solicitar Amizade</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2194, 142, true);
            WriteLiteral("\r\n</div>\r\n\r\n<!-- The Modal -->\r\n<div class=\"modal fade\" id=\"myModal\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n\r\n");
            EndContext();
#line 57 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
             using (Html.BeginForm("Edit", "Usuarios"))
            {

#line default
#line hidden
            BeginContext(2408, 261, true);
            WriteLiteral(@"                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Editar Usuário</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>
");
            EndContext();
            BeginContext(2688, 23, false);
#line 65 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2713, 186, true);
            WriteLiteral("                <!-- Modal body -->\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-horizontal\">\r\n                        <hr />\r\n                        ");
            EndContext();
            BeginContext(2900, 64, false);
#line 70 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2964, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2991, 33, false);
#line 71 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3024, 82, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3107, 93, false);
#line 74 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3288, 93, false);
#line 76 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3381, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3416, 82, false);
#line 77 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3498, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3649, 98, false);
#line 82 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Sobrenome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3747, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3835, 98, false);
#line 84 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Sobrenome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3933, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3968, 87, false);
#line 85 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Sobrenome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4055, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4206, 94, false);
#line 90 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Curso, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4300, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4388, 94, false);
#line 92 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Curso, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4482, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4517, 83, false);
#line 93 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Curso, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4600, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4751, 94, false);
#line 98 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4845, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4933, 94, false);
#line 100 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5027, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5062, 83, false);
#line 101 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5145, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(5296, 103, false);
#line 106 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.DataNascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5399, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(5487, 103, false);
#line 108 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.DataNascimento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5590, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5625, 92, false);
#line 109 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5717, 445, true);
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
#line 122 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
            }

#line default
#line hidden
            BeginContext(6177, 30, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6228, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6238, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e45f41608c64a91a3bc966875b7f7dd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6282, 584, true);
                WriteLiteral(@"
        <script>
            function SolicitaAmizade() {
                $('body').on('submit', '#formAmizade', function (evt) {
                    evt.preventDefault();
                    $.ajax({
                        url: '/Usuarios/SolicitaAmizade',
                        type: 'post',
                        data: $('#formAmizade').serialize(),
                        success: function () {
                            document.location.reload();
                        }
                    });
                });
            }
        </script>
    ");
                EndContext();
            }
            );
            BeginContext(6869, 6, true);
            WriteLiteral("</div>");
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
