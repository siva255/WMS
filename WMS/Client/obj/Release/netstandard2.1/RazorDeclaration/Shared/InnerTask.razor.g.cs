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
#line 1 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\InnerTask.razor"
using WMS.Client.DataLayer;

#line default
#line hidden
#nullable disable
    public partial class InnerTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Shared\InnerTask.razor"
       
    private bool collapseNavMenu = true;
    
    private bool hasPageName = true;
    private int prevMenuClickedMenu = 0;
    //public void ShowData()
    //{
    //    componentName = "SecondpageRightDiv";

    //}

    
    //Type[] types => Assembly.GetExecutingAssembly().GetTypes().Where(type => type.BaseType == typeof(ComponentBase)).ToArray();
    //Type selecteType;
    //RenderFragment RenderFragment;

    //private string _componentName;



    //public string componentName
    //{
    //    get { return _componentName; }
    //    set
    //    {
    //        _componentName = value;
    //        selecteType = types.Where(type => type.Name.ToUpper() == value.ToUpper())
    //            .FirstOrDefault() ?? typeof(SurveyPrompt);
    //        RenderFragment = (builder) =>
    //        {
    //            builder.OpenComponent(0, selecteType);
    //            builder.CloseComponent();
    //        };
    //    }
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InnerTaskService innerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WMS.Client.ValueShare clsvalueshare { get; set; }
    }
}
#pragma warning restore 1591
