#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac929d5709a0e801e5c38510be3d1c3adfc2122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Post/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Post/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Post_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac929d5709a0e801e5c38510be3d1c3adfc2122", @"/Views/Shared/Components/Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.ViewModels.HomePostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(120, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
 foreach (var item in Model.Reverse())
{


#line default
#line hidden
            BeginContext(169, 329, true);
            WriteLiteral(@"    <div class=""card gedf-card"">
        <div class=""card-header"">
            <div class=""d-flex justify-content-between align-items-center"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""mr-3"">
                        <img class=""rounded-circle"" width=""50""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 498, "\"", 527, 2);
            WriteAttributeValue("", 503, "FotoPerfil-", 503, 11, true);
#line 16 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 514, item.Post.Id, 514, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 528, "\"", 565, 1);
#line 16 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 534, item.Usuario.ProfilePictureUrl, 534, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(566, 119, true);
            WriteLiteral(" alt=\"\">\r\n                    </div>\r\n                    <div class=\"ml-2\">\r\n                        <a class=\"h5 m-0\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 685, "\"", 724, 2);
            WriteAttributeValue("", 692, "Usuarios/Perfil/", 692, 16, true);
#line 19 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 708, item.Usuario.Id, 708, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(725, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(727, 17, false);
#line 19 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                             Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(744, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(746, 22, false);
#line 19 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                                                Write(item.Usuario.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(768, 1019, true);
            WriteLiteral(@"</a>
                    </div>
                </div>
                <div>
                    <div class=""dropdown"">
                        <button class=""btn btn-link dropdown-toggle"" type=""button"" id=""gedf-drop1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fa fa-ellipsis-h""></i>
                        </button>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""gedf-drop1"">
                            <div class=""h6 dropdown-header"">Configuration</div>
                            <a class=""dropdown-item"" href=""#"">Save</a>
                            <a class=""dropdown-item"" href=""#"">Hide</a>
                            <a class=""dropdown-item"" href=""#"">Report</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class=""card-body"">
            <div class=""text-muted h7 mb-2""> <i class=""fa fa-clock-o""></i>");
            EndContext();
            BeginContext(1788, 47, false);
#line 39 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                     Write(item.Post.PostTime.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 59, true);
            WriteLiteral("</div>\r\n            <p class=\"card-text\">\r\n                ");
            EndContext();
            BeginContext(1895, 19, false);
#line 41 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
           Write(item.Post.TextoPost);

#line default
#line hidden
            EndContext();
            BeginContext(1914, 36, true);
            WriteLiteral("\r\n            </p>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1950, "\"", 1973, 1);
#line 43 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 1956, item.Post.Imagem, 1956, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1974, 152, true);
            WriteLiteral(" style=\"width:100%\" alt=\"Post Image\" class=\"w3-margin-bottom\">\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <span class=\"card-link\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2126, "\"", 2151, 2);
            WriteAttributeValue("", 2131, "curtir-", 2131, 7, true);
#line 47 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2138, item.Post.Id, 2138, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2152, 25, true);
            WriteLiteral(" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2177, "\"", 2206, 3);
            WriteAttributeValue("", 2187, "Like(", 2187, 5, true);
#line 47 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2192, item.Post.Id, 2192, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2205, ")", 2205, 1, true);
            EndWriteAttribute();
            BeginContext(2207, 51, true);
            WriteLiteral(">Curtir</span>\r\n            <span class=\"card-link\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2258, "\"", 2286, 2);
            WriteAttributeValue("", 2263, "descurtir-", 2263, 10, true);
#line 48 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2273, item.Post.Id, 2273, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2287, 39, true);
            WriteLiteral(" style=\"cursor: pointer; display: none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2326, "\"", 2358, 3);
            WriteAttributeValue("", 2336, "Dislike(", 2336, 8, true);
#line 48 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2344, item.Post.Id, 2344, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2357, ")", 2357, 1, true);
            EndWriteAttribute();
            BeginContext(2359, 54, true);
            WriteLiteral(">Descurtir</span>\r\n            <span class=\"card-link\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2413, "\"", 2440, 2);
            WriteAttributeValue("", 2418, "comentar-", 2418, 9, true);
#line 49 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2427, item.Post.Id, 2427, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2441, "\"", 2474, 3);
            WriteAttributeValue("", 2451, "Comentar(", 2451, 9, true);
#line 49 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2460, item.Post.Id, 2460, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2473, ")", 2473, 1, true);
            EndWriteAttribute();
            BeginContext(2475, 206, true);
            WriteLiteral(" style=\"cursor: pointer\"><i class=\"fa fa-comment\"></i> Comentar</span>\r\n            <span class=\"card-link\" style=\"cursor: pointer;\">Compartilhar</span>\r\n            <div class=\"row mt-2\">\r\n                ");
            EndContext();
            BeginContext(2681, 570, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d95245b74824fe9a549164e5396bf9c", async() => {
                BeginContext(2756, 68, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" id=\"IdPost\" name=\"IdPost\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2824, "\"", 2845, 1);
#line 53 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2832, item.Post.Id, 2832, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2846, 256, true);
                WriteLiteral(@" />
                    <div class=""col-md-5"">
                        <input type=""text"" class=""form-control"" name=""CommentText"" id=""CommentText"" />
                    </div>
                    <div class=""col-md-3"">
                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3102, "\"", 3141, 3);
                WriteAttributeValue("", 3112, "FormComentario(", 3112, 15, true);
#line 58 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3127, item.Post.Id, 3127, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 3140, ")", 3140, 1, true);
                EndWriteAttribute();
                BeginContext(3142, 102, true);
                WriteLiteral(" type=\"submit\" class=\"btn btn-primary\">Comentar</button>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2705, "formComentario-", 2705, 15, true);
#line 52 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
AddHtmlAttributeValue("", 2720, item.Post.Id, 2720, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3251, 119, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <p>\r\n                <span class=\"glyphicon glyphicon-thumbs-up card-link\"></span> ");
            EndContext();
            BeginContext(3371, 14, false);
#line 64 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                         Write(item.Post.Like);

#line default
#line hidden
            EndContext();
            BeginContext(3385, 69, true);
            WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-comment card-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3454, "\"", 3497, 3);
            WriteAttributeValue("", 3464, "MostrarComentarios(", 3464, 19, true);
#line 65 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3483, item.Post.Id, 3483, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3496, ")", 3496, 1, true);
            EndWriteAttribute();
            BeginContext(3498, 57, true);
            WriteLiteral(" id=\"mostrarComentarios\" style=\"cursor: pointer\"></span> ");
            EndContext();
            BeginContext(3556, 21, false);
#line 65 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                                                                                                                   Write(item.Post.Comentarios);

#line default
#line hidden
            EndContext();
            BeginContext(3577, 115, true);
            WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-share card-link\"></span> 0\r\n            </p>\r\n\r\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3692, "\"", 3722, 2);
            WriteAttributeValue("", 3697, "comentarios-", 3697, 12, true);
#line 69 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3709, item.Post.Id, 3709, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3723, 41, true);
            WriteLiteral(" style=\"display: none\">\r\n                ");
            EndContext();
            BeginContext(3765, 55, false);
#line 70 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
           Write(await Component.InvokeAsync("Comentario", item.Post.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3820, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3872, 35, true);
            WriteLiteral("    <script>\r\n        VerificaLike(");
            EndContext();
            BeginContext(3908, 12, false);
#line 76 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                Write(item.Post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3920, 628, true);
            WriteLiteral(@");

        async function VerificaLike(idPost) {

            $.ajax({
                datatype: 'json',
                contentType: 'application/json',
                type: ""GET"",
                url: ""/Publicacoes/VerificaLike?idPost="" + idPost,
                /*data: {
                    idPost: idPost;
                },*/
                success: function (like) {
                    if (like) {
                        $('#curtir-' + idPost).hide();
                        $('#descurtir-' + idPost).show();
                    }
                }
            })
        }



    </script>
");
            EndContext();
#line 100 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"

}

#line default
#line hidden
            BeginContext(4553, 1789, true);
            WriteLiteral(@"
<script>
    async function Like(idPost) {
        var parametros = {
            IdPost: idPost
        };

        $.ajax({
            datatype: 'json',
            contentType: ""application/json"",
            type: ""POST"",
            url: ""/Publicacoes/Like"",
            data: JSON.stringify(parametros),
            async: true,
            success: function (data) {
                document.location.reload();
            }
        });
    }

    async function Dislike(idPost) {
        var parametros = {
            IdPost: idPost
        };

        $.ajax({
            datatype: 'json',
            contentType: ""application/json"",
            type: ""POST"",
            url: ""/Publicacoes/Dislike"",
            data: JSON.stringify(parametros),
            async: true,
            success: function (data) {
                document.location.reload();
            }
        });
    }



    function FormComentario(id) {
        $('body').on('submit', '#formComentar");
            WriteLiteral(@"io-' + id, function (evt) {
            evt.preventDefault();
            $.ajax({
                url: '/Publicacoes/Comentario',
                type: 'post',
                data: $('#formComentario-' + id).serialize(),
                success: function () {
                    document.location.reload();
                }
            });
        });
    }


    function Comentar(id) {
        $(""#formComentario-"" + id).toggle();
    }

    function MostrarComentarios(id) {
        $(""#comentarios-"" + id).toggle();
    }

    /* $(""#comentar"").click(function () {
         $(""#formComentario"").toggle();
     });

     $(""#mostrarComentarios"").click(function () {
         $(""#comentarios"").toggle();
     });*/


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.ViewModels.HomePostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
