// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectTracker.Ui.Blazor.Shared
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
    public partial class TextArea : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\staub\source\repos\CSLA_ProjectTracker\ProjectTracker\ProjectTracker.Ui.Blazor\Shared\TextArea.razor"
       
  [Parameter]
  public Csla.Blazor.IPropertyInfo Property { get; set; }
  [Parameter]
  public int rows { get; set; }

  private string TextValue
  {
    get => (string)Property.Value;
    set => Property.Value = value;
  }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
