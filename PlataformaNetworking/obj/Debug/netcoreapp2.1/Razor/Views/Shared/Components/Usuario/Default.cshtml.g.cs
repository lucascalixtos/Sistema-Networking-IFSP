#pragma checksum "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Usuario\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d729c9f4751a206e8058c7254ed3be3ab6699d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Usuario_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Usuario/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Usuario/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Usuario_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d729c9f4751a206e8058c7254ed3be3ab6699d", @"/Views/Shared/Components/Usuario/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Usuario_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAlterarImagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 152, true);
            WriteLiteral("\r\n    <div class=\"card-body\">\r\n\r\n        <p class=\"w3-center\">\r\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 152, "\"", 259, 1);
#line 6 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Usuario\Default.cshtml"
WriteAttributeValue("", 158, Model.Usuario.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.Usuario.ProfilePictureUrl, 158, 101, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(260, 521, true);
            WriteLiteral(@" class=""rounded-circle imagemPerfil"" alt=""Avatar"" id=""imagemPerfilAlterar"">
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
            BeginContext(781, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc60f321b70d46faa6f0d37239717166", async() => {
                BeginContext(824, 87, true);
                WriteLiteral("\r\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 911, "\"", 951, 1);
#line 17 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Usuario\Default.cshtml"
WriteAttributeValue("", 919, Model.Usuario.ProfilePictureUrl, 919, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(952, 17, true);
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
            BeginContext(976, 42, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"h5\">");
            EndContext();
            BeginContext(1019, 18, false);
#line 20 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Usuario\Default.cshtml"
                   Write(Model.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1039, 23, false);
#line 20 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Usuario\Default.cshtml"
                                       Write(Model.Usuario.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 43, true);
            WriteLiteral("</div>\r\n        <div class=\"h7 text-muted\">");
            EndContext();
            BeginContext(1106, 28, false);
#line 21 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Usuario\Default.cshtml"
                              Write(Model.Usuario.GetType().Name);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 26, true);
            WriteLiteral("</div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
