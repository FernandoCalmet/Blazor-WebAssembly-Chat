#pragma checksum "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ef122ecf9289bb51030cc31fe47f5939618aaeb"
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
#line 1 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using ChatBlazorWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using ChatBlazorWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\_Imports.razor"
using ChatBlazorWebApp.Client.Managers;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Href", "/home");
                __builder2.AddAttribute(4, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\Shared\NavMenu.razor"
                                    Icons.Material.Outlined.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\n        Home\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(8);
                __builder2.AddAttribute(9, "Href", "/chat");
                __builder2.AddAttribute(10, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\Shared\NavMenu.razor"
                                    Icons.Material.Outlined.Dashboard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\n        Chat\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(14);
                __builder2.AddAttribute(15, "Href", "https://codewithmukesh.com/blog/realtime-chat-application-with-blazor/");
                __builder2.AddAttribute(16, "Target", "_blank");
                __builder2.AddAttribute(17, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\ChatBlazorWebApp\Client\Shared\NavMenu.razor"
                                                                                                                     Icons.Material.Outlined.QuestionAnswer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\n        Documentation / Guide\n    ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChatManager _chatManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
