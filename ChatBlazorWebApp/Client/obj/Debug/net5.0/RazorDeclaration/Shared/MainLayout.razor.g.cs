// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 2 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\MainLayout.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\Github\FernandoCalmet\CS-Blazor-Chat\ChatBlazorWebApp\Client\Shared\MainLayout.razor"
        bool _drawerOpen = false;
            private string CurrentUserId { get; set; }
            void DrawerToggle()
            {
                _drawerOpen = !_drawerOpen;
            }
            private HubConnection hubConnection;
            public bool IsConnected => hubConnection.State == HubConnectionState.Connected;
            protected override async Task OnInitializedAsync()
            {
                hubConnection = new HubConnectionBuilder().WithUrl(_navigationManager.ToAbsoluteUri("/signalRHub")).Build();
                await hubConnection.StartAsync();
                hubConnection.On<string, string, string>("ReceiveChatNotification", (message, receiverUserId, senderUserId) =>
                {
                    if (CurrentUserId == receiverUserId)
                    {
                        _jsRuntime.InvokeAsync<string>("PlayAudio", "notification");
                        _snackBar.Add(message, Severity.Info, config =>
                                        {
                                            config.VisibleStateDuration = 10000;
                                            config.HideTransitionDuration = 500;
                                            config.ShowTransitionDuration = 500;
                                            config.Action = "Chat?";
                                            config.ActionColor = Color.Info;
                                            config.Onclick = snackbar =>
                                    {
                                _navigationManager.NavigateTo($"chat/{senderUserId}");
                                return Task.CompletedTask;
                            };
                                        });
                    }
                });
                var state = await _stateProvider.GetAuthenticationStateAsync();
                var user = state.User;
                CurrentUserId = user.Claims.Where(a => a.Type == "sub").Select(a => a.Value).FirstOrDefault();
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChatManager _chatManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
