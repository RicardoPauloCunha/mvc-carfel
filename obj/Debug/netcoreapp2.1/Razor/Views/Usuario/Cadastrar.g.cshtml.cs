#pragma checksum "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa3dfe6b61c77fa379fa19f124d1c70a83d4fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa3dfe6b61c77fa379fa19f124d1c70a83d4fec", @"/Views/Usuario/Cadastrar.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastrar-se";
    Layout = "MasterPageCadastroLogin";

#line default
#line hidden
            BeginContext(85, 1512, true);
            WriteLiteral(@"<div class=""box mgt"">
    <div class=""container-lr casleft""></div>

    <div class=""main"">
        <div class=""meio-circulo""></div>

        <div class=""container"">

            <div class=""header-logo"">
                <img src=""/imagem/logo.png"" alt=""logotipo CarFel"" class=""logo"">
            </div>
            
            <div class=""header-titulo"">
                <h1>Cadastro</h1>
            </div>

            <div class=""form-main"">
                <form method=""post"" action=""/Usuario/Cadastrar"" class=""formulario flex-container"">
                    <!-- <div class=""form-tipo-user flex-container"">
                        <div class=""tipo-user"">
                            <img src=""/imagem/user.png"" alt=""icóne usuario"" class=""icon-tipe-user flex-container"">
                            <label>
                                <input class=""form-radio"" type=""radio"" name=""tipo"" value=""Usuario"" checked>Usuário                               
                        </div>
          ");
            WriteLiteral(@"              <div class=""tipo-user"">
                            <img src=""/imagem/Admin.png"" alt=""icóne admin"" class=""icon-tipe-user flex-container"">
                                <input class=""form-radio"" type=""radio"" name=""tipo"" value=""Admin"">Admin
                            </label>
                        </div>
                    </div> -->

                    <label>
                        <p>Nome Completo:</p>
                        <p class=""mensegeInvalid"">");
            EndContext();
            BeginContext(1598, 24, false);
#line 38 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml"
                                             Write(TempData["MensengeValN"]);

#line default
#line hidden
            EndContext();
            BeginContext(1622, 273, true);
            WriteLiteral(@"</p>                    
                        <input type=""text"" name=""nome"" required class=""form-input"">
                    </label>
            
                    <label>
                        <p>Email:</p>
                        <p class=""mensegeInvalid"">");
            EndContext();
            BeginContext(1896, 24, false);
#line 44 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml"
                                             Write(TempData["MensengeValE"]);

#line default
#line hidden
            EndContext();
            BeginContext(1920, 275, true);
            WriteLiteral(@"</p>                    
                        <input type=""email"" name=""email"" required class=""form-input"">
                    </label>
            
                    <label>
                        <p>Senha:</p>
                        <p class=""mensegeInvalid"">");
            EndContext();
            BeginContext(2196, 24, false);
#line 50 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml"
                                             Write(TempData["MensengeValS"]);

#line default
#line hidden
            EndContext();
            BeginContext(2220, 265, true);
            WriteLiteral(@"</p>
                        <input type=""password"" name=""senha"" required class=""form-input"">
                    </label>

                    <label>
                        <p>Digite a Senha Novamente:</p>
                        <p class=""mensegeInvalid"">");
            EndContext();
            BeginContext(2486, 25, false);
#line 56 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml"
                                             Write(TempData["MensengeValSs"]);

#line default
#line hidden
            EndContext();
            BeginContext(2511, 350, true);
            WriteLiteral(@"</p>                   
                        <input type=""password"" name=""senha2"" required class=""form-input"">
                    </label>
            
                    <input type=""submit"" value=""Cadastrar-se"" class=""form-button"">
                </form>
                
                <div class=""mensagem"">
                    <p>");
            EndContext();
            BeginContext(2862, 24, false);
#line 64 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml"
                  Write(TempData["valCadastrar"]);

#line default
#line hidden
            EndContext();
            BeginContext(2886, 52, true);
            WriteLiteral("</p>\r\n                    <p class=\"mensegeInvalid\">");
            EndContext();
            BeginContext(2939, 25, false);
#line 65 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Usuario\Cadastrar.cshtml"
                                         Write(TempData["IvalCadastrar"]);

#line default
#line hidden
            EndContext();
            BeginContext(2964, 593, true);
            WriteLiteral(@"</p>                
                </div>

                <div class=""main-lr-item"">
                    <p>Já possui uma conta? <a href=""loginn.html"">Entrar</a></p>
                </div>

                <div class=""sair"">
                    <a href=""/Pagina/Home"">Sair</a>
                </div>

            </div>
        </div>
    </div>

    <div class=""container-lr cas"">
        <div class=""lr-item"">
            <p>Já possui uma conta?</p>
            <button class=""form-button""><a href=""/Usuario/Login"">Entrar</a></button>
        </div>
    </div>
</div>");
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
