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
#line 1 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using ProjectTracker.Ui.Blazor;

#line default
#line hidden
#line 9 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using ProjectTracker.Ui.Blazor.Shared;

#line default
#line hidden
#line 1 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\Shared\NavMenu.razor"
using Csla.Blazor;

#line default
#line hidden
#line 2 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\Shared\NavMenu.razor"
using Csla.Rules;

#line default
#line hidden
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Users\staub\Source\Repos\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\Shared\NavMenu.razor"
       
  private bool collapseNavMenu = true;

  private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

  private void ToggleNavMenu()
  {
    collapseNavMenu = !collapseNavMenu;
  }

#line default
#line hidden
    }
}
#pragma warning restore 1591
