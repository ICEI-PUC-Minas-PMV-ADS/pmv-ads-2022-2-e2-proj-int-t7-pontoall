#pragma checksum "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b5f5f4b642065e383614a88e9a2f4d8a24526d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\_ViewImports.cshtml"
using PontoAll_2810;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\_ViewImports.cshtml"
using PontoAll_2810.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b5f5f4b642065e383614a88e9a2f4d8a24526d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d637451a86298b692301512b56189998c7f7ba5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 22rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Pagina Inicial";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""pb-4"">
    <div class=""text-center"">
        <h1 class=""display-4"">Seja Bem Vindo ao Ponto All.</h1>
        <h2 class=""display-8"">O seu sistema de marcação de ponto online.</h2>
        <p>Ambiente em desenvolvimento com o ASP.NET Core</p>
    </div>
</section>
<section class=""pb-4"">
    <div class=""bg-white border rounded-5"">

        <section class=""w-100 p-4 d-flex justify-content-center pb-4"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b5f5f4b642065e383614a88e9a2f4d8a24526d4379", async() => {
                WriteLiteral(@"
                <!-- Email input -->
                <div class=""form-outline mb-4"">
                    <input type=""email"" id=""elemento1"" class=""form-control"">
                    <label class=""form-label"" for=""form2Example1"" style=""margin-left: 0px;"">Email</label>
                    <div class=""form-notch""><div class=""form-notch-leading"" style=""width: 9px;""></div><div class=""form-notch-middle"" style=""width: 88.8px;""></div><div class=""form-notch-trailing""></div></div>
                </div>

                <!-- Password input -->
                <div class=""form-outline mb-4"">
                    <input type=""password"" id=""elemento2"" class=""form-control"">
                    <label class=""form-label"" for=""form2Example2"" style=""margin-left: 0px;"">Senha</label>
                    <div class=""form-notch""><div class=""form-notch-leading"" style=""width: 9px;""></div><div class=""form-notch-middle"" style=""width: 64.8px;""></div><div class=""form-notch-trailing""></div></div>
                </div>

  ");
                WriteLiteral(@"              <!-- 2 column grid layout for inline styling -->
                <div class=""row mb-4"">
                    <div class=""col d-flex justify-content-center"">
                        <!-- Checkbox -->
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1884, "\"", 1892, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"xxx\"");
                BeginWriteAttribute("checked", " checked=\"", 1902, "\"", 1912, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <label class=""form-check-label"" for=""form2Example31""> Manter conectado </label>
                            <br>
                            </br>

                        </div>
                    </div>
                    
                    <div class=""col"">
                        <!-- Simple link
                        <a href=""#!"">Forgot password?</a>
                    </div> -->
                </div>

                <!-- Submit button -->
                <input type=""button"" class=""btn btn-primary btn-block mb-4"" value=""Enviar"" onClick=""logar()"" />

                <script>
                    function logar() {
                        var x = document.getElementById(""elemento1"").value;
                        var y = document.getElementById(""elemento2"").value;

                        if (x != """" && y != """") {
                            window.location.href = './Home/Principal';
                        } else {
                           ");
                WriteLiteral(@" alert(""Favor preencher todos os campos"");
                        }
                    }

                </script>

                <!-- Register buttons 
                <div class=""text-center"">
                    <p>Not a member? <a href=""#!"">Register</a></p>
                    <p>or sign up with:</p>
                    <button type=""button"" class=""btn btn-link btn-floating mx-1"">
                        <i class=""fab fa-facebook-f""></i>
                    </button>

                    <button type=""button"" class=""btn btn-link btn-floating mx-1"">
                        <i class=""fab fa-google""></i>
                    </button>

                    <button type=""button"" class=""btn btn-link btn-floating mx-1"">
                        <i class=""fab fa-twitter""></i>
                    </button>

                    <button type=""button"" class=""btn btn-link btn-floating mx-1"">
                        <i class=""fab fa-github""></i>
                    </button>
                ");
                WriteLiteral("</div> -->\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n</section>\r\n");
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
