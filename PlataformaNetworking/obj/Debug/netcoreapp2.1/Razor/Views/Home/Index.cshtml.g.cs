#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d5d73adef138a8c3b775d12efe24a3d9655323e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d5d73adef138a8c3b775d12efe24a3d9655323e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formNewPostagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Plataforma Networking";
    //string uploadimagem = Model.UploadPictureUrl == null ? "~/images/avatar3.png" : Model.UploadPictureUrl;

#line default
#line hidden
            BeginContext(229, 201, true);
            WriteLiteral("\r\n\r\n<!-- Page Container -->\r\n    <div class=\"container-fluid gedf-wrapper mt-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <div class=\"card\">\r\n                    ");
            EndContext();
            BeginContext(431, 38, false);
#line 13 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Usuario"));

#line default
#line hidden
            EndContext();
            BeginContext(469, 23, true);
            WriteLiteral(" \r\n                    ");
            EndContext();
            BeginContext(493, 37, false);
#line 14 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Painel"));

#line default
#line hidden
            EndContext();
            BeginContext(530, 380, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-6 gedf-main"">

                <!--- \\\\\\\Post-->
                <div class=""card gedf-card"">
                    <div class=""card-body"">
                        <div class=""tab-content"" id=""myTabContent"">

                            <div class=""form-group"">
                                ");
            EndContext();
            BeginContext(910, 1786, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0db512194eb405a85817c9ff3654035", async() => {
                BeginContext(951, 1738, true);
                WriteLiteral(@"
                                    <label class=""sr-only"" for=""message"">post</label>
                                    <textarea class=""form-control"" name=""TextoPost"" id=""TextoFormulario"" rows=""3"" placeholder=""Escreva sua publicação""></textarea>
                                    <input type=""hidden"" name=""Imagem"" id=""ImagemPost"" />


                                    <div class=""file-upload"">
                                        <button class=""file-upload-btn"" type=""button"" onclick=""$('.file-upload-input').trigger( 'click' )"">Adicionar imagem</button>

                                        <div class=""image-upload-wrap"">
                                            <input class=""file-upload-input"" type='file' onchange=""readURL(this);"" accept=""image/png, image/jpeg"" />
                                            <div class=""drag-text"">
                                                <h3>Arraste sua imagem até aqui para adiciona-la</h3>
                                            </div>");
                WriteLiteral(@"
                                        </div>
                                        <div class=""file-upload-content"">
                                            <img class=""file-upload-image w-100"" src=""#"" alt=""your image"" />
                                        </div>
                                    </div>

                                    <div class=""btn-toolbar justify-content-between"">
                                        <div class=""btn-group"">
                                            <button type=""submit"" class=""btn btn-primary"">Publicar</button>
                                        </div>
                                    </div>
                                ");
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
            BeginContext(2696, 177, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n                <!--Publicações-->\r\n               ");
            EndContext();
            BeginContext(2874, 35, false);
#line 58 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Index.cshtml"
          Write(await Component.InvokeAsync("Post"));

#line default
#line hidden
            EndContext();
            BeginContext(2909, 134, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-md-3 justify-content\">\r\n                <!--Pedido de Amizade-->\r\n                ");
            EndContext();
            BeginContext(3044, 44, false);
#line 63 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("PedidoAmizade"));

#line default
#line hidden
            EndContext();
            BeginContext(3088, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3159, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3165, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61b15409356d413cbe9c589a75ac38e4", async() => {
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
                BeginContext(3209, 2, true);
                WriteLiteral("\r\n");
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
