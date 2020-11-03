#pragma checksum "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4925194989809be8b9754c29d3630bad36937a62"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorapp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using blazorapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\p3\CodeGit\CodeCar\blazorapp\_Imports.razor"
using blazorapp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
using Services;

#line default
#line hidden
#nullable disable
    public partial class AgregarTesoros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
 
    [Parameter]
    public Guid Uid {get; set;}
    private Tesoro tesoro = new Tesoro
    {
        Id = Guid.NewGuid(),
        Date = DateTime.Today
    };
    private Coordinate coord = new Coordinate 
    {
        Id = Guid.NewGuid()
    };
     private async Task HandleSubmit()
    {
        Console.WriteLine("Se inició el guardado");
        tesoro.Coordinates = coord;
        var status = await TS.SetTesoro(tesoro);
        if(status)
        {
            tesoro = new Tesoro
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Today
            };
            coord = new Coordinate 
            {
                Id = Guid.NewGuid()
            };
            StateHasChanged();
        }
        //Console.WriteLine(status);
        //Console.WriteLine("Finalizo el Guardado");
    }
    protected override void OnAfterRender(bool firstRender)
    {
        if(firstRender)
        {
            if(Uid != null)
            {
                coord.Tid = tesoro.Id;
                coord.Uid = Uid;
                tesoro.Uid = Uid;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITesoroService TS { get; set; }
    }
}
#pragma warning restore 1591