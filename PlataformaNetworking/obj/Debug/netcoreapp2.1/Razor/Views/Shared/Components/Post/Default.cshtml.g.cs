#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd68369880e92f7a7e2f1d3f6d679ef0c90c6c2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd68369880e92f7a7e2f1d3f6d679ef0c90c6c2", @"/Views/Shared/Components/Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.PostModel>>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(101, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
 foreach (var item in Model.Reverse())
{


#line default
#line hidden
            BeginContext(150, 329, true);
            WriteLiteral(@"    <div class=""card gedf-card"">
        <div class=""card-header"">
            <div class=""d-flex justify-content-between align-items-center"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""mr-3"">
                        <img class=""rounded-circle"" width=""50""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 479, "\"", 503, 2);
            WriteAttributeValue("", 484, "FotoPerfil-", 484, 11, true);
#line 16 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 495, item.Id, 495, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(504, 126, true);
            WriteLiteral(" src=\"\" alt=\"\">\r\n                    </div>\r\n                    <div class=\"ml-2\">\r\n                        <a class=\"h5 m-0\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 630, "\"", 655, 2);
            WriteAttributeValue("", 635, "NomeUsuario-", 635, 12, true);
#line 19 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 647, item.Id, 647, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(656, 1028, true);
            WriteLiteral(@" href=""""></a>
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
            <div class=""text-muted h7 mb-2""> <i class=""fa fa-clock-o"">");
            WriteLiteral("</i>");
            EndContext();
            BeginContext(1685, 42, false);
#line 39 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                     Write(item.PostTime.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 59, true);
            WriteLiteral("</div>\r\n            <p class=\"card-text\">\r\n                ");
            EndContext();
            BeginContext(1787, 14, false);
#line 41 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
           Write(item.TextoPost);

#line default
#line hidden
            EndContext();
            BeginContext(1801, 36, true);
            WriteLiteral("\r\n            </p>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1837, "\"", 1855, 1);
#line 43 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 1843, item.Imagem, 1843, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1856, 189, true);
            WriteLiteral(" style=\"width:100%\" alt=\"Post Image\" class=\"w3-margin-bottom\">\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <span class=\"card-link\" id=\"curtir\" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2045, "\"", 2069, 3);
            WriteAttributeValue("", 2055, "Like(", 2055, 5, true);
#line 47 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2060, item.Id, 2060, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2068, ")", 2068, 1, true);
            EndWriteAttribute();
            BeginContext(2070, 105, true);
            WriteLiteral(">Curtir</span>\r\n            <span class=\"card-link\" id=\"descurtir\" style=\"cursor: pointer; display: none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2175, "\"", 2202, 3);
            WriteAttributeValue("", 2185, "Dislike(", 2185, 8, true);
#line 48 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2193, item.Id, 2193, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2201, ")", 2201, 1, true);
            EndWriteAttribute();
            BeginContext(2203, 68, true);
            WriteLiteral(">Descurtir</span>\r\n            <span class=\"card-link\" id=\"comentar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2271, "\"", 2299, 3);
            WriteAttributeValue("", 2281, "Comentar(", 2281, 9, true);
#line 49 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2290, item.Id, 2290, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2298, ")", 2298, 1, true);
            EndWriteAttribute();
            BeginContext(2300, 206, true);
            WriteLiteral(" style=\"cursor: pointer\"><i class=\"fa fa-comment\"></i> Comentar</span>\r\n            <span class=\"card-link\" style=\"cursor: pointer;\">Compartilhar</span>\r\n            <div class=\"row mt-2\">\r\n                ");
            EndContext();
            BeginContext(2506, 555, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f5497af9494e0ba433156a474e2570", async() => {
                BeginContext(2576, 68, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" id=\"IdPost\" name=\"IdPost\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2644, "\"", 2660, 1);
#line 53 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2652, item.Id, 2652, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2661, 256, true);
                WriteLiteral(@" />
                    <div class=""col-md-5"">
                        <input type=""text"" class=""form-control"" name=""CommentText"" id=""CommentText"" />
                    </div>
                    <div class=""col-md-3"">
                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2917, "\"", 2951, 3);
                WriteAttributeValue("", 2927, "FormComentario(", 2927, 15, true);
#line 58 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2942, item.Id, 2942, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2950, ")", 2950, 1, true);
                EndWriteAttribute();
                BeginContext(2952, 102, true);
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
            AddHtmlAttributeValue("", 2530, "formComentario-", 2530, 15, true);
#line 52 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
AddHtmlAttributeValue("", 2545, item.Id, 2545, 8, false);

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
            BeginContext(3061, 119, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <p>\r\n                <span class=\"glyphicon glyphicon-thumbs-up card-link\"></span> ");
            EndContext();
            BeginContext(3181, 9, false);
#line 64 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                         Write(item.Like);

#line default
#line hidden
            EndContext();
            BeginContext(3190, 69, true);
            WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-comment card-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3259, "\"", 3297, 3);
            WriteAttributeValue("", 3269, "MostrarComentarios(", 3269, 19, true);
#line 65 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3288, item.Id, 3288, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3296, ")", 3296, 1, true);
            EndWriteAttribute();
            BeginContext(3298, 57, true);
            WriteLiteral(" id=\"mostrarComentarios\" style=\"cursor: pointer\"></span> ");
            EndContext();
            BeginContext(3356, 16, false);
#line 65 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                                                                                                              Write(item.Comentarios);

#line default
#line hidden
            EndContext();
            BeginContext(3372, 115, true);
            WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-share card-link\"></span> 0\r\n            </p>\r\n\r\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3487, "\"", 3512, 2);
            WriteAttributeValue("", 3492, "comentarios-", 3492, 12, true);
#line 69 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3504, item.Id, 3504, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3513, 41, true);
            WriteLiteral(" style=\"display: none\">\r\n                ");
            EndContext();
            BeginContext(3555, 50, false);
#line 70 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
           Write(await Component.InvokeAsync("Comentario", item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3605, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3657, 35, true);
            WriteLiteral("    <script>\r\n        VerificaLike(");
            EndContext();
            BeginContext(3693, 7, false);
#line 76 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3700, 32, true);
            WriteLiteral(");\r\n        VerificaInfoUsuario(");
            EndContext();
            BeginContext(3733, 14, false);
#line 77 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                       Write(item.IdUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(3747, 1529, true);
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
                        $('#curtir').hide();
                        $('#descurtir').show();
                    }
                }
            })
        }

        async function VerificaInfoUsuario(idUsuario) {

            $.ajax({
                datatype: 'json',
                contentType: 'application/json',
                type: ""GET"",
                url: ""/Publicacoes/VerificaInfoUsuario?idUsuario="" + idUsuario,
                /*data: {
                    idPost: idPost;
                },*/
                success: function (usuario) {
                    $('");
            WriteLiteral(@"#NomeUsuario-' + idUsuario).html(usuario.Nome + "" "" + usuario.Sobrenome);
                    $('#NomeUsuario-' + idUsuario).attr(""href"", ""Usuarios/Perfil/"" + usuario.Id);
                    if (usuario.ProfilePictureUrl == null) {
                        $('#FotoPerfil-' + idUsuario).attr(""src"", ""~/images/avatar2.png"");
                    }
                    $('#FotoPerfil-' + idUsuario).attr(""src"", usuario.ProfilePictureUrl);
                }
            })
        }

    </script>
");
            EndContext();
#line 121 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
    
}

#line default
#line hidden
            BeginContext(5285, 1795, true);
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
        $('body').on('submit', '#formCome");
            WriteLiteral(@"ntario-' + id, function (evt) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.PostModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
