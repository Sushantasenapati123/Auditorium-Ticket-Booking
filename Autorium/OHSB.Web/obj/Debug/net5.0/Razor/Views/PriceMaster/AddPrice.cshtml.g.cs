#pragma checksum "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\PriceMaster\AddPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d19954b1273ebf5bb9cba6ae25d271cd2894985"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PriceMaster_AddPrice), @"mvc.1.0.view", @"/Views/PriceMaster/AddPrice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d19954b1273ebf5bb9cba6ae25d271cd2894985", @"/Views/PriceMaster/AddPrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a829e92a7bfae1ff847eeec8b85f22380344f12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PriceMaster_AddPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OHSB.Domain.PriceMaster.PriceEntity>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PriceMaster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPrice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewPrice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlAuditorium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("GetBlockByAId()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\PriceMaster\AddPrice.cshtml"
  
    ViewData["Title"] = "AddPrice";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-title"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d19954b1273ebf5bb9cba6ae25d271cd28949857830", async() => {
                WriteLiteral("AddPrice");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d19954b1273ebf5bb9cba6ae25d271cd28949859296", async() => {
                WriteLiteral("ViewPrice");
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
            WriteLiteral("\r\n\r\n                </ul>\r\n                <div class=\"indicatorslist\">\r\n                    <a");
            BeginWriteAttribute("title", " title=\"", 895, "\"", 903, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>
");
            WriteLiteral(@"
        <div class=""card-body"">
            <div class=""form-group col-md-4"">
                <input id=""hdnPriceId"" class=""form-control"" hidden />
            </div>
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Auditorium <span class=""text-danger"">*</span></label>
                <div class=""col-6 col-md-6 col-xl-4"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d19954b1273ebf5bb9cba6ae25d271cd289498511746", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d19954b1273ebf5bb9cba6ae25d271cd289498512031", async() => {
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
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 38 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\PriceMaster\AddPrice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.AuditoriumID,"AuditoriumID","AuditoriumName"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\Users\sushanta.senapati\Desktop\Auditorium\Auditorium-Ticket-Booking\Autorium\OHSB.Web\Views\PriceMaster\AddPrice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AuditoriumID);

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
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Block <span class=""text-danger"">*</span></label>
                <div class=""col-6 col-md-6 col-xl-4"">
                    <select id=""ddlBlock"" onchange=""GetRowById()"" class=""form-control"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d19954b1273ebf5bb9cba6ae25d271cd289498515772", async() => {
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
            WriteLiteral(@"
                    </select>
                </div>
            </div>

            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Rows<span class=""text-danger"">*</span></label>
                <div class=""col-6 col-md-6 col-xl-4"">
                    <select id=""ddlRow"" class=""form-control"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d19954b1273ebf5bb9cba6ae25d271cd289498517351", async() => {
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
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Price<span class=""text-danger"">*</span></label>
                <div class=""col-6 col-md-6 col-xl-4"">
                    <input type=""text"" id=""txtPrice""  class=""form-control"">
                </div>
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
<script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d19954b1273ebf5bb9cba6ae25d271cd289498519543", async() => {
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
<script>
    $(document).ready(function () {
        //breadcumb
        loadNavigation('AddPrice', 'gldata', 'plsubmission', 'AddPrice', '', 'AddPrice');
        var PriceId = getUrlVars()[""PriceId""];
        if (PriceId != undefined) {
            $(""#btnSubmit"").html(""Update"");
            $(""#btnCancel"").html(""Cancel"");
            Edit(PriceId)
        }

    });

</script>
<script type=""text/javascript"">
    function GetBlockByAId() {
        $.ajax({
            url: ""/PriceMaster/GetBlockbyAuditoriumid?AuditoriumID="" + $('#ddlAuditorium').val(),
            type: ""GET"",
            success: function (Result) {
                data = JSON.parse(Result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    v += ""<option value="" + item.BlockId + "">"" + item.BlockName + ""</option>"";
                });
                $(""#ddlBlock"").html(v);

            },
            error: function (error) {
");
            WriteLiteral(@"                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""Error : "" + jsonValue);
            }
        });
    }
    function GetRowById() {
        $.ajax({
            url: ""/PriceMaster/GetRowkbyid?BlockId="" + $('#ddlBlock').val() ,
            type: ""GET"",
            success: function (Result) {
                data = JSON.parse(Result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    v += ""<option value="" + item.Row_No + "">"" + item.RowDesc + ""</option>"";
                });
                $(""#ddlRow"").html(v);

            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""Error : "" + jsonValue);
            }
        });
    }
    //insert
    $(""#btnSubmit"").click(function () {
        var doc = {
            PriceId: $(""#hdnPriceId"").val(),
            AuditoriumID: $(""#ddlAudi");
            WriteLiteral(@"torium"").val(),
            BlockId: $(""#ddlBlock"").val(),
            Row_No: $(""#ddlRow"").val(),
            Price: $(""#txtPrice"").val()


        };

       if (validate()) {
            //    && NamevalidationC('txtName', 'lblErrorName') == true
            //    && Pricevalidate('price', 'lblerrorprice') == true) {
            if (confirm(""Are you sure you want to Submit ?"")) {
                $.ajax({
                    url: ""/PriceMaster/AddPrice"",
                    data: doc,
                    type: ""POST"",
                    success: function (result) {
                        if (getUrlVars()[""PriceId""] != undefined) {
                            alert(result)
                            location.href = ""/PriceMaster/ViewPrice"";
                        }
                        else
                            alert(result);
                        location.href = ""/PriceMaster/ViewPrice"";
                        reset();

                    },
                    e");
            WriteLiteral(@"rror: function (errormessage) {
                        alert(errormessage.responseText);
                    }
                });
            }
        }
        //}

    });
    function fillrows() {
        $.ajax({
            url: ""/PriceMaster/GetRowkbyid?BlockId="" + $('#ddlBlock').val(),
            type: ""GET"",
            success: function (Result) {
                data = JSON.parse(Result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    v += ""<option value="" + item.Row_No + "">"" + item.RowDesc + ""</option>"";
                });
                $(""#ddlRow"").html(v);

            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                alert(""Error : "" + jsonValue);
            }
        });
    }
    //UPDATE
    function Edit(PriceId) {
        $.ajax({
            url: ""/PriceMaster/Getbyid?PriceId="" + PriceId,
   ");
            WriteLiteral(@"         type: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (Results) {
                $('#hdnPriceId').val(Results.PriceId);
                $('#ddlAuditorium').val(Results.AuditoriumID);             
                //$('#ddlRow').val(Results.Row_No);
                $('#txtPrice').val(Results.Price);
                $.ajax({
                    url: ""/PriceMaster/GetBlockbyAuditoriumid?AuditoriumID="" + $('#ddlAuditorium').val(),
                    type: ""GET"",
                    success: function (Result) {
                        data = JSON.parse(Result);
                        var v = ""<option value='0'>--Select--</option>"";
                        $.each(data, function (i, item) {
                            v += ""<option value="" + item.BlockId + "">"" + item.BlockName + ""</option>"";
                        });
                        $(""#ddlBlock"").html(v);
                        $('#ddlBlock').val(Re");
            WriteLiteral(@"sults.BlockId);
                        $.ajax({
                            url: ""/PriceMaster/GetRowkbyid?BlockId="" + $('#ddlBlock').val(),
                            type: ""GET"",
                            success: function (Result) {
                                data = JSON.parse(Result);
                                var v = ""<option value='0'>--Select--</option>"";
                                $.each(data, function (i, item) {
                                    v += ""<option value="" + item.Row_No + "">"" + item.RowDesc + ""</option>"";
                                });
                                $(""#ddlRow"").html(v);
                                $('#ddlRow').val(Results.Row_No);

                            },
                            error: function (error) {
                                jsonValue = jQuery.parseJSON(error.responseText);
                                alert(""Error : "" + jsonValue);
                            }
                        });
      ");
            WriteLiteral(@"                  

                    },
                    error: function (error) {
                        jsonValue = jQuery.parseJSON(error.responseText);
                        alert(""Error : "" + jsonValue);
                    }
                });
               

            },
           
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
        return false;
    }
    $(""#btnCancel"").click(function () {
        if ($(""#hdnPriceId"").val() != '') {
            window.location.href = ""/PriceMaster/ViewPrice"";
        }
        else
            reset();
    })
    function reset() {
        $('#hdnPriceId').val("""");
        $('#ddlAuditorium').val(""0"");
        $('#ddlBlock').val(""0"");
        $('#ddlRow').val(""0"");
        $('#txtPrice').val("""");


    }
    //validation
    function validate() {
        if ($('#ddlAuditorium').val() == ""0"") {
            alert(""Please Enter Auditorium!"");
");
            WriteLiteral(@"            $('#ddlAuditorium').focus();
            return false;
        }
        else if ($('#ddlBlock').val() == ""0"") {
            alert(""Please Enter Block!"");
            $('#ddlBlock').focus();
            return false;
        }
        else if ($('#ddlRow').val() == ""0"") {
            alert(""Please Enter Row!"");
            $('#ddlRow').focus();
            return false;
        }
        else if ($('#txtPrice').val() == """") {
            alert(""Please Enter Price!"");
            $('#txtPrice').focus();
            return false;
        }
        else
            return true;
    }
    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OHSB.Domain.PriceMaster.PriceEntity> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591