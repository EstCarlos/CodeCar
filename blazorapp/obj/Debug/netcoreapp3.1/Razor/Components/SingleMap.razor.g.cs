#pragma checksum "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Components\SingleMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636cd4c23b1c6a02d417201f27ca27202056fdf4"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorapp.Components
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
#line 2 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Components\SingleMap.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Components\SingleMap.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Components\SingleMap.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class SingleMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"map\" id=\"vista-mapa\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Gamer Ryzen 5\Desktop\CodeCar\CodeCar\blazorapp\Components\SingleMap.razor"
 
    [Parameter]
    public Guid TiD {get; set;}
    
    protected override async Task OnAfterRenderAsync(bool firstRender){
        if (firstRender){
            Coordinate c = await TS.GetCoordinate(TiD);
            string json = $"[{JsonSerializer.Serialize(c)}]";
             await runtime.InvokeVoidAsync("initMap", json, 15);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITesoroService TS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
    }
}
#pragma warning restore 1591
