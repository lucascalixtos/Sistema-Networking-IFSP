#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27b4b6270f9a94fa3b77624dbc41b5acb1b4392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Index), @"mvc.1.0.view", @"/Views/Empresa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresa/Index.cshtml", typeof(AspNetCore.Views_Empresa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27b4b6270f9a94fa3b77624dbc41b5acb1b4392", @"/Views/Empresa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.Empresa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b77218eb325469ea38e19cc74335c49", async() => {
                BeginContext(152, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 40, false);
#line 16 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 47, false);
#line 19 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RazaoSocial));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 40, false);
#line 22 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ramo));

#line default
#line hidden
            EndContext();
            BeginContext(498, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(554, 40, false);
#line 25 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(650, 45, false);
#line 28 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(695, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(751, 41, false);
#line 31 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(792, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(848, 50, false);
#line 34 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(898, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(954, 41, false);
#line 37 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(995, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1051, 44, false);
#line 40 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1151, 53, false);
#line 43 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1322, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1371, 39, false);
#line 52 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CNPJ));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1466, 46, false);
#line 55 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RazaoSocial));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1568, 39, false);
#line 58 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ramo));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1663, 39, false);
#line 61 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1758, 44, false);
#line 64 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1858, 40, false);
#line 67 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1954, 49, false);
#line 70 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2059, 40, false);
#line 73 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2155, 43, false);
#line 76 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2254, 52, false);
#line 79 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2361, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d8037d3c04c65a3aad21c5fd97acd", async() => {
                BeginContext(2406, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(2414, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2434, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057d8441737f43418e4c25441f8a4add", async() => {
                BeginContext(2482, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(2493, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2513, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d33109e241f4348bb97163b9aa8cc56", async() => {
                BeginContext(2560, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2570, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Empresa\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2609, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.Empresa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
