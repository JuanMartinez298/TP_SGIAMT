#pragma checksum "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21dbfc926e90eb10ac9a9c731e62374e4f4d398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TUsuarios_Delete), @"mvc.1.0.view", @"/Views/TUsuarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TUsuarios/Delete.cshtml", typeof(AspNetCore.Views_TUsuarios_Delete))]
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
#line 1 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT;

#line default
#line hidden
#line 2 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21dbfc926e90eb10ac9a9c731e62374e4f4d398", @"/Views/TUsuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca981b27afbd8e7d4aba29c8ce9b9955aebba5b", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_SGIAMT.Models.TUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TUsuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(248, 44, false);
#line 15 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(336, 40, false);
#line 18 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(420, 46, false);
#line 21 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(466, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(510, 42, false);
#line 24 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(552, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(596, 46, false);
#line 27 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(642, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(686, 42, false);
#line 30 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(728, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(772, 53, false);
#line 33 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(825, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(869, 49, false);
#line 36 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(918, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(962, 48, false);
#line 39 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1054, 44, false);
#line 42 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1142, 42, false);
#line 45 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1228, 38, false);
#line 48 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1310, 47, false);
#line 51 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuNacademia));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1401, 43, false);
#line 54 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuNacademia));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1488, 60, false);
#line 57 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIauIdArchivoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1592, 71, false);
#line 60 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkIauIdArchivoNavigation.PkIauIdArchivo));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1707, 62, false);
#line 63 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FkItuTipoUsuarioNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1813, 75, false);
#line 66 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkItuTipoUsuarioNavigation.PkItuTipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1932, 62, false);
#line 69 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuCodCategoriaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2038, 69, false);
#line 72 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkIuCodCategoriaNavigation.PkIcCodCat));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2145, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25db806d135c4842ab6427de039b712c", async() => {
                BeginContext(2171, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2181, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d5e335ed1a24b0da20f8f1c8d5292be", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Proyectos\visual studio\TPII\PROGRA_BACILIO\TP_SGIAMT\TP_SGIAMT\Views\TUsuarios\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PkIuDni);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2222, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2306, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e806d1bbfaf4aadacde1a98f967df85", async() => {
                    BeginContext(2328, 12, true);
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
                BeginContext(2344, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2357, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_SGIAMT.Models.TUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
