#pragma checksum "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Booking\ViewSeats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be6cedda869af87b62da9f3077606342890d65ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ViewSeats), @"mvc.1.0.view", @"/Views/Booking/ViewSeats.cshtml")]
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
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Booking\ViewSeats.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6cedda869af87b62da9f3077606342890d65ae", @"/Views/Booking/ViewSeats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a829e92a7bfae1ff847eeec8b85f22380344f12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_ViewSeats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auditorium.Domain.BookingMaster.BookingMaster>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewSeats", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Select", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AuditoriumId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control auditorium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("populateSeats()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/validation/validation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Booking\ViewSeats.cshtml"
  
    ViewData["Title"] = "AddShowSelect";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";
    var userId = ViewContext.HttpContext.Session.GetString("UserId");

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6cedda869af87b62da9f3077606342890d65ae8178", async() => {
                WriteLiteral("View Seats");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6cedda869af87b62da9f3077606342890d65ae9646", async() => {
                WriteLiteral("View Booking");
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
            BeginWriteAttribute("title", " title=\"", 1016, "\"", 1024, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>

            <div class=""card-body"">
                <div class=""form-group col-md-4"">
                    <input id=""Id"" class=""form-control"" hidden />
                </div>
                <div>
                    <input type=""hidden"" id=""userId""");
            BeginWriteAttribute("value", " value=\"", 1540, "\"", 1600, 1);
#nullable restore
#line 37 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Booking\ViewSeats.cshtml"
WriteAttributeValue("", 1548, ViewContext.HttpContext.Session.GetString("UserId"), 1548, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>

                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""BookingDate"">Date Of Booking<span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-4 col-xl-4"">
                        <input id=""BookingDate"" class=""form-control"" type=""date"" />
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Auditorium Name<span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-4 col-xl-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6cedda869af87b62da9f3077606342890d65ae13061", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6cedda869af87b62da9f3077606342890d65ae13350", async() => {
                    WriteLiteral("--Select--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 49 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Booking\ViewSeats.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.AudiList,"AuditoriumId","AuditoriumName"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Booking\ViewSeats.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AuditoriumId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""row"" id=""seatRows"">
                    <!-- Add row elements dynamically using JavaScript -->
                </div>


                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                    <div class=""col-12 col-md-6 col-xl-4 justify-content-center"">
                        <button class=""btn btn-primary mb-1"" id=""btnSubmit"">Submit</button>
                        <button class=""btn btn-danger mb-1"" id=""btnCancel"">Reset</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6cedda869af87b62da9f3077606342890d65ae17404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">


    $(document).ready(function () {
        //breadcumb
        loadNavigation('AddSeat', 'gldata', 'plsubmission', 'AddSeat', '', 'AddSeat');
        //var Id = getUrlVars()[""Id""];
        //if (Id != undefined) {
        //    $(""#btnSubmit"").html(""Update"");
        //    $(""#btnCancel"").html(""Cancel"");
        //    Edit(Id)
        //}
    });


    function populateSeats() {
        var auditoriumId = $(""#AuditoriumId"").val();

        $.ajax({
            type: ""GET"",
            url: ""/Booking/GetSeats"",
            data: { AuditoriumId: auditoriumId },
            success: function (result) {
                var seats = JSON.parse(result);

                // Create a dictionary to store blocks, rows, and seats
                var blocks = {};

                // Group seats by block and row
                for (var i = 0; i < seats.length; i++) {
                    var seat = seats[i];
                    if (!blocks[seat.BlockId]) {");
            WriteLiteral(@"
                        blocks[seat.BlockId] = {
                            BlockId: seat.BlockId,
                            BlockName: seat.BlockName,
                            Rows: {}
                        };
                    }
                    var blockRows = blocks[seat.BlockId].Rows;
                    if (!blockRows[seat.RowId]) {
                        blockRows[seat.RowId] = {
                            RowId: seat.RowId,
                            RowName: seat.RowName,
                            Seats: []
                        };
                    }
                    blockRows[seat.RowId].Seats.push(seat);
                }

                // Clear previous seat data
                $(""#seatRows"").empty();

                // Generate HTML for blocks in columns
                var blockContainerHtml = ""<div class='block-container'>"";
                var blockColumnsHtml = """";

                // Generate HTML for each block and its rows and seats
");
            WriteLiteral(@"                for (var blockId in blocks) {
                    var block = blocks[blockId];
                    blockColumnsHtml += ""<div class='block-column'>"";
                    blockColumnsHtml += ""<div class='block-header'><strong class='block-name' style='display: inline-block; text-align: center; width: 100%;' data-block-id='"" + block.BlockId + ""'>"" + block.BlockName + ""</strong></div>"";

                    // Generate HTML for each row in the block
                    for (var rowId in block.Rows) {
                        var row = block.Rows[rowId];
                        blockColumnsHtml += ""<div class='row-seats'>"";
                        blockColumnsHtml += ""<strong>Row "" + row.RowName + ""</strong>: "";

                        // Generate HTML for seats in the row
                        var seatRowHtml = """";
                        for (var j = 0; j < row.Seats.length; j++) {
                            var seat = row.Seats[j];
                            var seatId = ""seat");
            WriteLiteral(@"_"" + seat.RowId + ""_"" + seat.SeatId;
                            var seatName = seat.SeatName;
                            var seatClass = ""seat"";
                            var seatStyle = """";

                            seatRowHtml += ""<div class='seat-container' style='display: inline-block; margin-right: 20px;'>"";
                            seatRowHtml += ""<span id='"" + seatId + ""' class='"" + seatClass + ""' onclick='selectSeat(this)' style='"" + seatStyle + ""'>"";
                            seatRowHtml += ""<img src='/Photos/chair-icon.png' style='width: 20px; height: 20px;' />"";
                            seatRowHtml += ""<span class='seat-name' style='display: block; text-align: center;'>"" + seatName + ""</span>"";
                            seatRowHtml += ""</span>"";
                            seatRowHtml += ""</div>"";
                        }
                        blockColumnsHtml += seatRowHtml;
                        blockColumnsHtml += ""</div>"";
                    }
             ");
            WriteLiteral(@"       blockColumnsHtml += ""</div>"";
                }
                blockContainerHtml += blockColumnsHtml + ""</div>"";
                $(""#seatRows"").append(blockContainerHtml);

            }

        });

        setTimeout(function () {
            var seats = document.getElementsByClassName('seat');

            if (seats.length === 0) {
                console.log(""No elements found with the class 'seat'."");
                return;
            }

            // Function to update booked seats
            function updateBookedSeats(bookingDate) {
                $.ajax({
                    type: ""GET"",
                    url: ""/Booking/GetBookedSeatsForAuditorium"",
                    data: { AuditoriumId: auditoriumId, BookingDate: bookingDate },
                    success: function (result) {
                        var bookedSeats = result;

                        $("".seat"").each(function () {
                            var seat = $(this);
                           ");
            WriteLiteral(@" var seatId = seat.attr(""id"").split(""_"")[2];
                            var blockId = seat.closest("".block-column"").find("".block-name"").data(""block-id"");
                            var isBooked = bookedSeats.some(function (bookedSeat) {
                                return (
                                    bookedSeat.seatId == seatId &&
                                    bookedSeat.blockId == blockId
                                );
                            });

                            if (isBooked) {
                                seat.addClass(""booked-seat"");
                            } else {
                                seat.removeClass(""booked-seat"");
                            }
                        });
                    }
                });
            }

            // Event handler for BookingDate change
            $(""#BookingDate"").change(function () {
                var bookingDate = $(this).val();
                updateBookedSeats(bookingDate)");
            WriteLiteral(@";
            });

            // Initial update of booked seats
            var initialBookingDate = $(""#BookingDate"").val();
            updateBookedSeats(initialBookingDate);
        }, 500);

    }

    var seatDetails = """";

    function selectSeat(seat) {
        var seatId = seat.id;
        var isSelected = $(seat).hasClass(""selected-seat"");

        if (isSelected) {
            // Seat is already selected, unselect it
            $(seat).removeClass(""selected-seat"");
            $(seat).css(""background-color"", ""#eaeaea"");

            // Remove the seat details from the array
            seatDetails = seatDetails.filter(function (seat) {
                return seat.SeatId !== seatId;
            });
        }
        else {
            // Seat is not selected, select it
            $(seat).addClass(""selected-seat"");
            $(seat).css(""background-color"", ""#13f702""); // Change the seat color to indicate selection
            // Find the blockId by traversing up the ");
            WriteLiteral(@"DOM hierarchy
            var blockId = $(seat).closest("".block-column"").find("".block-name"").data(""block-id"");
            // Get the actual values of AuditoriumId, RowId, and SeatId
            var id = $(""#Id"").val();
            var bookingDate = $(""#BookingDate"").val();
            var userId = $(""#userId"").val();
            var auditoriumId = $(""#AuditoriumId"").val();

            var rowIds = [];
            var seatIds = [];

            // Loop over the selected seats and push each seat ID to the seatIds array
            $("".selected-seat"").each(function () {
                var seatId = $(this).attr(""id"").split(""_"")[2];
                var rowId = $(this).attr(""id"").split(""_"")[1];

                // Push the rowId if it's not already in the rowIds array
                if (rowIds.indexOf(rowId) === -1) {
                    rowIds.push(rowId);
                }

                seatIds.push(seatId);
            });

            // Update the seatDetails object with the new ");
            WriteLiteral(@"values
            seatDetails = {
                Id: id,
                BookingDate: bookingDate,
                UserId: userId,
                AuditoriumId: auditoriumId,
                BlockId: blockId,
                RowId: rowIds,
                SeatId: seatIds
            };
        }
    }


    $(""#btnSubmit"").click(function () {
        // Validate Booking Date
        var bookingDate = $(""#BookingDate"").val();
        if (bookingDate === """") {
            alert(""Please select a Booking Date."");
            return;
        }

        // Validate Auditorium
        var auditoriumId = $(""#AuditoriumId"").val();
        if (auditoriumId === 'Select') {
            alert(""Please select an Auditorium."");
            return;
        }

        // Make the AJAX request to submit the selected seats
        if (confirm(""Are you sure you want to Submit?"")) {
            $.ajax({
                type: ""POST"",
                url: ""/Booking/ViewSeats"",
                data");
            WriteLiteral(@": seatDetails,
                success: function (result) {
                    if (getUrlVars()[""Id""] !== undefined) {
                        alert(result);
                        location.href = ""/Booking/ViewBooking"";
                    } else {
                        alert(result);
                        location.href = ""/Booking/ViewBooking"";
                    }
                    reset();
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }
    });


    $(""#btnCancel"").click(function () {
        if ($(""#Id"").val() != '') {
            window.location.href = ""/Booking/ViewBooking"";
        } else {
            reset();
        }
    });

    function reset() {
        $(""#AuditoriumId"").val(""Select"");
        $("".selected-seat"").removeClass(""selected-seat"").css(""background-color"", ""#eaeaea"");
        seatDetails = [];
    }


    //UPDATE
    //func");
            WriteLiteral(@"tion Edit(Id) {
    //    $.ajax({
    //        url: ""/Booking/Getbyid?Id="" + Id,
    //        type: ""GET"",
    //        contentType: ""application/json;charset=UTF-8"",
    //        dataType: ""json"",
    //        success: function (Result) {
    //            $('#Id').val(Result.Id);
    //            $(""#AuditoriumId"").val(Result.AuditoriumId);
    //            $(""#RowId"").val(Result.RowId);
    //            $(""#SeatId"").val(Result.SeatId);
    //        },
    //        error: function (errormessage) {
    //            alert(errormessage.responseText);
    //        }
    //    });
    //    return false;
    //}
</script>
<style>
    .booked-seat {
        background-color: red; /* Change the background color to your desired color */
        opacity: 0.5; /* Set the opacity to 50% */
    }
</style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auditorium.Domain.BookingMaster.BookingMaster> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
