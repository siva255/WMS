// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WMS.Client.Pages
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
#line 1 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
using WMS.Client.DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mytask")]
    public partial class MyTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
       
    //[Parameter]
    //public string cname { get { return ""; } set { componentName = cname; } }
    private bool collapseNavMenu = true;
    private bool expandSubNav;
    private int ClickedMenu = 0;
    private bool hasPageName = true;
    private int prevMenuClickedMenu = 0;

    public IEnumerable<InnerTaskInfo> innerList;

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
        innerList = await innerService.GetInnerTaskInfos();
    }

    [Parameter]
    public string sampledemo { get; set; }



    Type[] types => Assembly.GetExecutingAssembly().GetTypes().Where(type => type.BaseType == typeof(ComponentBase)).ToArray();
    Type selecteType;
  
    public RenderFragment RenderFragment;

    private string _componentName;

    public void showright()
    {

        componentName = "SecondpageRightDiv";

    }
    public void demo1()
    {

        componentName = "two";

    }
    protected void CallCSMethod()
    {
        componentName = "two";
    }


    [JSInvokable]
    public void CSCallBackMethod()
    {
        componentName = "two";
    }
    public string componentName
    {
        get { return _componentName; }
        set
        {
            _componentName = value;
            selecteType = types.Where(type => type.Name != null && type.Name.ToUpper() == value.ToUpper())
               .FirstOrDefault() ?? typeof(SurveyPrompt);
            RenderFragment = (builder) =>
            {
                builder.OpenComponent(0, selecteType);
                builder.CloseComponent();
            };
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InnerTaskService innerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WMS.Client.ValueShare clsvalueshare { get; set; }
    }
}
#pragma warning restore 1591
