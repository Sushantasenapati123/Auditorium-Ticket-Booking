#pragma checksum "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Account\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d27832d4e94189869425110d5362d135d502f25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePassword), @"mvc.1.0.view", @"/Views/Account/ChangePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d27832d4e94189869425110d5362d135d502f25", @"/Views/Account/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a829e92a7bfae1ff847eeec8b85f22380344f12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Account\ChangePassword.cshtml"
  
    ViewData["Title"] = "ChangePassword";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";

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
");
            WriteLiteral("                <div class=\"indicatorslist\">\r\n                    <a");
            BeginWriteAttribute("title", " title=\"", 863, "\"", 871, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>
");
            WriteLiteral(@"
            <div class=""card-body"">
                <div class=""form-group row"">
                    <input type=""hidden"" value=""0"" id=""hdnDignosisConfigId"" />
                    <div class=""col-xs-12 col-md-4 col-xl-4"">
                        <label class=""control-label"">Current Password<span class=""text-danger"">*</span></label>
                        <input type=""text"" id=""txtpwd""");
            BeginWriteAttribute("value", " value=\"", 1640, "\"", 1661, 2);
#nullable restore
#line 37 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\Account\ChangePassword.cshtml"
WriteAttributeValue("", 1648, ViewBag.pwd, 1648, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1660, "", 1661, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" readonly />
                    </div>
                </div>
                <div class=""form-group row"">
                    <div class=""col-12 col-md-4 col-xl-4"">
                        <label class=""control-label"" for=""RegstrationNo"">New Password<span class=""text-danger"">*</span></label>
                        <input id=""txtNewpwd"" class=""form-control"" />
                        <span id=""lblErrorName"" style=""color:red""></span>
                    </div>
                </div>
                <div class=""form-group row"">
                    <div class=""col-12 col-md-4 col-xl-4"">
                        <label class=""control-label"" for=""RegstrationNo"">Confirm Password<span class=""text-danger"">*</span></label>
                        <input id=""txtConfirmpwd"" class=""form-control"" />
");
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""form-group row"">
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


<script type=""text/javascript"">
    $(document).ready(function () {


    });
    $(""#btnSubmit"").click(function () {
        var newpwd = $(""#txtNewpwd"").val();
        var confpwd = $(""#txtConfirmpwd"").val();
        if (newpwd == confpwd && newpwd != """") {
            var doc = {
                Password: newpwd
            };
            if (confirm(""Are you sure you want to Submit ?"")) {
                $.ajax({
                    url: ""/Account/ChangePassword"",
                    data: d");
            WriteLiteral(@"oc,
                    type: ""POST"",
                    success: function (result) {
                        if (result == ""Password Saved Successfully"") {
                            alert(result)
                            location.href = ""/Account/ChangePassword"";
                        }
                        else
                            alert(result);
                        location.href = ""/Account/ChangePassword"";
                        reset();

                    },
                    error: function (errormessage) {
                        alert(errormessage.responseText);
                    }
                });
            }

        }

    });

    function reset() {
        $('#txtNewpwd').val("""");
        $('#txtConfirmpwd').val("""");
    }
    $(""#btnCancel"").click(function () {
        reset();
    })
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
