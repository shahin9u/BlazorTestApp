#pragma checksum "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b15b12cb91a8581aa16399d9c93ba6a74ccc8d8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTestApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorTestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\RnD\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorTestApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
using BlazorTestApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddWindow")]
    public partial class AddWindow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Window</h2>\n<hr>\n\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                                                                obj.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Name = __value, obj.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Name\" class=\"control-label\">No of Window</label>\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "Name");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                                                                obj.QuantityOfWindows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.QuantityOfWindows = __value, obj.QuantityOfWindows));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Name\" class=\"control-label\">Total Sub Element</label>\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "form", "Name");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                                                                obj.TotalSubElements

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.TotalSubElements = __value, obj.TotalSubElements));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "<label for=\"Publisher\" class=\"control-label\">\n                    Order By\n                </label>\n                ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "for", "Publisher");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                                obj.OrderID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.OrderID = __value, obj.OrderID));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "0");
            __builder.AddAttribute(43, "disabled");
            __builder.AddAttribute(44, "selected");
            __builder.AddAttribute(45, "hidden");
            __builder.AddMarkupContent(46, "\n                        [Select Name]\n                    ");
            __builder.CloseElement();
#nullable restore
#line 34 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                     foreach (var publisher in orders)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", 
#nullable restore
#line 36 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                                        publisher.OrderID

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 37 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
__builder.AddContent(49, publisher.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 39 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-md-4");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                                                                        CreateWindow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, " \n                ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\AddWindow.razor"
       
    Window obj = new Window();
    List<Order> orders = new List<Order>();
    protected override async Task OnInitializedAsync()
    {

        orders = await windowService.GetAllOrdersAsync();
    }
    protected async void CreateWindow()
    {
        await windowService.InsertWindowAsync(obj);
        NavigationManager.NavigateTo("Employees");
    }
    void Cancel()
    {
       // NavigationManager.NavigateTo("Employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WindowService windowService { get; set; }
    }
}
#pragma warning restore 1591
