#pragma checksum "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6597ece55a2beaa39fcaeae4de8d8b065315611f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuditoriumCapacity_ViewData), @"mvc.1.0.view", @"/Views/AuditoriumCapacity/ViewData.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\_ViewImports.cshtml"
using OHSB.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\_ViewImports.cshtml"
using OHSB.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6597ece55a2beaa39fcaeae4de8d8b065315611f", @"/Views/AuditoriumCapacity/ViewData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a829e92a7bfae1ff847eeec8b85f22380344f12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AuditoriumCapacity_ViewData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OHSB.Domain.Row_SeatMaster.RowSeatEntity>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AuditoriumCapacity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
  
    ViewData["Title"] = "ViewData";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";
    var ResultData = ViewBag.Result as List<OHSB.Domain.Row_SeatMaster.RowSeatEntity>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb p-0 mb-0 bg-transparent"" id=""navigation"">
            </ol>
        </nav>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs nav-fill"" role=""tablist"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6597ece55a2beaa39fcaeae4de8d8b065315611f5829", async() => {
                WriteLiteral("AddAuditoriumCapacity");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6597ece55a2beaa39fcaeae4de8d8b065315611f7308", async() => {
                WriteLiteral("ViewAuditoriumCapacity");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </ul>\r\n                <div class=\"indicatorslist\">\r\n                    <a");
            BeginWriteAttribute("title", " title=\"", 1025, "\"", 1033, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>
");
            WriteLiteral("            <div class=\"card-body \">\r\n");
#nullable restore
#line 33 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                 if (ResultData != null && ResultData.ToList().Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table data-toggle=""table"" id=""tblHospital"" class=""table"">
                            <thead>
                                <tr>
                                    <th width=""60px"" class=""align-top text-center"">Sl#</th>
                                    <th width=""150px"" class=""align-top"">
                                        Auditorium Name
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Row
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        No Of Seats
                                    </th>
                                    <th width=""150px"" class=""align-top"">Action</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 54 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 60 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 62 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                                       Write(list.AuditoriumName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 65 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                                       Write(list.Row_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 69 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                                       Write(list.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            WriteLiteral("                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3677, "\"", 3725, 3);
            WriteAttributeValue("", 3687, "updateDepartment(\'", 3687, 18, true);
#nullable restore
#line 73 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
WriteAttributeValue("", 3705, list.AuditseatID, 3705, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3722, "\');", 3722, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary mr-3\"");
            BeginWriteAttribute("title", " title=\"", 3752, "\"", 3760, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Edit\"><i class=\"icon-edit1\"></i><b>Edit</b></a><br />\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3884, "\"", 3928, 3);
            WriteAttributeValue("", 3894, "deleteDoctor(\'", 3894, 14, true);
#nullable restore
#line 74 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
WriteAttributeValue("", 3908, list.AuditseatID, 3908, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3925, "\');", 3925, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"");
            BeginWriteAttribute("title", " title=\"", 3949, "\"", 3957, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Delete\"><i class=\"icon-trash-21\"></i><b>Delete</b></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 82 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 86 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\AuditoriumCapacity\ViewData.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"clearfix col-sm-12\"></div>\r\n            </div>\r\n");
            WriteLiteral(@"
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        getDataTable();
    })

    function updateDepartment(AuditseatID) {
        if (confirm(""Are you sure you want to update ?"")) {
            location.href = ""/AuditoriumCapacity/Add?AuditseatID="" + AuditseatID;
        }
    }

    function deleteDoctor(AuditseatID) {
        if (confirm(""Are you sure you want to delete ?"")) {
            $.ajax({
                url: ""/AuditoriumCapacity/Delete?AuditseatID="" + AuditseatID,
                type: ""POST"",
                dataType: ""json"",
                contentType: ""application/json;charset=UTF-8"",
                success: function (data) {
                    if (data == ""3"") {
                        alert("" Deleted Successfully"");

                        location.href = ""/AuditoriumCapacity/ViewData"";

                    }
                    else if (data == ""4"") {
                        alert("" Already In Use!"");

                    ");
            WriteLiteral(@"    location.href = ""/AuditoriumCapacity/ViewData"";


                    }
                    else { }
                },
                error: function (error) {
                    jsonValue = jQuery.parseJSON(error.responseText);
                    bootbox.alert(""Error : "" + jsonValue);
                }
            });
        }
    }



</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OHSB.Domain.Row_SeatMaster.RowSeatEntity> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
