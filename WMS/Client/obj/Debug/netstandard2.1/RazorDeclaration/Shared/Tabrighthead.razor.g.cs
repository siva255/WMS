// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WMS.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using WMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using WMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\Tabrighthead.razor"
using WMS.Client.DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\Tabrighthead.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class Tabrighthead : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\Tabrighthead.razor"
       
    private bool collapseNavMenu = true;
    private bool expandSubNav;
    private int ClickedMenu = 0;
    private bool hasPageName = true;
    private int prevMenuClickedMenu = 0;
    private WMS.Client.Pages.MyTask sss;



    public IEnumerable<TabheadrightInfo> tabrightlist;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        if (hasPageName)
        {
            collapseNavMenu = !collapseNavMenu;
        }

    }


    protected override async Task OnInitializedAsync()
    {

        tabrightlist = await tabRightService.GetTabheadrightInfos();
    }

    public void demo()
    {
      
        JS.InvokeAsync<string>("closebuttonjs");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TabheadrightService tabRightService { get; set; }
    }
}
#pragma warning restore 1591