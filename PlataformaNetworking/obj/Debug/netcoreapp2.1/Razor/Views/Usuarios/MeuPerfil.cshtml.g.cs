#pragma checksum "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8385faddbb97baa7693d4d17b86afcabbfa1270"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8385faddbb97baa7693d4d17b86afcabbfa1270", @"/Views/Usuarios/MeuPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_MeuPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAlterarImagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadCurriculo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Aluno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    string usuario = Model.Usuario.Nome + " " + Model.Usuario.Sobrenome;
    string curso = Model.Usuario.Curso;
    string email = Model.Usuario.Email;
    string nascimento = Model.Usuario.DataNascimento.ToString("MM/dd/yyyy");
    string imagemPerfil = Model.Usuario.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.Usuario.ProfilePictureUrl;

#line default
#line hidden
            BeginContext(455, 72, true);
            WriteLiteral("\n<h2>Perfil</h2>\n\n<div class=\"col-md-3\">\n    <div class=\"card\">\n        ");
            EndContext();
            BeginContext(528, 37, false);
#line 15 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
   Write(await Component.InvokeAsync("Painel"));

#line default
#line hidden
            EndContext();
            BeginContext(565, 162, true);
            WriteLiteral("\n    </div>\n</div>\n\n<div class=\"w3-card w3-round w3-white col-lg-6\" style=\"padding: 20px;\">\n    <div class=\"w3-container\">\n        <div class=\"w3-content\"><h3><b>");
            EndContext();
            BeginContext(728, 7, false);
#line 21 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                  Write(usuario);

#line default
#line hidden
            EndContext();
            BeginContext(735, 133, true);
            WriteLiteral("</b></h3></div>\n        <p class=\"w3-center\">\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 868, "\"", 887, 1);
#line 24 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
WriteAttributeValue("", 874, imagemPerfil, 874, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(888, 506, true);
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
            BeginContext(1394, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d952c4c1f34932acc905c054c75a2a", async() => {
                BeginContext(1437, 86, true);
                WriteLiteral("\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1523, "\"", 1563, 1);
#line 35 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
WriteAttributeValue("", 1531, Model.Usuario.ProfilePictureUrl, 1531, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1564, 16, true);
                WriteLiteral(" />\n            ");
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
            BeginContext(1587, 130, true);
            WriteLiteral("\n        </div>\n        <hr>\n        <p>\n            <i class=\"fa fa-pencil fa-fw w3-margin-right w3-text-theme\"></i>Estudante de ");
            EndContext();
            BeginContext(1718, 5, false);
#line 40 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                                    Write(curso);

#line default
#line hidden
            EndContext();
            BeginContext(1723, 108, true);
            WriteLiteral("\n        </p>\n\n        <p>\n            <i class=\"fa fa-envelope fa-fw w3-margin-right w3-text-theme\">Email: ");
            EndContext();
            BeginContext(1832, 5, false);
#line 44 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                            Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1837, 129, true);
            WriteLiteral("</i>\n        </p>\n        <p>\n            <i class=\"fa fa-birthday-cake fa-fw w3-margin-right w3-text-theme\">Data de nascimento: ");
            EndContext();
            BeginContext(1967, 10, false);
#line 47 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                                              Write(nascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1977, 32, true);
            WriteLiteral(" </i>\n        </p>\n        <p>\n\n");
            EndContext();
#line 51 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
              
                if (Model.Usuario.GetType().Name == "Aluno")
                {
                    

#line default
#line hidden
            BeginContext(2124, 71, false);
#line 54 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
               Write(await Component.InvokeAsync("Curriculo", new { id = Model.Usuario.Id }));

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                                            ;
                }
            

#line default
#line hidden
            BeginContext(2229, 133, true);
            WriteLiteral("\n        </p>\n\n    </div><br />\n    <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#myModal\">Editar</button><br />\n");
            EndContext();
#line 62 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
      
        if (Model.Usuario.GetType().Name == "Aluno")
        {

#line default
#line hidden
            BeginContext(2432, 127, true);
            WriteLiteral("            <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCurriculo\">Adicionar Curriculo</button><br />\n");
            EndContext();
#line 66 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
        }
    

#line default
#line hidden
            BeginContext(2575, 127, true);
            WriteLiteral("\n\n<!-- The Modal -->\n<div class=\"modal fade\" id=\"myModal\">\n    <div class=\"modal-dialog\">\n        <div class=\"modal-content\">\n\n");
            EndContext();
#line 75 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
             using (Html.BeginForm("Edit", "Usuarios"))
            {

#line default
#line hidden
            BeginContext(2772, 256, true);
            WriteLiteral(@"                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Editar Usuário</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>
");
            EndContext();
            BeginContext(3046, 23, false);
#line 83 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(3070, 182, true);
            WriteLiteral("                <!-- Modal body -->\n                <div class=\"modal-body\">\n                    <div class=\"form-horizontal\">\n                        <hr />\n                        ");
            EndContext();
            BeginContext(3253, 64, false);
#line 88 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3317, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3343, 41, false);
#line 89 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                   Write(Html.HiddenFor(model => model.Usuario.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3384, 79, true);
            WriteLiteral("\n\n                        <div class=\"form-group\">\n                            ");
            EndContext();
            BeginContext(3464, 101, false);
#line 92 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3565, 85, true);
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
            EndContext();
            BeginContext(3651, 101, false);
#line 94 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3752, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(3786, 90, false);
#line 95 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3876, 145, true);
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"form-group\">\n                            ");
            EndContext();
            BeginContext(4022, 106, false);
#line 100 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Sobrenome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4128, 85, true);
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
            EndContext();
            BeginContext(4214, 106, false);
#line 102 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Sobrenome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4320, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(4354, 95, false);
#line 103 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Sobrenome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4449, 145, true);
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"form-group\">\n                            ");
            EndContext();
            BeginContext(4595, 102, false);
#line 108 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Curso, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4697, 85, true);
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
            EndContext();
            BeginContext(4783, 102, false);
#line 110 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Curso, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4885, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(4919, 91, false);
#line 111 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Curso, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5010, 145, true);
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"form-group\">\n                            ");
            EndContext();
            BeginContext(5156, 102, false);
#line 116 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5258, 85, true);
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
            EndContext();
            BeginContext(5344, 102, false);
#line 118 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5446, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(5480, 91, false);
#line 119 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5571, 145, true);
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"form-group\">\n                            ");
            EndContext();
            BeginContext(5717, 111, false);
#line 124 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.DataNascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5828, 85, true);
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
            EndContext();
            BeginContext(5914, 111, false);
#line 126 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.DataNascimento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6025, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(6059, 100, false);
#line 127 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6159, 432, true);
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
#line 140 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
            }

#line default
#line hidden
            BeginContext(6605, 517, true);
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""modal fade"" id=""addCurriculo"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Editar Usuário</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                <div class=""form-horizontal"">
                    ");
            EndContext();
            BeginContext(7122, 338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf2f920f95dd400eaff208c46818ae83", async() => {
                BeginContext(7224, 95, true);
                WriteLiteral("\n                        <input type=\"file\" name=\"arquivo\" required />\n                        ");
                EndContext();
                BeginContext(7319, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a650f2b9474bd2a9be39fa4d08b7cb", async() => {
                    BeginContext(7417, 6, true);
                    WriteLiteral("Salvar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7432, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7460, 119, true);
            WriteLiteral("\n                </div>\n\n                <!-- Modal footer -->\n\n\n            </div>\n\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7596, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(7601, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60fe059b6325487faa867d7cde84d66e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7645, 504, true);
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
            BeginContext(8151, 11, true);
            WriteLiteral("    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
