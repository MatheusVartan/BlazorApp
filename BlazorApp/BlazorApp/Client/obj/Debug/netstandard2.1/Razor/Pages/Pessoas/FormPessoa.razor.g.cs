#pragma checksum "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "257ee1e747b58655d33fdc7ed048bb0329780559"
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
    public partial class FormPessoa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
                  Pessoa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
                                          OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Nome</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
                                Pessoa.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pessoa.Nome = __value, Pessoa.Nome))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Pessoa.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __Blazor.BlazorApp.Client.Pages.Pessoas.FormPessoa.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 7 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
                                  () => Pessoa.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.AddMarkupContent(23, "<label>Data de Nascimento</label>\r\n        ");
                __Blazor.BlazorApp.Client.Pages.Pessoas.FormPessoa.TypeInference.CreateInputDate_1(__builder2, 24, 25, 
#nullable restore
#line 12 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
                                Pessoa.DataDeNascimento

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pessoa.DataDeNascimento = __value, Pessoa.DataDeNascimento)), 27, () => Pessoa.DataDeNascimento);
                __builder2.AddMarkupContent(28, "\r\n        ");
                __Blazor.BlazorApp.Client.Pages.Pessoas.FormPessoa.TypeInference.CreateValidationMessage_2(__builder2, 29, 30, 
#nullable restore
#line 13 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
                                  () => Pessoa.DataDeNascimento

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n    ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "class", "btn btn-success");
                __builder2.AddMarkupContent(35, "<em class=\"oi oi-check\"></em> ");
                __builder2.AddContent(36, 
#nullable restore
#line 16 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
                                                                   TextoSubmit

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\mathe\Documents\Repositorios\BlazorApp\BlazorApp\BlazorApp\Client\Pages\Pessoas\FormPessoa.razor"
       
    [Parameter]
    public Pessoa Pessoa { get; set; }

    [Parameter]
    public string TextoSubmit { get; set; }

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorApp.Client.Pages.Pessoas.FormPessoa
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591