#pragma checksum "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bee155ec8f175b3d721d80b96303c8de0797c0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SlotMapping_ViewSlotMapping), @"mvc.1.0.view", @"/Views/SlotMapping/ViewSlotMapping.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bee155ec8f175b3d721d80b96303c8de0797c0f", @"/Views/SlotMapping/ViewSlotMapping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a829e92a7bfae1ff847eeec8b85f22380344f12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SlotMapping_ViewSlotMapping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OHSB.Domain.SlotMapping.SlotMappingEntity>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SlotMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSlotMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewSlotMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
  
    ViewData["Title"] = "ViewSlotMapping";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";
    var ResultData = ViewBag.Result as List<OHSB.Domain.SlotMapping.SlotMappingEntity>;

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bee155ec8f175b3d721d80b96303c8de0797c0f5882", async() => {
                WriteLiteral("Add");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bee155ec8f175b3d721d80b96303c8de0797c0f7343", async() => {
                WriteLiteral("View");
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
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n            <!-- Search Panel-->\r\n");
            WriteLiteral("            <!-- Search Panel -->\r\n            <!--===================================================-->\r\n            <div class=\"card-body \">\r\n");
#nullable restore
#line 62 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                 if (ResultData != null && ResultData.ToList().Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table data-toggle=""table"" id=""tblSlotMapping"" class=""table"">
                            <thead>
                                <tr>
                                    <th width=""60px"" class=""align-top text-center"">Sl#</th>
                                    <th width=""150px"" class=""align-top"">
                                        Auditorium Name
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        SlotName
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Show Name
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Date
                                    </th>
                                    <th width");
            WriteLiteral(@"=""150px"" class=""align-top"">
                                        SlotName
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Time(Base On 24HRS)
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                       Capacity
                                    </th>

                                    <th width=""150px"" class=""align-top"">Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 95 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 101 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 103 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                   Write(list.AuditoriumName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 106 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                   Write(list.SlotName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 109 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                   Write(list.ShowName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 112 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                   Write(list.ShowDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 115 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                   Write(list.SlotName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 118 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                   Write(list.Slot_TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 118 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                                       Write(list.Slot_TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 121 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                   Write(list.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6478, "\"", 6538, 6);
            WriteAttributeValue("", 6488, "updateSlotMapping(\'", 6488, 19, true);
#nullable restore
#line 124 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
WriteAttributeValue("", 6507, list.SlotID, 6507, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6519, "\',", 6519, 2, true);
            WriteAttributeValue(" ", 6521, "\'", 6522, 2, true);
#nullable restore
#line 124 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
WriteAttributeValue("", 6523, list.ShowID, 6523, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6535, "\');", 6535, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary mr-3\"");
            BeginWriteAttribute("title", " title=\"", 6565, "\"", 6573, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Edit\"><i class=\"icon-edit1\"></i><b>Edit</b></a><br />\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6693, "\"", 6735, 3);
            WriteAttributeValue("", 6703, "deleteSlotMapping(\'", 6703, 19, true);
#nullable restore
#line 125 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
WriteAttributeValue("", 6722, list.SMID, 6722, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6732, "\');", 6732, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"");
            BeginWriteAttribute("title", " title=\"", 6756, "\"", 6764, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Delete\"><i class=\"icon-trash-21\"></i><b>Delete</b></a>\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 129 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 134 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 138 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\SlotMapping\ViewSlotMapping.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""clearfix col-sm-12""></div>
            </div>
            <!--===================================================-->
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        getDataTable();
    })

    //Update SlotMapping
    function updateSlotMapping(SlotID, ShowID) {
        if (confirm(""Are you sure you want to update ?"")) {
            location.href = ""/SlotMapping/AddSlotMapping?SlotID="" + SlotID + ""&ShowID="" + ShowID;
        }
    }

    //Delete SlotMapping
    function deleteSlotMapping(SMID) {
        if (confirm(""Are you sure you want to delete ?"")) {
            $.ajax({
                url: ""/SlotMapping/DeleteSlotMapping?SMID="" + SMID,
                type: ""POST"",
                dataType: ""json"",
                contentType: ""application/json;charset=UTF-8"",
                success: function (data) {
                    if (data == ""3"") {
                        alert(""SlotMapping Deleted Successfully"");
  ");
            WriteLiteral(@"                      window.location.reload();
                    }
                    else if (data == ""4"") {
                        alert(""SlotMapping Already In Use!"");
                        window.location.reload();
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

    //Pagination
    function getDataTable() {
        $('#tblSlotMapping').DataTable({
            ""searching"": true,
            //""bStateSave"": true,
            ""dom"": 'Bfrtip',
            ""autoWidth"": false,
            ""buttons"": [
                //{
                //    extend: 'print',
                //    title: 'Manage Block',
                //    exportOptions: {
                //        columns: [0, 1, 2, 3, 4]
                //    },
                //");
            WriteLiteral(@"    customize: function (win) { $(win.document.body).css('font-size', '10pt').prepend('<img src=""' + origin + '/images/t5-logo-white.png""  style=""position:absolute; top:0; left:0;"" />'); $(win.document.body).find('table').addClass('compact').css('font-size', 'inherit'); }

                //}
                ,
                {
                    extend: 'pageLength'
                }
            ],
            ""lengthMenu"": [
                [10, 25, 50, 100, 1000 - 1],
                ['10 rows', '25 rows', '50 rows', '100 rows', '1000 rows', 'Show all']
            ]
        });
    }

    //Cascading Databind
    //Get All Slot By Hospital Id
    function GetAllSlotByHId() {
        $.ajax({
            url: ""/Slot/GetSlotByHospitalId?HospitalID="" + $('#HospitalName').val(),
            type: ""GET"",
            success: function (result) {
                data = JSON.parse(result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, functi");
            WriteLiteral(@"on (i, item) {
                    v += ""<option value="" + item.SlotID + "">"" + item.SlotName + ""</option>"";
                });
                $(""#SlotName"").html(v);
            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""Error : "" + jsonValue);
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OHSB.Domain.SlotMapping.SlotMappingEntity> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
