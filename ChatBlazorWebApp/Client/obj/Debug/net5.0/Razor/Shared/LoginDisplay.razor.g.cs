#pragma checksum "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cef83ee7091da870e3a33acf9392c1037a55ff6"
// <auto-generated/>
#pragma warning disable 1591
namespace ChatBlazorWebApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using ChatBlazorWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using ChatBlazorWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using ChatBlazorWebApp.Client.Managers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "pa-4 justify-center my-4 mud-text-align-center");
                __builder2.OpenComponent<MudBlazor.MudButton>(4);
                __builder2.AddAttribute(5, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 10 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                                       Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Link", "authentication/profile");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(9, "Hi, ");
                    __builder3.AddContent(10, 
#nullable restore
#line 10 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                                                                                         context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(11, "!");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudButton>(13);
                __builder2.AddAttribute(14, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 11 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                                       Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                                                               BeginSignOut

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Log Out");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(19, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "pa-4 justify-center my-4 mud-text-align-center");
                __builder2.OpenComponent<MudBlazor.MudButton>(22);
                __builder2.AddAttribute(23, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 16 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                                       Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Link", "authentication/register");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, "Register");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudButton>(29);
                __builder2.AddAttribute(30, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 17 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
                                                       Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Link", "authentication/login");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(34, "Log in");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\LoginDisplay.razor"
       private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChatManager _chatManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
