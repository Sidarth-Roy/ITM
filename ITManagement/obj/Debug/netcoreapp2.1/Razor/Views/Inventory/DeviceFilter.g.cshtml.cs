#pragma checksum "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aafa818671251b34d4f9da3ebbca3172ac04921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_DeviceFilter), @"mvc.1.0.view", @"/Views/Inventory/DeviceFilter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/DeviceFilter.cshtml", typeof(AspNetCore.Views_Inventory_DeviceFilter))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\_ViewImports.cshtml"
using ITManagement;

#line default
#line hidden
#line 2 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\_ViewImports.cshtml"
using ITManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aafa818671251b34d4f9da3ebbca3172ac04921", @"/Views/Inventory/DeviceFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b61541cd5cdd77725fd89419e83e299edb6750e", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_DeviceFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITManagement.ViewModels.DeviceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 1288, true);
            WriteLiteral(@"
<style>
    /* Custom styles */
    .head {
        font-size: 2.5rem;
        font-weight: 600;
        text-align: center;
        margin-bottom: 20px;
        color: #333;
        text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.2);
    }


    .form-group {
        margin-bottom: 15px;
    }

    .form-control {
        border: 1px solid #ccc;
        border-radius: 4px;
        font-size: 1.2rem;
        padding: 10px;
        box-shadow: 1px 1px 2px rgba(0, 0, 0, 0.1);
    }

    .btn-primary {
        background-color: #333;
        border: none;
        padding: 10px 20px;
        border-radius: 5px;
        font-size: 1.4rem;
        cursor: pointer;
        box-shadow: 2px 2px 4px rgba(0, 0, 0, 0.2);
    }

        .btn-primary:hover {
            background-color: #555;
        }

    .table {
        background-color: #fff;
        border-radius: 10px;
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
    }

        .table th {
            background-color: #");
            WriteLiteral(@"333;
            color: #fff;
        }

        .table td {
            background-color: #f9f9f9;
        }
    .filter {
        font-size: 1.5rem;
    }
</style>

<h1 class=""head text-center"" style=""font-size: 5rem; margin: 30px"">INVENTORY</h1>

");
            EndContext();
#line 62 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
 using (Html.BeginForm("DeviceFilter", "Inventory", FormMethod.Get))
{

#line default
#line hidden
            BeginContext(1409, 126, true);
            WriteLiteral("    <div class=\"container filter\">\r\n        <div class=\"form-group row\">\r\n            <div class=\"col-md-3\">\r\n                ");
            EndContext();
            BeginContext(1536, 33, false);
#line 67 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.Label("Filter by Category:"));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1588, 168, false);
#line 68 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.DropDownListFor(model => model.SelectedCategoryId, new SelectList(Model.Category, "CategoryId", "CategoryName"), "All Categories", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                ");
            EndContext();
            BeginContext(1831, 31, false);
#line 71 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.Label("Filter by Status:"));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1881, 416, false);
#line 72 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.DropDownListFor(model => model.SelectedStatus, new SelectList(new List<SelectListItem>
                {
                    new SelectListItem { Text = "All", Value = "" },
                    new SelectListItem { Text = "Alloted", Value = "true" },
                    new SelectListItem { Text = "Unalloted", Value = "false" }
                }, "Value", "Text"), "All", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2297, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                ");
            EndContext();
            BeginContext(2372, 36, false);
#line 80 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.Label("Filter by Device Name:"));

#line default
#line hidden
            EndContext();
            BeginContext(2408, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2427, 83, false);
#line 81 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.TextBoxFor(model => model.SelectedDeviceName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                ");
            EndContext();
            BeginContext(2585, 34, false);
#line 84 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.Label("Filter by User Name:"));

#line default
#line hidden
            EndContext();
            BeginContext(2619, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2638, 81, false);
#line 85 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
           Write(Html.TextBoxFor(model => model.SelectedUserName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2719, 225, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">\r\n                    Filter\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 94 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
}

#line default
#line hidden
            BeginContext(2947, 309, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>Device ID</th>
            <th>Name</th>
            <th>Category</th>
            <th>Description</th>
            <th>Status</th>
            <th>User</th>
            <th>Alloted Date</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 109 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
         foreach (var device in Model.Device)
        {

#line default
#line hidden
            BeginContext(3314, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(3353, 15, false);
#line 112 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
               Write(device.DeviceId);

#line default
#line hidden
            EndContext();
            BeginContext(3368, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3396, 17, false);
#line 113 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
               Write(device.DeviceName);

#line default
#line hidden
            EndContext();
            BeginContext(3413, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3442, 59, false);
#line 114 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
                Write(device.Category != null ? device.Category.CategoryName : "");

#line default
#line hidden
            EndContext();
            BeginContext(3502, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3530, 18, false);
#line 115 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
               Write(device.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3548, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3577, 39, false);
#line 116 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
                Write(device.Status ? "Alloted" : "Unalloted");

#line default
#line hidden
            EndContext();
            BeginContext(3617, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3646, 47, false);
#line 117 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
                Write(device.User != null ? device.User.FullName : "");

#line default
#line hidden
            EndContext();
            BeginContext(3694, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3723, 81, false);
#line 118 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
                Write(device.AllotedDate != null ? device.AllotedDate.Value.ToString("MM/dd/yyyy") : "");

#line default
#line hidden
            EndContext();
            BeginContext(3805, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 120 "C:\Users\SidarthRoy\source\repos\ITManagement\IT_Management\ITManagement\Views\Inventory\DeviceFilter.cshtml"
        }

#line default
#line hidden
            BeginContext(3842, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITManagement.ViewModels.DeviceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
