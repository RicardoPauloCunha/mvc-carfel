#pragma checksum "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a9c9e83b2d438c911ba53e403087f07cffa9957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depoimento_Listar), @"mvc.1.0.view", @"/Views/Depoimento/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depoimento/Listar.cshtml", typeof(AspNetCore.Views_Depoimento_Listar))]
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
#line 1 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
using Projeto_CarFel_CkeckPoint_Web.Models;

#line default
#line hidden
#line 2 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
using Projeto_CarFel_CheckPoint_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a9c9e83b2d438c911ba53e403087f07cffa9957", @"/Views/Depoimento/Listar.cshtml")]
    public class Views_Depoimento_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
     if (ViewBag.UserLog == 1)
    {
        ViewBag.Title = "Central de Depoimentos";
    }
    else
    {
        ViewBag.Title = "Depoimentos";
    }

#line default
#line hidden
#line 11 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
     
    Layout = "MasterPageDeslogado";

#line default
#line hidden
            BeginContext(297, 70, true);
            WriteLiteral("\r\n<div class=\"titulo flex-container\">\r\n    <div class=\"titulo-item\">\r\n");
            EndContext();
#line 17 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
         if (ViewBag.UserLog == 1)
        {

#line default
#line hidden
            BeginContext(414, 45, true);
            WriteLiteral("            <h2>Central de Depoimentos</h2>\r\n");
            EndContext();
#line 20 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(495, 34, true);
            WriteLiteral("            <h2>Depoimentos</h2>\r\n");
            EndContext();
#line 24 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(540, 40, true);
            WriteLiteral("        \r\n    </div>\r\n</div>\r\n\r\n<main>\r\n");
            EndContext();
#line 30 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
     if (ViewBag.UserLog == 1)
    { 

#line default
#line hidden
            BeginContext(620, 125, true);
            WriteLiteral("        <section class=\"depoimentos depoimentos-pag espacamento\">\r\n            <h2>Avaliar Depoimentos</h2>\r\n                ");
            EndContext();
            BeginContext(746, 28, false);
#line 34 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
           Write(TempData["AvaliacaoSucesso"]);

#line default
#line hidden
            EndContext();
            BeginContext(774, 42, true);
            WriteLiteral("\r\n            <div class=\"Usuarios-dep\">\r\n");
            EndContext();
#line 36 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                  
                    List<DepoimentoModel> lista = ViewData["Depoimentos"] as List<DepoimentoModel>;
                

#line default
#line hidden
            BeginContext(956, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 39 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                 for (int i =  lista.Count-1 ; i > 0; i--)
                {
                    if (lista[i].Situacao == "Pendente")
                    {

#line default
#line hidden
            BeginContext(1116, 554, true);
            WriteLiteral(@"                        <div class=""user-dep"">
                            <div class=""flex-container"">
                                <div class=""dep-img"">
                                    <img src=""/imagem/user.png"" alt=""icone de usuario"">		
                                </div>
                                <div class=""dep-container"">          
                                    <div class=""dep-header flex-container"">
                                        <div class=""dh-text"">
                                            <p><b> ");
            EndContext();
            BeginContext(1671, 21, false);
#line 51 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                              Write(lista[i].Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1692, 57, true);
            WriteLiteral("</b></p>\r\n                                            <p>");
            EndContext();
            BeginContext(1750, 20, false);
#line 52 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                          Write(lista[i].DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 201, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"dep-main\">\r\n                                        <p>");
            EndContext();
            BeginContext(1972, 14, false);
#line 56 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                      Write(lista[i].Texto);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 276, true);
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""dep-footer flex-container"">
                                        <div class=""df-aprovado"">
                                            <button style=""margin-right: 0.5em""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2262, "\"", 2304, 2);
            WriteAttributeValue("", 2269, "/Depoimento/Aprovar?id=", 2269, 23, true);
#line 60 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
WriteAttributeValue("", 2292, lista[i].Id, 2292, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2305, 194, true);
            WriteLiteral(">Aprovado</a></button>\r\n                                        </div>\r\n                                        <div class=\"df-reprovado\">\r\n                                            <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2499, "\"", 2542, 2);
            WriteAttributeValue("", 2506, "/Depoimento/Reprovar?id=", 2506, 24, true);
#line 63 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
WriteAttributeValue("", 2530, lista[i].Id, 2530, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2543, 284, true);
            WriteLiteral(@">Reprovado</a></button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""dep-barra""></div>
                        </div>
");
            EndContext();
#line 70 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2869, 40, true);
            WriteLiteral("            </div>\r\n        </section>\r\n");
            EndContext();
            BeginContext(2911, 127, true);
            WriteLiteral("        <section class=\"depoimentos depoimentos-pag espacamento\">\r\n            <h2>Depoimentos Aprovados</h2>\r\n                ");
            EndContext();
            BeginContext(3039, 28, false);
#line 77 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
           Write(TempData["AvaliacaoSucesso"]);

#line default
#line hidden
            EndContext();
            BeginContext(3067, 42, true);
            WriteLiteral("\r\n            <div class=\"Usuarios-dep\">\r\n");
            EndContext();
#line 79 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                 for (int i =  lista.Count-1 ; i > 0; i--)
                {
                    if (lista[i].Situacao == "Aprovado")
                    {

#line default
#line hidden
            BeginContext(3269, 553, true);
            WriteLiteral(@"                        <div class=""user-dep"">
                            <div class=""flex-container"">
                                <div class=""dep-img"">
                                    <img src=""/imagem/user.png"" alt=""icone de usuario"">		
                                </div>
                                <div class=""dep-container"">          
                                    <div class=""dep-header flex-container"">
                                        <div class=""dh-text"">
                                            <p><b>");
            EndContext();
            BeginContext(3823, 21, false);
#line 91 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                             Write(lista[i].Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3844, 5, true);
            WriteLiteral("</b> ");
            EndContext();
            BeginContext(3850, 11, false);
#line 91 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                                                        Write(lista[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(3861, 53, true);
            WriteLiteral("</p>\r\n                                            <p>");
            EndContext();
            BeginContext(3915, 20, false);
#line 92 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                          Write(lista[i].DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(3935, 201, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"dep-main\">\r\n                                        <p>");
            EndContext();
            BeginContext(4137, 14, false);
#line 96 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                      Write(lista[i].Texto);

#line default
#line hidden
            EndContext();
            BeginContext(4151, 249, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"dep-footer flex-container\">\r\n                                        <div class=\"df-reprovado\">\r\n                                            <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4400, "\"", 4443, 2);
            WriteAttributeValue("", 4407, "/Depoimento/Reprovar?id=", 4407, 24, true);
#line 100 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
WriteAttributeValue("", 4431, lista[i].Id, 4431, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4444, 282, true);
            WriteLiteral(@">Excluir</a></button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""dep-barra""></div>
                        </div>
");
            EndContext();
#line 107 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                    }
                }  

#line default
#line hidden
            BeginContext(4770, 190, true);
            WriteLiteral("            </div>\r\n            <div class=\"dep-buttons flex-container\">\r\n                    <button><a href=\"/Pagina/Home\">Voltar</a></button>\r\n                </div>\r\n        </section>\r\n");
            EndContext();
#line 114 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"

    }

    else
    {

#line default
#line hidden
            BeginContext(4988, 91, true);
            WriteLiteral("        <section class=\"depoimentos depoimentos-pag\">\r\n            <h2>Depoimentos</h2>\r\n\r\n");
            EndContext();
#line 122 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
             if (ViewBag.UserLog > 0)
            {

#line default
#line hidden
            BeginContext(5133, 69, true);
            WriteLiteral("                <div class=\"user-dep-escrever\">\r\n                    ");
            EndContext();
            BeginContext(5203, 27, false);
#line 125 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
               Write(TempData["valDepCadastrar"]);

#line default
#line hidden
            EndContext();
            BeginContext(5230, 76, true);
            WriteLiteral("\r\n                    <div class=\"mensegeInvalid\">\r\n                        ");
            EndContext();
            BeginContext(5307, 24, false);
#line 127 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                   Write(TempData["MensengeValT"]);

#line default
#line hidden
            EndContext();
            BeginContext(5331, 542, true);
            WriteLiteral(@"
                    </div> 
                    <div class=""flex-container"">
                        <div class=""dep-img flex-container"" style=""justify-content: flex-end;"">
                            <img src=""/imagem/user.png"" alt=""icone de usuario"" style=""height: 3em;"">		
                        </div>
                        <div class=""dep-container-escrever"">
                            <div class=""dep-header flex-container"">
                                <div class=""dh-text"">
                                    <p><b>");
            EndContext();
            BeginContext(5874, 19, false);
#line 136 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                     Write(ViewBag.UsuarioLogN);

#line default
#line hidden
            EndContext();
            BeginContext(5893, 527, true);
            WriteLiteral(@"</b></p>
                                </div>
                            </div>
                            <form method=""post"" action=""/Depoimento/Cadastrar"">
                                <textarea name=""texto"" placeholder=""Deixe seu depoimento:"" class=""contato-item-form-input dep-textarea""></textarea>
                                <input type=""submit"" value=""Enviar"" class=""button-sub"">
                            </form>
                        </div>
                    </div>	
                </div>
");
            EndContext();
#line 146 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
            }

#line default
#line hidden
            BeginContext(6435, 42, true);
            WriteLiteral("\r\n            <div class=\"Usuarios-dep\">\r\n");
            EndContext();
#line 149 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                  
                    List<DepoimentoModel> lista = ViewData["Depoimentos"] as List<DepoimentoModel>;
                

#line default
#line hidden
            BeginContext(6617, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 152 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                 for (int i =  lista.Count-1 ; i > 0; i--)
                {
                    if (lista[i].Situacao == "Aprovado")
                    {

#line default
#line hidden
            BeginContext(6777, 554, true);
            WriteLiteral(@"                        <div class=""user-dep"">
                            <div class=""flex-container"">
                                <div class=""dep-img"">
                                    <img src=""/imagem/user.png"" alt=""icone de usuario"">		
                                </div>
                                <div class=""dep-container"">          
                                    <div class=""dep-header flex-container"">
                                        <div class=""dh-text"">
                                            <p><b> ");
            EndContext();
            BeginContext(7332, 21, false);
#line 164 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                              Write(lista[i].Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(7353, 57, true);
            WriteLiteral("</b></p>\r\n                                            <p>");
            EndContext();
            BeginContext(7411, 20, false);
#line 165 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                          Write(lista[i].DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(7431, 201, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"dep-main\">\r\n                                        <p>");
            EndContext();
            BeginContext(7633, 14, false);
#line 169 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                      Write(lista[i].Texto);

#line default
#line hidden
            EndContext();
            BeginContext(7647, 338, true);
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""dep-footer flex-container"">
                                    </div>
                                </div>
                            </div>
                            <div class=""dep-barra""></div>
                        </div>
");
            EndContext();
#line 177 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                    }
                }  

#line default
#line hidden
            BeginContext(8029, 183, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"dep-buttons flex-container\">\r\n              <button><a href=\"/Pagina/Home\">Voltar</a></button>\r\n            </div>\t\r\n        </section>\r\n");
            EndContext();
#line 185 "C:\Users\50473694808\Desktop\Projeto CarFel\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(8219, 9, true);
            WriteLiteral("</main>\r\n");
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
