#pragma checksum "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Pages\MapaPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a2c76cfd21884bfe752f1c817e84811a875a108"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using blazorapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\_Imports.razor"
using blazorapp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Pages\MapaPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Pages\MapaPage.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Pages\MapaPage.razor"
using blazorapp.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapa")]
    public partial class MapaPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenComponent<blazorapp.Components.Mapa>(3);
                __builder2.AddAttribute(4, "TID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Pages\MapaPage.razor"
                    userId

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, @"<div class=""card text-center"">
            <div class=""card-body"">
                <p class=""h2"">
                    Aqui Se visualiza el mapa <b>Inicie sesion</b> para visualizar el mapa con su ubicaciona agregada
                </p>
            </div>
        </div>
    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Pages\MapaPage.razor"
 
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    private string userId;
    protected override async Task OnInitializedAsync(){
        var authState = await authenticationStateTask;
        if(authState.User.Identity.IsAuthenticated){
            AppUser user = await UserManager.GetUserAsync(authState.User);
            userId = user.Uid.ToString();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AppUser> UserManager { get; set; }
    }
}
#pragma warning restore 1591
