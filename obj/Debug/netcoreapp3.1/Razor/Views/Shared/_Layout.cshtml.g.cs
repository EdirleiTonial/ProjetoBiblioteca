#pragma checksum "D:\Senac TI\UC6\Biblioteca\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f288d426005ed817b2996b0f3e71110dd2e354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Senac TI\UC6\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Senac TI\UC6\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f288d426005ed817b2996b0f3e71110dd2e354", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f288d426005ed817b2996b0f3e71110dd2e3547270", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\Senac TI\UC6\Biblioteca\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Biblioteca</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2f288d426005ed817b2996b0f3e71110dd2e3547889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2f288d426005ed817b2996b0f3e71110dd2e3549067", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css\"></script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f288d426005ed817b2996b0f3e71110dd2e35411046", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark border-bottom box-shadow mb-3\">\r\n            <div class=\"container\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f288d426005ed817b2996b0f3e71110dd2e35411500", async() => {
                    WriteLiteral("Biblioteca");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link text-light dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Livros</a>
                            <div class=""dropdown-menu"" aria-labelledby=""menuLivros"">
                                <a class=""dropdown-item"" href=""/Livro/Cadastro"" id=""menuLivros"">Cadastro</a>
                                <a class=""dropdown-item"" href=""/Livro/Listagem"" id=""menuLivros"">Listagem</a>
                            </div>
     ");
                WriteLiteral(@"                   </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link text-light dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Emprestimo</a>
                            <div class=""dropdown-menu"" aria-labelledby=""menuEmprestimo"">
                                <a class=""dropdown-item"" href=""/Emprestimo/Listagem"">Listagem</a>
                                <a class=""dropdown-item"" href=""/Emprestimo/Cadastro"">Cadastro</a>
                            </div>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link text-light dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Usuarios</a>
                            <div class=""dropdown-menu"" aria-labelledby=""menuUsuario"">
                                <a class=""dropdown-item"" href=""/Usuario/ListaUsuarios"">Listagem</a>
                                <a class=""dropdown-item"" href=""/Usuario/CadastrarUsuario"">Cadastro<");
                WriteLiteral("/a>\r\n                            </div>\r\n                        </li>\r\n                        <li");
                BeginWriteAttribute("class", " class=", 2856, "", 2863, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <a class=""nav-link text-light"" href=""/Usuario/Sair"">Logout</a>
                        </li>

                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 55 "D:\Senac TI\UC6\Biblioteca\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2019 - Biblioteca - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f288d426005ed817b2996b0f3e71110dd2e35416383", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </footer>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f288d426005ed817b2996b0f3e71110dd2e35418069", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f288d426005ed817b2996b0f3e71110dd2e35419169", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f288d426005ed817b2996b0f3e71110dd2e35420269", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#nullable restore
#line 67 "D:\Senac TI\UC6\Biblioteca\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 69 "D:\Senac TI\UC6\Biblioteca\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!--<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>!-->
    <script src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js""></script>
    <script>
        $.extend($.fn.dataTable.defaults, {
            searching: false,
            ordering:  false
        });
        $(document).ready(function () {
            $('#lista-emprestimo, #lista-livros').DataTable({
                language: {
                        ""emptyTable"": ""Nenhum registro encontrado"",
                        ""info"": ""Mostrando de _START_ at?? _END_ de _TOTAL_ registros"",
                        ""infoEmpty"": ""Mostrando 0 at?? 0 de 0 registros"",
                        ""infoFiltered"": ""(Filtrados de _MAX_ registros)"",
                        ""infoThousands"": ""."",
                        ""loadingRecords"": ""Carregando..."",
                        ""processing"": ""Processando..."",
                        ""zeroRecords"": ""Nenhum registro encontrado"",
                     ");
                WriteLiteral(@"   ""search"": ""Pesquisar"",
                        ""paginate"": {
                            ""next"": ""Pr??ximo"",
                            ""previous"": ""Anterior"",
                            ""first"": ""Primeiro"",
                            ""last"": ""??ltimo""
                        },
                        ""aria"": {
                            ""sortAscending"": "": Ordenar colunas de forma ascendente"",
                            ""sortDescending"": "": Ordenar colunas de forma descendente""
                        },
                        ""select"": {
                            ""rows"": {
                                ""_"": ""Selecionado %d linhas"",
                                ""1"": ""Selecionado 1 linha""
                            },
                            ""cells"": {
                                ""1"": ""1 c??lula selecionada"",
                                ""_"": ""%d c??lulas selecionadas""
                            },
                            ""columns"": {
                        ");
                WriteLiteral(@"        ""1"": ""1 coluna selecionada"",
                                ""_"": ""%d colunas selecionadas""
                            }
                        },
                        ""buttons"": {
                            ""copySuccess"": {
                                ""1"": ""Uma linha copiada com sucesso"",
                                ""_"": ""%d linhas copiadas com sucesso""
                            },
                            ""collection"": ""Cole????o  <span class=\""ui-button-icon-primary ui-icon ui-icon-triangle-1-s\""><\/span>"",
                            ""colvis"": ""Visibilidade da Coluna"",
                            ""colvisRestore"": ""Restaurar Visibilidade"",
                            ""copy"": ""Copiar"",
                            ""copyKeys"": ""Pressione ctrl ou u2318 + C para copiar os dados da tabela para a ??rea de transfer??ncia do sistema. Para cancelar, clique nesta mensagem ou pressione Esc.."",
                            ""copyTitle"": ""Copiar para a ??rea de Transfer??ncia"",
        ");
                WriteLiteral(@"                    ""csv"": ""CSV"",
                            ""excel"": ""Excel"",
                            ""pageLength"": {
                                ""-1"": ""Mostrar todos os registros"",
                                ""_"": ""Mostrar %d registros""
                            },
                            ""pdf"": ""PDF"",
                            ""print"": ""Imprimir"",
                            ""createState"": ""Criar estado"",
                            ""removeAllStates"": ""Remover todos os estados"",
                            ""removeState"": ""Remover"",
                            ""renameState"": ""Renomear"",
                            ""savedStates"": ""Estados salvos"",
                            ""stateRestore"": ""Estado %d"",
                            ""updateState"": ""Atualizar""
                        },
                        ""autoFill"": {
                            ""cancel"": ""Cancelar"",
                            ""fill"": ""Preencher todas as c??lulas com"",
                            ""f");
                WriteLiteral(@"illHorizontal"": ""Preencher c??lulas horizontalmente"",
                            ""fillVertical"": ""Preencher c??lulas verticalmente""
                        },
                        ""lengthMenu"": ""Exibir _MENU_ resultados por p??gina"",
                        ""searchBuilder"": {
                            ""add"": ""Adicionar Condi????o"",
                            ""button"": {
                                ""0"": ""Construtor de Pesquisa"",
                                ""_"": ""Construtor de Pesquisa (%d)""
                            },
                            ""clearAll"": ""Limpar Tudo"",
                            ""condition"": ""Condi????o"",
                            ""conditions"": {
                                ""date"": {
                                    ""after"": ""Depois"",
                                    ""before"": ""Antes"",
                                    ""between"": ""Entre"",
                                    ""empty"": ""Vazio"",
                                    ""equals"": ""Igual"",
");
                WriteLiteral(@"                                    ""not"": ""N??o"",
                                    ""notBetween"": ""N??o Entre"",
                                    ""notEmpty"": ""N??o Vazio""
                                },
                                ""number"": {
                                    ""between"": ""Entre"",
                                    ""empty"": ""Vazio"",
                                    ""equals"": ""Igual"",
                                    ""gt"": ""Maior Que"",
                                    ""gte"": ""Maior ou Igual a"",
                                    ""lt"": ""Menor Que"",
                                    ""lte"": ""Menor ou Igual a"",
                                    ""not"": ""N??o"",
                                    ""notBetween"": ""N??o Entre"",
                                    ""notEmpty"": ""N??o Vazio""
                                },
                                ""string"": {
                                    ""contains"": ""Cont??m"",
                                    ""empty""");
                WriteLiteral(@": ""Vazio"",
                                    ""endsWith"": ""Termina Com"",
                                    ""equals"": ""Igual"",
                                    ""not"": ""N??o"",
                                    ""notEmpty"": ""N??o Vazio"",
                                    ""startsWith"": ""Come??a Com"",
                                    ""notContains"": ""N??o cont??m"",
                                    ""notStarts"": ""N??o come??a com"",
                                    ""notEnds"": ""N??o termina com""
                                },
                                ""array"": {
                                    ""contains"": ""Cont??m"",
                                    ""empty"": ""Vazio"",
                                    ""equals"": ""Igual ??"",
                                    ""not"": ""N??o"",
                                    ""notEmpty"": ""N??o vazio"",
                                    ""without"": ""N??o possui""
                                }
                            },
                     ");
                WriteLiteral(@"       ""data"": ""Data"",
                            ""deleteTitle"": ""Excluir regra de filtragem"",
                            ""logicAnd"": ""E"",
                            ""logicOr"": ""Ou"",
                            ""title"": {
                                ""0"": ""Construtor de Pesquisa"",
                                ""_"": ""Construtor de Pesquisa (%d)""
                            },
                            ""value"": ""Valor"",
                            ""leftTitle"": ""Crit??rios Externos"",
                            ""rightTitle"": ""Crit??rios Internos""
                        },
                        ""searchPanes"": {
                            ""clearMessage"": ""Limpar Tudo"",
                            ""collapse"": {
                                ""0"": ""Pain??is de Pesquisa"",
                                ""_"": ""Pain??is de Pesquisa (%d)""
                            },
                            ""count"": ""{total}"",
                            ""countFiltered"": ""{shown} ({total})"",
        ");
                WriteLiteral(@"                    ""emptyPanes"": ""Nenhum Painel de Pesquisa"",
                            ""loadMessage"": ""Carregando Pain??is de Pesquisa..."",
                            ""title"": ""Filtros Ativos"",
                            ""showMessage"": ""Mostrar todos"",
                            ""collapseMessage"": ""Fechar todos""
                        },
                        ""thousands"": ""."",
                        ""datetime"": {
                            ""previous"": ""Anterior"",
                            ""next"": ""Pr??ximo"",
                            ""hours"": ""Hora"",
                            ""minutes"": ""Minuto"",
                            ""seconds"": ""Segundo"",
                            ""amPm"": [
                                ""am"",
                                ""pm""
                            ],
                            ""unknown"": ""-"",
                            ""months"": {
                                ""0"": ""Janeiro"",
                                ""1"": ""Fevereiro"",
       ");
                WriteLiteral(@"                         ""10"": ""Novembro"",
                                ""11"": ""Dezembro"",
                                ""2"": ""Mar??o"",
                                ""3"": ""Abril"",
                                ""4"": ""Maio"",
                                ""5"": ""Junho"",
                                ""6"": ""Julho"",
                                ""7"": ""Agosto"",
                                ""8"": ""Setembro"",
                                ""9"": ""Outubro""
                            },
                            ""weekdays"": [
                                ""Domingo"",
                                ""Segunda-feira"",
                                ""Ter??a-feira"",
                                ""Quarta-feira"",
                                ""Quinte-feira"",
                                ""Sexta-feira"",
                                ""S??bado""
                            ]
                        },
                        ""editor"": {
                            ""close"": ""Fechar"",
");
                WriteLiteral(@"                            ""create"": {
                                ""button"": ""Novo"",
                                ""submit"": ""Criar"",
                                ""title"": ""Criar novo registro""
                            },
                            ""edit"": {
                                ""button"": ""Editar"",
                                ""submit"": ""Atualizar"",
                                ""title"": ""Editar registro""
                            },
                            ""error"": {
                                ""system"": ""Ocorreu um erro no sistema (<a target=\""\\\"" rel=\""nofollow\"" href=\""\\\"">Mais informa????es<\/a>).""
                            },
                            ""multi"": {
                                ""noMulti"": ""Essa entrada pode ser editada individualmente, mas n??o como parte do grupo"",
                                ""restore"": ""Desfazer altera????es"",
                                ""title"": ""Multiplos valores"",
                                ""info");
                WriteLiteral(@""": ""Os itens selecionados cont??m valores diferentes para esta entrada. Para editar e definir todos os itens para esta entrada com o mesmo valor, clique ou toque aqui, caso contr??rio, eles manter??o seus valores individuais.""
                            },
                            ""remove"": {
                                ""button"": ""Remover"",
                                ""confirm"": {
                                    ""_"": ""Tem certeza que quer deletar %d linhas?"",
                                    ""1"": ""Tem certeza que quer deletar 1 linha?""
                                },
                                ""submit"": ""Remover"",
                                ""title"": ""Remover registro""
                            }
                        },
                        ""decimal"": "","",
                        ""stateRestore"": {
                            ""creationModal"": {
                                ""button"": ""Criar"",
                                ""columns"": {
                   ");
                WriteLiteral(@"                 ""search"": ""Busca de colunas"",
                                    ""visible"": ""Visibilidade da coluna""
                                },
                                ""name"": ""Nome:"",
                                ""order"": ""Ordernar"",
                                ""paging"": ""Pagina????o"",
                                ""scroller"": ""Posi????o da barra de rolagem"",
                                ""search"": ""Busca"",
                                ""searchBuilder"": ""Mecanismo de busca"",
                                ""select"": ""Selecionar"",
                                ""title"": ""Criar novo estado"",
                                ""toggleLabel"": ""Inclui:""
                            },
                            ""duplicateError"": ""J?? existe um estado com esse nome"",
                            ""emptyError"": ""N??o pode ser vazio"",
                            ""emptyStates"": ""Nenhum estado salvo"",
                            ""removeConfirm"": ""Confirma remover %s?"",
           ");
                WriteLiteral(@"                 ""removeError"": ""Falha ao remover estado"",
                            ""removeJoiner"": ""e"",
                            ""removeSubmit"": ""Remover"",
                            ""removeTitle"": ""Remover estado"",
                            ""renameButton"": ""Renomear"",
                            ""renameLabel"": ""Novo nome para %s:"",
                            ""renameTitle"": ""Renomear estado""
                        },
                }
            });
        });
    </script>
    <style>
        a.paginate_button {
            padding-right: 15px;
        }
    </style>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
