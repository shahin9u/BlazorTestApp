#pragma checksum "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af3b087c671fe25d3c8f371cac7709241491f2a1"
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
#line 2 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
using BlazorTestApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployee/{Id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Employee</h2>\n<hr>\n\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "form", "Name");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
                                                                obj.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Id = __value, obj.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddMarkupContent(16, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "form", "Name");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
                                                                obj.EmployeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.EmployeName = __value, obj.EmployeName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "<label for=\"Gender\" class=\"control-label\"></label>\n                ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
                                obj.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Gender = __value, obj.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value");
            __builder.AddContent(32, "-Select Gender");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "Male");
            __builder.AddContent(36, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                    ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "Female");
            __builder.AddContent(40, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "<label for=\"Designation\" class=\"control-label\">Designation</label>\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "form", "Designation");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
                                                                       obj.Designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Designation = __value, obj.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.AddMarkupContent(53, "<label for=\"City\" class=\"control-label\">City</label>\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "form", "City");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
                                                                obj.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.City = __value, obj.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-md-4");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "btn btn-primary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
                                                                        UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n                ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "class", "btn btn-primary");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\RnD\BlazorCRUD\BlazorCRUD\Pages\EditEmployee.razor"
       
    [Parameter]
    public string Id { get; set; }
    Employee obj = new Employee();
    protected override async Task OnInitializedAsync()
    {
        //obj = await Task.Run(() => employeeService.GetEmployeeAsync(Convert.ToInt32(Id)));
    }
    protected async void UpdateEmployee()
    {
       // await employeeService.UpdateEmployeeAsync(obj);
        NavigationManager.NavigateTo("Employees");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591