#pragma checksum "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4925194989809be8b9754c29d3630bad36937a62"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mr-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "form");
            __builder.AddAttribute(4, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 7 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                     HandleSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.AddMarkupContent(6, "<label for=\"titulo\">Nombre</label>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "required", true);
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "name", "nombre");
            __builder.AddAttribute(11, "id", "nombre");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                            tesoro.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tesoro.Name = __value, tesoro.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.AddMarkupContent(16, "<label for=\"valor\">Valor Monetario</label>\r\n        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "number");
            __builder.AddAttribute(19, "required", true);
            __builder.AddAttribute(20, "name", "valor");
            __builder.AddAttribute(21, "id", "valor");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                                          tesoro.Valor

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tesoro.Valor = __value, tesoro.Valor, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        \r\n        ");
            __builder.AddMarkupContent(26, "<label for=\"valor\">Peso</label>\r\n        ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "number");
            __builder.AddAttribute(29, "required", true);
            __builder.AddAttribute(30, "name", "peso");
            __builder.AddAttribute(31, "id", "peso");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                                          tesoro.Weight

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tesoro.Weight = __value, tesoro.Weight, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n        ");
            __builder.AddMarkupContent(36, "<label for=\"fecha\">Fecha</label>\r\n        ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "date");
            __builder.AddAttribute(39, "required", true);
            __builder.AddAttribute(40, "name", "fecha");
            __builder.AddAttribute(41, "id", "fecha");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                                        tesoro.Date

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tesoro.Date = __value, tesoro.Date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n        ");
            __builder.AddMarkupContent(46, "<label for=\"lugar\">Lugar</label>\r\n        ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "required", true);
            __builder.AddAttribute(50, "name", "lugar");
            __builder.AddAttribute(51, "id", "lugar");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                                        tesoro.Lugar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tesoro.Lugar = __value, tesoro.Lugar));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n        ");
            __builder.AddMarkupContent(56, "<label for=\"lat\">Latitud</label>\r\n        ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "number");
            __builder.AddAttribute(59, "required", true);
            __builder.AddAttribute(60, "step", "any");
            __builder.AddAttribute(61, "name", "lat");
            __builder.AddAttribute(62, "id", "lat");
            __builder.AddAttribute(63, "class", "form-control");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                                          coord.Lat

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => coord.Lat = __value, coord.Lat, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n        ");
            __builder.AddMarkupContent(67, "<label for=\"lon\">Longitud</label>\r\n        ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "number");
            __builder.AddAttribute(70, "required", true);
            __builder.AddAttribute(71, "step", "any");
            __builder.AddAttribute(72, "name", "lon");
            __builder.AddAttribute(73, "id", "lon");
            __builder.AddAttribute(74, "class", "form-control");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                                          coord.Lng

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => coord.Lng = __value, coord.Lng, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        \r\n        ");
            __builder.AddMarkupContent(78, "<label for=\"url\">Url de referencia</label>\r\n        ");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "url");
            __builder.AddAttribute(81, "required", true);
            __builder.AddAttribute(82, "step", "any");
            __builder.AddAttribute(83, "name", "lon");
            __builder.AddAttribute(84, "id", "lon");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                                       tesoro.UrlRef

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tesoro.UrlRef = __value, tesoro.UrlRef));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\r\n        ");
            __builder.AddMarkupContent(89, "<label for=\"descripcion\">Descripción</label>\r\n        ");
            __builder.OpenElement(90, "textarea");
            __builder.AddAttribute(91, "required", true);
            __builder.AddAttribute(92, "name", "descripcion");
            __builder.AddAttribute(93, "id", "descripcion");
            __builder.AddAttribute(94, "cols", "30");
            __builder.AddAttribute(95, "rows", "4");
            __builder.AddAttribute(96, "class", "form-control");
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\p3\CodeGit\CodeCar\blazorapp\Components\AgregarTesoros.razor"
                         tesoro.Descripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tesoro.Descripcion = __value, tesoro.Descripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        <br>\r\n        <input type=\"submit\" value=\"Ägregar\" class=\"btn btn-success\">\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
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