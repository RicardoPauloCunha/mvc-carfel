#pragma checksum "C:\Users\7\Desktop\Senai\Projeto-CarFel-CheckPoint-Web\Views\Pagina\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d66a9cd0effdaa936215603db6b16282308dd2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_Home), @"mvc.1.0.view", @"/Views/Pagina/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/Home.cshtml", typeof(AspNetCore.Views_Pagina_Home))]
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
#line 1 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CheckPoint-Web\Views\Pagina\Home.cshtml"
using Projeto_CarFel_CheckPoint_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d66a9cd0effdaa936215603db6b16282308dd2f", @"/Views/Pagina/Home.cshtml")]
    public class Views_Pagina_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CheckPoint-Web\Views\Pagina\Home.cshtml"
  
    ViewBag.Title = "Check Point";
    
    UsuarioModel usuario = ViewBag.UsuarioLog;

    if (usuario == null)
    {
        Layout = "MasterPageDeslogado";
    }
    else
    {
        Layout = "MasterPageLogado";    
    }

#line default
#line hidden
            BeginContext(278, 3380, true);
            WriteLiteral(@"
<div class=""banner flex-container"">
    <div class=""escuro""></div>	
	<div class=""banner-item"">	
    	<h2>Marque o ponto na sua empresa<br>pela internet com CheckPoint</h2>
    	<p>Muito mais rápido e eficiente</p>
    	<div class=""banner-contato"">
    		<a href=""/Pagina/Precos"">Assine já</a>
    	</div>
    </div>
</div>
	
<main>
    <section class=""produto espacamento"">
    	<div class=""produto-item"">
            <h1>CheckPoint</h1>
            <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis s simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy typesetting industry. Lorem Ipsum has been the industry's standard dummy</p>
        </div>
        <div class=""produto-img"">
			<img src=""/imagem/ilustracao.jfif"" alt=""Imagem representado uma pessoa utilizando o Checkpoint.""");
            WriteLiteral(@">
			<div class=""barra-fundo""></div>
		</div>
    </section>
    <section class=""vantagens"">
    	<h2>Por que escolher CheckPoint</h2>
    	<div class=""barra""></div>
    	<div class=""vantagens-item flex-container"">
    		<div>
    			<h3>Facilidade e Rapidez</h3>
                <p>Elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullam.</p>
            </div>
            <img src=""/imagem/rapidez.png"" alt=""Icone em forma de relogio representando a velocidade."" width=""189"" height=""120"">
    	</div>
        <div class=""barra""></div>
    		
        <div class=""vantagens-item flex-container v-i-a"">                				
            <img src=""/imagem/segurança.jpg"" alt=""Icone em forma de cadeado representando a segurança."" width=""140"" height=""140"">
            <div>
                <h3>Controle e Segurança</h3>
                <p>It is a long established fact that a reader will be distracted by the readable content o");
            WriteLiteral(@"f a page when looking at its layout established fact that a reader will</p>
            </div>
        </div>
    	<div class=""barra""></div>
    	<div class=""vantagens-item flex-container"">
    		<div>
    			<h3>Plataformas</h3>
    			<p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humou variations of Lorem Ipsum available,</p>
            </div>
            <img src=""/imagem/plataforma.png"" alt=""Icone com nootbook, tablet e celular representando multi-plataformas."" width=""189"" height=""120"">
    	</div>
    	<div class=""barra""></div>
    	<div class=""botao-contato"">
    		<h3><b>Solicite nosso contato</b></h3>
            <button><a href=""/Pagina/Contato"">Fale conosco ></a></button>
    	</div>
    </section>
    <section class=""empresa-resumo"">
    	<div class=""empresa"">
            <h2>Nossa missão</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et ");
            WriteLiteral(@"dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Lorem ipsum dolor sit amet, consectetur adipiscing elit,</p> 
            <button><a href=""/Pagina/Empresa"">Conheça nossa história ></a></button>
        </div>
	</section>
</main>");
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
