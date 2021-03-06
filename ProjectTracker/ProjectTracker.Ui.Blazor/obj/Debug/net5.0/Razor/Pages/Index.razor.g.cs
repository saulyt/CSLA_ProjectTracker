#pragma checksum "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b02aa632f828c54a6f53168bbdd26de382d14e"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectTracker.Ui.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using ProjectTracker.Ui.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using ProjectTracker.Ui.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
using ProjectTracker.Library;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Project Tracker</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Welcome to the project tracker sample app.</p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddAttribute(3, "class", "text-danger");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
                        vm.ViewModelErrorText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
 if (vm.Model != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.OpenElement(6, "tbody");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "<td>Projects</td>");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
                                vm.Model.ProjectCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n      ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "<td>Open projects</td>");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
                                     vm.Model.OpenProjectCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n      ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<td>Resources</td>");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 17 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
                                 vm.Model.ResourceCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p>Loading data...</p>");
#nullable restore
#line 24 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Index.razor"
       
  protected override async Task OnParametersSetAsync()
  {
    await vm.RefreshAsync(() => Csla.DataPortal.FetchAsync<Dashboard>());
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Csla.Blazor.ViewModel<Dashboard> vm { get; set; }
    }
}
#pragma warning restore 1591
