#pragma checksum "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc48ec40580e0f78804dadeb7fd4e995e40366a"
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
#line 2 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
using BlazorTestApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/WindowInfo")]
    public partial class WindowInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddWindow");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<span class=\"oi oi-plus\" aria-hidden=\"true\">Add New</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Window Info</h1>");
#nullable restore
#line 10 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
 if (WindowObj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading... !</em></p>");
#nullable restore
#line 13 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Window Id</th>\r\n                <th>Name</th>\r\n                <th>Action</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 25 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
             foreach (var ord in WindowObj)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
#nullable restore
#line 28 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
__builder.AddContent(14, ord.OrderID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 29 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
__builder.AddContent(17, ord.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\WindowInfo.razor"
       
    List<Window> WindowObj;
    protected override async Task OnInitializedAsync()
    {
        WindowObj = await Task.Run(() => windowService.GetAllWindowAsync());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WindowService windowService { get; set; }
    }
}
#pragma warning restore 1591
