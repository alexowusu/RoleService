#pragma checksum "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\Pages\MyPages\Employee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c675affa0cc33ba7adb5a6a9ae37cbe7c15bd57"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RoleServiceUI.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using RoleServiceUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\_Imports.razor"
using RoleServiceUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\Pages\MyPages\Employee.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\Pages\MyPages\Employee.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Employee")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Alex\Desktop\workhome\RoleService\RoleServiceUI\Pages\MyPages\Employee.razor"
       
    private List<EmployeeModel> employees;

    protected override async Task OnInitializedAsync()
    {
        employees = await this.db.GetEmployee;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeData db { get; set; }
    }
}
#pragma warning restore 1591
