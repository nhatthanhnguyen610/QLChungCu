#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be2ea2fe5e8163940b2eab2c8b5deb52f73f4057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TypeTicket__Create), @"mvc.1.0.view", @"/Views/TypeTicket/_Create.cshtml")]
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
#line 1 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\_ViewImports.cshtml"
using DemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\_ViewImports.cshtml"
using DemoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2ea2fe5e8163940b2eab2c8b5deb52f73f4057", @"/Views/TypeTicket/_Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da9fae43ccf361385e7b7b609456b65034ebb9", @"/Views/_ViewImports.cshtml")]
    public class Views_TypeTicket__Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.Admin.Models.TypeTicketViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .error-valid {\r\n        color: red;\r\n    }\r\n</style>\r\n<div id=\"MenuModal\" class=\"modal fade\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n");
#nullable restore
#line 13 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
             using (Html.BeginForm("_Create", "TypeTicket", FormMethod.Post, new { id = "frmCreate" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-body"">
                    <div>
                        <label>Type<span style=""color:red"">*</span></label>
                        <div class=""row pl-3"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>Người lớn: </label>
                                    ");
#nullable restore
#line 25 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
                               Write(Html.RadioButtonFor(m => m.type, "Người lớn"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>Trẻ em: </label>
                                    ");
#nullable restore
#line 31 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
                               Write(Html.RadioButtonFor(m => m.type, "Trẻ em"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            ");
#nullable restore
#line 34 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.type));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""form-group"">
                                <label>Price<span style=""color:red"">*</span></label>
                                ");
#nullable restore
#line 41 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
                           Write(Html.TextBoxFor(m => m.price, new { @class = "form-control", @placeholder = "Price" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 42 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" id=""btnSubmit"" class=""btn btn-success btn-sm float-sm-right disableBtnSave""><span class=""fa fa-save""></span>Lưu</button>
                        <button type=""button"" class=""btn btn-danger btn btn-sm float-sm-right btn-popup-cancel"" id=""btnClose"" style=""margin-right:5px"" data-dismiss=""modal""><span class=""fa fa-times""></span>Thoát</button>
                    </div>
                </div>
");
#nullable restore
#line 51 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<script language=""javascript"">
    $('#frmCreate').validate({
        rules: {
            ""price"": {
                required: true
            },
            ""type"": {
                required: true
            },
        },
        messages: {
            ""type"": ""Vui lòng không để trống"",
            ""price"": ""Vui lòng không để trống"",
        },
        errorPlacement: function (error, element) {
            error.addClass('error-valid');
            error.insertAfter(element);
            if (element.attr(""name"") == """") {
                error.insertAfter(""#"");
            }
        }
    })

    //function Value(ratev) {
    //    document.getElementById(""rValue"").innerHTML = ratev;
    //    var convert = String(ratev);
    //    document.getElementById(""rate"").innerHTML = convert;
    //}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.Admin.Models.TypeTicketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591