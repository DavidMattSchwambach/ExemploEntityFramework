#pragma checksum "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\Computador\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4284056afff9b41307bdffda16a22fdd3089f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Computador_Editar), @"mvc.1.0.view", @"/Views/Computador/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Computador/Editar.cshtml", typeof(AspNetCore.Views_Computador_Editar))]
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
#line 1 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\_ViewImports.cshtml"
using view;

#line default
#line hidden
#line 2 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\_ViewImports.cshtml"
using view.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4284056afff9b41307bdffda16a22fdd3089f1", @"/Views/Computador/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57e7c39c0f8cf7e0af5a94210229c5cc03b6d41", @"/Views/_ViewImports.cshtml")]
    public class Views_Computador_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CadastroModalPeca.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/computador/computador-editar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/computador/computador-peca.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\Computador\Editar.cshtml"
  
    ViewData["Title"] = "Editar";

#line default
#line hidden
            BeginContext(44, 39, true);
            WriteLiteral("<input type=\"hidden\" id=\"computador-id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 83, "\"", 113, 1);
#line 5 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\Computador\Editar.cshtml"
WriteAttributeValue("", 91, ViewBag.Computador.Id, 91, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(114, 270, true);
            WriteLiteral(@" />

<div class=""row"">
    <div class=""col-5"">
        <div class=""form-group"">
            <label for=""computador-editar-categoria"">Categoria</label>
            <select class=""form-control""
                    id=""computador-editar-categoria"">
                ");
            EndContext();
            BeginContext(384, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9cdda8cdfd3433a83291c9cfdf7d3aa", async() => {
                BeginContext(478, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(501, 33, false);
#line 15 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\Computador\Editar.cshtml"
               Write(ViewBag.Computador.Categoria.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(534, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\Computador\Editar.cshtml"
                   WriteLiteral(ViewBag.Computador.Categoria.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(561, 200, true);
            WriteLiteral("\r\n            </select>\r\n            <div class=\"form-group\">\r\n                <label for=\"computador-editar-nome\">Nome</label>\r\n                <input id=\"computador-editar-nome\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                       value=\"", 761, "\"", 817, 1);
#line 21 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\Computador\Editar.cshtml"
WriteAttributeValue("", 793, ViewBag.Computador.Nome, 793, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(818, 205, true);
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"computador-editar-preco\">Preço</label>\r\n                <input id=\"computador-editar-preco\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                       value=\"", 1023, "\"", 1080, 1);
#line 27 "C:\Users\65972\Source\Repos\ExemploEntityFramework\view\Views\Computador\Editar.cshtml"
WriteAttributeValue("", 1055, ViewBag.Computador.Preco, 1055, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1081, 977, true);
            WriteLiteral(@" />
            </div>

            <button class=""btn btn-success float-right""
                    id=""computador-editar-salvar"">
                Salvar
            </button>
        </div>
    </div>
    <div class=""col-7"">
        <h3 class=""text-primary"">Lista de Peças</h3>

        <button class=""btn btn-primary float-lg-right mb-2""
                data-toggle=""modal""
                data-target=""#modal-peca-relacionamento"">
            Nova Peca
        </button>

        <table class=""table table-striped table-hover table-bordered""
               id=""computador-pecas-index"">
            <thead>
                <tr>
                    <th>Nome</th>
                    <th>Preço</th>
                    <th>Ação</th>
                </tr>
            </thead>
        </table>
        <span class=""font-weight-bold"">
            Total
            <span id=""computador-pecas-total""></span>
        </span>

    </div>
</div>

");
            EndContext();
            BeginContext(2058, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb6a2729a675472287d7aee75b930543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2101, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2122, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2128, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d13d3251a4434dbe97306c8695fc03e4", async() => {
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
                BeginContext(2188, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2194, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fce7c86729b445897e31b29c77e656b", async() => {
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
                BeginContext(2252, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
