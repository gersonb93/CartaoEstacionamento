#pragma checksum "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "956587c1ee1e695b1fd7fc94ae3e7f0271cd6234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\_ViewImports.cshtml"
using CartaoEstacionamento;

#line default
#line hidden
#line 2 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\_ViewImports.cshtml"
using CartaoEstacionamento.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"956587c1ee1e695b1fd7fc94ae3e7f0271cd6234", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66447b23be19559604f6cd8eb10252d83c0e3c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartaoEstacionamento.ViewModels.PessoaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(170, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
  
    ViewBag.Title = "Cadastro de Usu??rio";

#line default
#line hidden
            BeginContext(223, 34, true);
            WriteLiteral("\r\n<h2>Cadastro de Usu??rio</h2>\r\n\r\n");
            EndContext();
#line 11 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(292, 23, false);
#line 13 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(319, 61, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(381, 64, false);
#line 18 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(445, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(496, 97, false);
#line 21 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.Telefone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(593, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(649, 97, false);
#line 23 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.Telefone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(746, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(765, 86, false);
#line 24 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.Telefone, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(851, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(938, 97, false);
#line 29 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.Endereco, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1091, 97, false);
#line 31 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.Endereco, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1207, 86, false);
#line 32 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.Endereco, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1380, 95, false);
#line 37 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.Cidade, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1531, 95, false);
#line 39 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.Cidade, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1645, 84, false);
#line 40 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.Cidade, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1816, 95, false);
#line 45 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.Estado, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1967, 95, false);
#line 47 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.Estado, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2081, 84, false);
#line 48 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.Estado, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 131, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pessoa F??sica (Praticante): Nome -->\r\n        <div class=\"Nome\">\r\n            ");
            EndContext();
            BeginContext(2297, 93, false);
#line 54 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2390, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2446, 93, false);
#line 56 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2539, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2558, 82, false);
#line 57 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2640, 129, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pessoa F??sica (Praticante): CPF -->\r\n        <div class=\"CPF\">\r\n            ");
            EndContext();
            BeginContext(2770, 92, false);
#line 63 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.CPF, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2862, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2918, 92, false);
#line 65 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.CPF, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3010, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3029, 81, false);
#line 66 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.CPF, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3110, 151, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pessoa F??sica (Praticante): DataNascimento -->\r\n        <div class=\"DataNascimento\">\r\n            ");
            EndContext();
            BeginContext(3262, 103, false);
#line 72 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.DataNascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3365, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3421, 103, false);
#line 74 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.DataNascimento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3524, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3543, 92, false);
#line 75 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3635, 156, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <!-- Pessoa Jur??dica (Estabelecimento): NomeFantasia -->\r\n        <div class=\"NomeFantasia\">\r\n            ");
            EndContext();
            BeginContext(3792, 101, false);
#line 82 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.NomeFantasia, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3893, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3949, 101, false);
#line 84 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.NomeFantasia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4050, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4069, 90, false);
#line 85 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.NomeFantasia, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4159, 152, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pessoa Jur??dica (Estabelecimento): RazaoSocial -->\r\n        <div class=\"RazaoSocial\">\r\n            ");
            EndContext();
            BeginContext(4312, 100, false);
#line 91 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.RazaoSocial, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4412, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(4468, 100, false);
#line 93 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.RazaoSocial, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4568, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4587, 89, false);
#line 94 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.RazaoSocial, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4676, 138, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pessoa Jur??dica (Estabelecimento): CNPJ -->\r\n        <div class=\"CNPJ\">\r\n            ");
            EndContext();
            BeginContext(4815, 93, false);
#line 100 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.CNPJ, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4908, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(4964, 93, false);
#line 102 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.CNPJ, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5057, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(5076, 82, false);
#line 103 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.CNPJ, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5158, 154, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pessoa Jur??dica (Estabelecimento): TelComercial -->\r\n        <div class=\"TelComercial\">\r\n            ");
            EndContext();
            BeginContext(5313, 101, false);
#line 109 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.TelComercial, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5414, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(5470, 101, false);
#line 111 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.TelComercial, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5571, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(5590, 90, false);
#line 112 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.TelComercial, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5680, 174, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pessoa Jur??dica (Estabelecimento): DataAbertura -->\r\n        <div class=\"DataAbertura\" id=\"DataAberturaId\">\r\n            ");
            EndContext();
            BeginContext(5855, 101, false);
#line 118 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
       Write(Html.LabelFor(model => model.DataAbertura, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5956, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(6012, 101, false);
#line 120 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.EditorFor(model => model.DataAbertura, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6113, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(6132, 90, false);
#line 121 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.ValidationMessageFor(model => model.DataAbertura, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6222, 165, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Radio button para selecionar pessoa f??sica ou jur??dica -->\r\n        <div>\r\n            <label>\r\n                ");
            EndContext();
            BeginContext(6388, 118, false);
#line 128 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.RadioButtonFor(model => model.TipoPessoa, TipoPessoa.Fisica, new { onclick = "habilitaCampo('pessoaFisicaId')" }));

#line default
#line hidden
            EndContext();
            BeginContext(6506, 68, true);
            WriteLiteral(" F??sica\r\n            </label>\r\n            <label>\r\n                ");
            EndContext();
            BeginContext(6575, 122, false);
#line 131 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
           Write(Html.RadioButtonFor(model => model.TipoPessoa, TipoPessoa.Juridica, new { onclick = "habilitaCampo('pessoaJuridicaId')" }));

#line default
#line hidden
            EndContext();
            BeginContext(6697, 2392, true);
            WriteLiteral(@" Jur??dica
            </label>
        </div>

        <script type=""text/javascript"">
            $(document).ready(function () {
                // Oculta os atributos da pessoa f??sica
                $("".Nome"").hide();
                $("".CPF"").hide();
                $("".DataNascimento"").hide();
                // Oculta os atributos da pessoa jur??dica
                $("".NomeFantasia"").hide();
                $("".RazaoSocial"").hide();
                $("".CNPJ"").hide();
                $("".TelComercial"").hide();
                $("".DataAbertura"").hide();


                $(""input[name=tipoPessoa]"").on(""click"", function () {
                    // Se pessoa f??sica estiver selecionado
                    if (pessoaFisicaId.checked) {
                        // Exibe os atributos da pessoa f??sica
                        $("".Nome"").show();
                        $("".CPF"").show();
                        $("".DataNascimento"").show();
                        // Oculta os atributos da p");
            WriteLiteral(@"essoa jur??dica
                        $("".NomeFantasia"").hide();
                        $("".RazaoSocial"").hide();
                        $("".CNPJ"").hide();
                        $("".TelComercial"").hide();
                        $("".DataAbertura"").hide();
                    }

                    // Se pessoa jur??dica estiver selecionado
                    else if (pessoaJuridicaId.checked) {
                        // Exibe os atributos da pessoa jur??dica
                        $("".NomeFantasia"").show();
                        $("".RazaoSocial"").show();
                        $("".CNPJ"").show();
                        $("".TelComercial"").show();
                        $("".DataAbertura"").show();
                        // Oculta os atributos da pessoa f??sica
                        $("".Nome"").hide();
                        $("".CPF"").hide();
                        $("".DataNascimento"").hide();
                        $("".Profissao"").hide();
                        $("".EstadoCivil");
            WriteLiteral(@""").hide();

                    }

                });
            });
        </script>

        <!-- Bot??o Salvar -->
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 192 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
            BeginContext(9092, 43, true);
            WriteLiteral("\r\n<!-- Bot??o voltar para lista -->\r\n<div>\r\n");
            EndContext();
            BeginContext(9186, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 9192, "\'", 9230, 1);
#line 197 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 9199, Url.Action("Index", "Pessoas"), 9199, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9231, 15, true);
            WriteLiteral(">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 9246, "\'", 9292, 1);
#line 198 "C:\Projetos C#\CartaoEstacionamento\CartaoEstacionamento\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 9252, Url.Content("~/Content/img/voltar.png"), 9252, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9293, 75, true);
            WriteLiteral(" class=\"botaoicone\" title=\"Voltar\" /> Lista de Usu??rios\r\n    </a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartaoEstacionamento.ViewModels.PessoaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
