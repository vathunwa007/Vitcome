#pragma checksum "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1861ecb7c1297734810bed24c9eccaa708f6095"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#line 2 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\_ViewImports.cshtml"
using netcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1861ecb7c1297734810bed24c9eccaa708f6095", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ceef2bbbea8f7e1eb485cc90e0c774edd14efc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Index.cshtml"
   ViewData["Title"] = "ระบบยืนสมัครวิจัยวิทยาการคอมพิวเตอร์"; 

#line default
#line hidden
            BeginContext(66, 252, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\" style=\"padding-top: 60px;\">\r\n    <div class=\"col-md-6\">\r\n        <div style=\" border: 1px solid;\r\n        padding: 10px;\r\n        box-shadow: 5px 10px;\">\r\n            <h1 style=\"text-align: center;\">สมัครสมาชิก</h1>\r\n            ");
            EndContext();
            BeginContext(318, 2315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1861ecb7c1297734810bed24c9eccaa708f60953716", async() => {
                BeginContext(324, 2302, true);
                WriteLiteral(@"
                <div class=""form-group "">
                    <label for=""exampleInputEmail1"">รหัสนักศึกษา</label>
                    <input type=""number"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter Idstudent"">
                    <small id=""emailHelp"" class=""form-text text-muted"">กรุณากรอกรหัสนักศึกษา.</small>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">รหัสผ่าน</label>
                    <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">ชื่อและนามสกุล</span>
                    </div>
                    <input type=""text"" aria-label=""First name"" class=""form-control"" placeholder=""ชื่อ"">
                    <input type=""text"" aria-label=""Last name"" class");
                WriteLiteral(@"=""form-control"" placeholder=""นามสกุล"">
                </div>
                <div class=""form-group col-md-12"" style=""padding-top:8px; text-align: center;"">
                    <div class=""mx-auto form-control "">
                        <input type=""checkbox"" aria-label=""Checkbox for following text input""> <span>ปี3</span>
                        <input type=""checkbox"" aria-label=""Checkbox for following text input""><span>ปี4</span>
                        <input type=""checkbox"" aria-label=""Checkbox for following text input""> <span>ภาคนอกเวลา</span>
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">อีเมล</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Email"">
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">เบอร์โทรติดต่อได้</label>
                    <input type=""number");
                WriteLiteral("\" class=\"form-control\" id=\"exampleInputPassword1\" placeholder=\"Telephone\">\r\n                </div>\r\n\r\n                <button style=\"display: block;margin-left: auto;margin-right: auto;\" type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2633, 238, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div style=\" border: 1px solid;\r\n            padding: 10px;\r\n            box-shadow: 5px 10px;\">\r\n            <h1 style=\"text-align: center;\">เข้าสู่ระบบ</h1>\r\n            ");
            EndContext();
            BeginContext(2871, 749, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1861ecb7c1297734810bed24c9eccaa708f60957903", async() => {
                BeginContext(2877, 736, true);
                WriteLiteral(@"
                <div class=""form-group "">
                    <label for=""exampleInputEmail1"">รหัสนักศึกษา</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter email"">
                    <small id=""emailHelp"" class=""form-text text-muted"">กรุณากรอกรหัสนักศึกษา.</small>
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">รหัสผ่าน</label>
                    <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                </div>

                <button type=""submit"" class=""btn btn-primary"">Submit</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3620, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
