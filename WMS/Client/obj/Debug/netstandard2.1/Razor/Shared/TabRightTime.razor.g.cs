#pragma checksum "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\TabRightTime.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b687f4592df8cc079508563caede185fd250a0"
// <auto-generated/>
#pragma warning disable 1591
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
#line 7 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\_Imports.razor"
using Microsoft.JSInterop;

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
#line 1 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\TabRightTime.razor"
using WMS.Client.DataLayer;

#line default
#line hidden
#nullable disable
    public partial class TabRightTime : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""taskTimeArea"">
    <div class=""taskTimeAreainner"">
        <div class=""taskTimeAreainnerLeft"">
            Start Time
        </div>
        <div class=""taskTimeAreainnerRight"">
            <span>6:88 am</span>, Tuesday
        </div>
    </div>
    <div class=""taskTimeAreainner"">
        <div class=""taskTimeAreainnerLeft"">
            Exstimated TAT
        </div>
        <div class=""taskTimeAreainnerRight"">
            <span>8:88 am</span>, Tuesday[2 Hrs]
        </div>
    </div>
    <div class=""taskTimeAreainner"">
        <div class=""taskTimeAreainnerLeft"">
            Due in
        </div>
        <div class=""taskTimeAreainnerRight"">
            1 Hr 55 Mins
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\TabRightTime.razor"
       
    private bool collapseNavMenu = true;
    private bool expandSubNav;
    private int ClickedMenu = 0;
    private bool hasPageName = true;
    private int prevMenuClickedMenu = 0;

    public IEnumerable<TabRightTimeInfo> RightTimeList;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        if (hasPageName)
        {
            collapseNavMenu = !collapseNavMenu;
        }

    }
    public void GetIsClicked(MenuInfo mn)
    {
        ClickedMenu = mn.MenuId;
        if (prevMenuClickedMenu != ClickedMenu)
        {
            expandSubNav = false;
            if (mn.PageName != "" || mn.MenuName == "My Bin")
            {
                hasPageName = true;
            }
            else
            {
                expandSubNav = !expandSubNav;
                hasPageName = false;
            }
        }
        else
        {
            expandSubNav = !expandSubNav;
        }
        prevMenuClickedMenu = ClickedMenu;
    }
    protected override async Task OnInitializedAsync()
    {
        RightTimeList = await TimeService.GetTabRightTimeInfos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TabRightTimeService TimeService { get; set; }
    }
}
#pragma warning restore 1591
