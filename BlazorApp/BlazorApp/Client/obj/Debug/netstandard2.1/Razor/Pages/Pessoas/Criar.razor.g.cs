#pragma checksum "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Criar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c82691c179b3346f277ec9145f9259d740f9cdc"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pessoas/Criar")]
    public partial class Criar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastrar Pessoa</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorApp.Client.Pages.Pessoas.FormPessoa>(1);
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Criar.razor"
                            CriarPessoa

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "TextoSubmit", "Adicionar");
            __builder.AddAttribute(4, "Pessoa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Shared.Models.Pessoa>(
#nullable restore
#line 7 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Criar.razor"
                                                                          pessoa

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\Criar.razor"
       
    Pessoa pessoa = new Pessoa();

    async Task CriarPessoa()
    {
        await http.PostJsonAsync("api/Pessoa", pessoa);
        navManager.NavigateTo("Pessoas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
