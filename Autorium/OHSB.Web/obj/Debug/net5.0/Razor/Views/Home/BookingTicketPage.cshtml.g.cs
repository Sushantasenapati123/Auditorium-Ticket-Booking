#pragma checksum "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Home\BookingTicketPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4355fe576493ce3251f72c75f2892a1856606dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BookingTicketPage), @"mvc.1.0.view", @"/Views/Home/BookingTicketPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4355fe576493ce3251f72c75f2892a1856606dc", @"/Views/Home/BookingTicketPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a829e92a7bfae1ff847eeec8b85f22380344f12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_BookingTicketPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Photos/pngegg.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:20px;width:20px;background-color:aqua"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Home\BookingTicketPage.cshtml"
  
    ViewData["Title"] = "BookingTicketPage";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .spacing {
        padding: 0 130px;
    }

    .card {
        width: 100%;
        height: 75vh;
        display: flex;
        flex-direction: row;
        align-items: center;
        justify-content: center;
        flex-wrap: wrap;
        /* gap: 20px;*/
        gap: 2%;
        background-color: forestgreen;
    }
</style>


<div class=""container spacing"">
    <div class=""card"">
");
#nullable restore
#line 28 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Home\BookingTicketPage.cshtml"
          
            int Count = 1;
            int rate = 4;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"k-card k-card-type-rich\" style=\"background-color:aqua\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 708, "\"", 714, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"img\" class=\"k-card-image\" width=\"830\" height=\"450\">\r\n\r\n            <div class=\"k-card-body\">\r\n                <h5 class=\"k-card-title\"> <span id=\"name\"></span></h5>\r\n                <h6 class=\"k-card-subtitle\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4355fe576493ce3251f72c75f2892a1856606dc5605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("5.0</h6>\r\n            </div>\r\n            <div class=\"k-card-actions k-card-actions-vertical\">\r\n");
            WriteLiteral(@"            </div>
        </div>
       
        <button onclick=""BookingTicketPage()"" style=""margin-top:15px"" value=""Book Tickets"" class=""btn btn-primary"">
            <b>Book Tickets</b>
        </button>
       


    </div>
</div>
<script>
    function BookingTicketPage() {
        /* if (confirm(""Are you sure to Book?"")) {*/
        location.href = ""/Home/BookingTicketPageFor_a_Moview?showid="" + showid;
        //}
    }
    $(document).ready(function () {
        //breadcumb
        loadNavigation('AddScreenDetails', 'gldata', 'plsubmission', 'AddScreenDetails', '', 'AddScreenDetails');
        var ScreenMapId = getUrlVars()[""ScreenMapId""];
        if (ScreenMapId != undefined) {
            //alert(Photo);
            Edit(ScreenMapId);
        }
    });
    var showid;
    function Edit(ScreenMapId) {

        $.ajax({
            url: ""/ScreenMap/GetbyShowid?ScreenMapId="" + ScreenMapId,
            type: ""GET"",
            contentType: ""application/json;charset=UTF-8""");
            WriteLiteral(@",
            dataType: ""json"",
            success: function (Result) {
                $(""#img"").attr('src', '/' + Result.Photo);
                $('#name').html(Result.ShowName);
                showid = Result.ShowId;
                //$('#ddlAuditorium').val(Result.AuditoriumID);
                //$(""#ddlShowtype"").val(Result.ShowType);
                //$(""#ddlShow"").val(Result.ShowId);
                //$(""#TimeFrom"").val(Result.ShowTimeFrom);
                //$(""#TimeTo"").val(Result.ShowTimeTo);

            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
        return false;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
