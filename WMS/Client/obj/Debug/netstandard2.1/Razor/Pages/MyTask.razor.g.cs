#pragma checksum "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "912c141c651e9db090acde558df025b40292557d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tabBodyInner tabShow");
            __builder.AddAttribute(2, "id", "MyTasks");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "viewPortArea gridView");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "mytaskArea");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<div class=""subHeadList"">
                <div class=""searchArea"">
                    <span class=""material-icons"">
                        search
                    </span>
                    <input type=""text"" class=""searchInput"" placeholder=""Search projects"">
                    <span class=""material-icons filterIcons"">
                        filter_list
                    </span>
                </div>
                <div class=""viewPort"" style=""display:flex"">
                    <ul class=""viewPortList"">
                        <li class=""active"">
                            <button class=""gridView"" title=""Grid"">
                                <span class=""material-icons"">
                                    grid_view
                                </span>
                            </button>
                        </li>
                        <li class=""list-group"">
                            <button class=""listView"" title=""List"">
                                <span class=""material-icons"">
                                    list
                                </span>
                            </button>
                        </li>
                    </ul>
                </div>
            </div>
            ");
            __builder.OpenComponent<WMS.Client.Shared.TaskCalender>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "boxes");
            __builder.AddMarkupContent(15, "\r\n\r\n\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "id", "leftbox");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "taskListArea");
            __builder.AddAttribute(21, "href", "mytask/one");
            __builder.AddAttribute(22, "Match", "NavLinkMatch.All");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row taskAreaList");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 51 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                             if (innerService == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                                ");
            __builder.AddMarkupContent(28, "<p><em>Loading.....</em></p>\r\n");
#nullable restore
#line 54 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                 foreach (var in1 in innerList)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                                    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-lg-12 groupTask");
            __builder.AddMarkupContent(32, "\r\n                                        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "groupTaskHead active");
            __builder.AddMarkupContent(35, "\r\n                                            ");
            __builder.OpenElement(36, "h2");
            __builder.AddContent(37, 
#nullable restore
#line 61 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                 in1.ListName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                            ");
            __builder.AddMarkupContent(39, "<span class=\"material-icons\">\r\n                                                expand_more\r\n                                            </span>\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "groupTaskInner active");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                                                     showright

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                                            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row groupTaskInnerBox");
            __builder.AddMarkupContent(47, "\r\n                                                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-lg-2 taskAreaListBox");
            __builder.AddMarkupContent(50, "\r\n                                                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "taskAreaListInner riskTask active");
            __builder.AddAttribute(53, "style", "width:400px");
            __builder.AddMarkupContent(54, "\r\n                                                        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "taskInnerHead");
            __builder.AddMarkupContent(57, "\r\n                                                            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "taskInnerHeadLeft");
            __builder.AddMarkupContent(60, "\r\n                                                                ");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "class", "checkBoxLabel");
            __builder.AddMarkupContent(63, "\r\n                                                                    ");
            __builder.AddContent(64, 
#nullable restore
#line 73 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                                     in1.Checkboxname

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, "\r\n                                                                    ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "checkbox");
            __builder.AddAttribute(68, "checked", "checked");
            __builder.AddAttribute(69, "id", 
#nullable restore
#line 74 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                                                                                  in1.CheckboxId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                                                    <span class=\"checkBoxMark\"></span>\r\n                                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                                                ");
            __builder.AddMarkupContent(72, @"<span class=""material-icons taskIcons taskRisk"">
                                                                    double_arrow
                                                                </span>
                                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                                            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "taskInnerHeadright");
            __builder.AddMarkupContent(76, "\r\n                                                                ");
            __builder.AddMarkupContent(77, @"<div class=""markedArea"">
                                                                    <span class=""material-icons-outlined"">
                                                                        grade
                                                                    </span>
                                                                    <span class=""material-icons"">
                                                                        grade
                                                                    </span>
                                                                </div>
                                                                ");
            __builder.OpenElement(78, "p");
            __builder.AddContent(79, 
#nullable restore
#line 90 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                                    in1.dateTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                                        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "taskInnerContent");
            __builder.AddMarkupContent(85, "\r\n                                                            ");
            __builder.OpenElement(86, "h2");
            __builder.AddAttribute(87, "style", "overflow:unset");
            __builder.AddMarkupContent(88, "\r\n                                                                ");
            __builder.AddContent(89, 
#nullable restore
#line 95 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                                 in1.projectdescrptionc1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "\r\n                                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                                            ");
            __builder.OpenElement(92, "p");
            __builder.AddAttribute(93, "style", "overflow:unset");
            __builder.AddMarkupContent(94, "\r\n                                                                ");
            __builder.AddContent(95, 
#nullable restore
#line 98 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                                 in1.projectdescrptionc2

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(96, "\r\n                                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                                        ");
            __builder.OpenElement(99, "span");
            __builder.AddAttribute(100, "class", "stageMessage risk");
            __builder.AddContent(101, 
#nullable restore
#line 101 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                                                                         in1.stageactivity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 107 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "\r\n\r\n\r\n\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\r\n                ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "id", "rightbox");
            __builder.AddAttribute(114, "style", "padding-left: 20px;padding-right: 20px");
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 119 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                     if (RenderFragment != null)
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, 
#nullable restore
#line 120 "C:\Users\Rock$tar\source\repos\WMS\WMS\Client\Pages\MyTask.razor"
                         RenderFragment

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(117, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
            __builder.CloseElement();
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
