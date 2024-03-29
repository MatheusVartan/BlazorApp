#pragma checksum "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f542d7ee690d79a19b72e89fa701ab2f7be31b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Client.Pages.Pessoas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pessoas/Listar")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pessoas")]
    public partial class Listar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listar</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a href=\"Pessoas/Criar\" class=\"btn btn-success\"><em class=\"oi oi-plus\"></em> Criar</a>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 12 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
     if (pessoas == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<p>Carregando...</p>\r\n");
#nullable restore
#line 15 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
    }
    else if (!pessoas.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.AddMarkupContent(7, "<p>Não há pessoas cadastradas</p>\r\n");
#nullable restore
#line 19 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<thead>\r\n                <tr>\r\n                    <th>Id</th>\r\n                    <th>Nome</th>\r\n                    <th>Idade</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 32 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
                 foreach (var pessoa in pessoas)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                    ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 35 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
                             pessoa.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 36 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
                             pessoa.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 37 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
                             pessoa.Idade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "href", "Pessoas/Editar/" + (
#nullable restore
#line 39 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
                                                                             pessoa.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<em class=\"oi oi-pencil\"></em>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
                                                                     () => Excluir(pessoa.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<em class=\"oi oi-trash\"></em>");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 43 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 46 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Listar.razor"
       
    List<Pessoa> pessoas;

    protected override async Task OnInitializedAsync()
    {
        await LoadPessoas();
    }

    async Task LoadPessoas()
    {
        pessoas = await http.GetJsonAsync<List<Pessoa>>("api/Pessoa");
    }

    async Task Excluir(int id)
    {
        await http.DeleteAsync($"api/Pessoa/{id}");
        await LoadPessoas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
