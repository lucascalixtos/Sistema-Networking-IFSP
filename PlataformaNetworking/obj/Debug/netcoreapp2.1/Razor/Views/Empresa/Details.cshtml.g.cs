#pragma checksum "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2d2b1ff82417cbb456d8dbeadf27a91999a61d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Details), @"mvc.1.0.view", @"/Views/Empresa/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresa/Details.cshtml", typeof(AspNetCore.Views_Empresa_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2d2b1ff82417cbb456d8dbeadf27a91999a61d", @"/Views/Empresa/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Empresa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 113, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Empresa</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(198, 40, false);
#line 14 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(238, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(279, 36, false);
#line 17 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(315, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(356, 47, false);
#line 20 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RazaoSocial));

#line default
#line hidden
            EndContext();
            BeginContext(403, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(444, 43, false);
#line 23 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.RazaoSocial));

#line default
#line hidden
            EndContext();
            BeginContext(487, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(528, 40, false);
#line 26 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ramo));

#line default
#line hidden
            EndContext();
            BeginContext(568, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(609, 36, false);
#line 29 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ramo));

#line default
#line hidden
            EndContext();
            BeginContext(645, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(686, 40, false);
#line 32 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(726, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(767, 36, false);
#line 35 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(803, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(844, 45, false);
#line 38 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(889, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(930, 41, false);
#line 41 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(971, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1012, 41, false);
#line 44 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1094, 37, false);
#line 47 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1172, 50, false);
#line 50 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1263, 46, false);
#line 53 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1350, 41, false);
#line 56 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1432, 37, false);
#line 59 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1510, 44, false);
#line 62 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1595, 40, false);
#line 65 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1676, 53, false);
#line 68 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1770, 49, false);
#line 71 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1861, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3fe6954b5d42b68108b8bab497bb4d", async() => {
                BeginContext(1907, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1915, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1922, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ede2780465d04fefb81a57bc8f318991", async() => {
                BeginContext(1944, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1960, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.Empresa> Html { get; private set; }
    }
}
#pragma warning restore 1591
