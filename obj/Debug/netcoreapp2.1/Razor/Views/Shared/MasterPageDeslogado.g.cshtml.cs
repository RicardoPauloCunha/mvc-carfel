#pragma checksum "C:\Users\7\Desktop\Senai\Projeto-CarFel-CheckPoint-Web\Views\Shared\MasterPageDeslogado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04f10a95a79a82234bcbe4a0976242615e6fad9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageDeslogado), @"mvc.1.0.view", @"/Views/Shared/MasterPageDeslogado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageDeslogado.cshtml", typeof(AspNetCore.Views_Shared_MasterPageDeslogado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f10a95a79a82234bcbe4a0976242615e6fad9b", @"/Views/Shared/MasterPageDeslogado.cshtml")]
    public class Views_Shared_MasterPageDeslogado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 36, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"pt-br\">\n");
            EndContext();
            BeginContext(36, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d178715056a4ebba3a9b3a3e60ddc2a", async() => {
                BeginContext(42, 195, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <link href=\"https://fonts.googleapis.com/css?family=Montserrat\" rel=\"stylesheet\">\n\t<link rel=\"stylesheet\" type=\"text/css\" href=\"/css/estilo.css\">\n\t<title>CarFel - ");
                EndContext();
                BeginContext(238, 13, false);
#line 7 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CheckPoint-Web\Views\Shared\MasterPageDeslogado.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(251, 10, true);
                WriteLiteral(" </title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(268, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(269, 1461, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79032ab52ee14cac94d3a992a9063f48", async() => {
                BeginContext(275, 552, true);
                WriteLiteral(@"
    <header class=""flex-container"">
		<div class=""logo"">
			<img src=""/imagem/logo.png"" alt=""Logo da empresa CarFel"">	
		</div>
		<div class=""flex-container menu-links-login"">
			<nav class=""menu"">
				<a action=""/Pagina/Home"">Home</a>
				<a href=""/Pagina/Empresa"">Sobre Nós</a>
				<a href=""/Pagina/Precos"">Preçõs</a>
				<a href=""/Pagina/Contato"">Contato</a>
			</nav>
			
            <nav class=""menu menu-login"">
				<a href=""/Usuario/Login"">Login</a>
				<a href=""/Usuario/Cadastrar"">Cadastrar-se</a>
			</nav>
		</div>
		</div>
	</header>

    ");
                EndContext();
                BeginContext(828, 12, false);
#line 30 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CheckPoint-Web\Views\Shared\MasterPageDeslogado.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(840, 883, true);
                WriteLiteral(@"

    <footer class=""flex-container"">
    	<ul>
			<a href=""/Pagina/Home"">
				<li class=""footer-item"">Home</li>
				<li>CheckPoint</li>
				<li>Termos de uso</li>
				<li>Suporte</li>
				<li>Chat</li>
			</a>
        </ul>
        <ul>
			<a href=""/Pagina/Empresa"">
				<li class=""footer-item"">Institucional</li>
				<li>Sobre Nós</li>
				<li>História</li>
				<li>Outros produtos</li>
				<li>Colaboradores</li>
			</a>
        </ul>
        <ul>
			<a href=""/Pagina/Contato"">
				<li class=""footer-item""> Contato</li>
				<li>(XX) XXXXX-XXXX</li>
				<li>carfel.checkpoint@gmail.com</li>
				<li>Alameda Barão de Limeira, 539 </li>
				<li>Santa Cecilia</li>
			</a>
        </ul>
        <ul>
            <li class=""footer-item"">Siga-nós</li>
            <img src=""/imagem/redessociais.png"" alt=""Icones das redes sociais."" width=""170"" height=""170"">
        </ul>
    </footer>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1730, 8, true);
            WriteLiteral("\n</html>");
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
