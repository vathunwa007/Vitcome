#pragma checksum "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9e09898156396dfddce73b0e9ebf5dd5777335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Index.cshtml", typeof(AspNetCore.Views_Teacher_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9e09898156396dfddce73b0e9ebf5dd5777335", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42f8c1e7f84b2085c62db58c14ae0e4f8b26c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Techer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "saveidteacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(21, 770, true);
            WriteLiteral(@"<script>
    function checksent() {
        swal({
            title: ""คุณแน่ใจว่าจะส่งแบบเสนอหัวข้อนี้?"",
            text: ""กรุณาเช็คข้อมูลให้ถูกต้องก่อนส่งพื่อป้องกันการเกิดปัญหาในภายหลัง!"",
            icon: ""warning"",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    swal(""คุณได้ทำการส่งฟอร์มCS1เรียบร้อยแล้วครับ!"", {
                        icon: ""success"",
                    });
                    document.getElementById(""myForm"").submit();


                } else {
                    swal(""ยกเลิกการส่งสำเร็จ!"");
                }
            });
    }
</script>
<h3 style=""text-align:center;"">เลือก อ.ที่ปรึกษา </h3>


");
            EndContext();
            BeginContext(791, 1128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9e09898156396dfddce73b0e9ebf5dd57773355370", async() => {
                BeginContext(863, 127, true);
                WriteLiteral("\r\n    <div class=\"form-group card-body card\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 990, "\"", 1025, 1);
#line 32 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 996, Model[@ViewBag.Id - 1].image, 996, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1026, 196, true);
                WriteLiteral(" alt=\"Alternate Text\" width=\"250\" height=\"250\" style=\"display:inline\"/>\r\n               \r\n            </div>\r\n            <div class=\"col-6\">\r\n                <input type=\"hidden\" name=\"idteacher\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1222, "\"", 1241, 1);
#line 36 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1230, ViewBag.Id, 1230, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1242, 33, true);
                WriteLiteral(" />\r\n                <p>ลำดับที่ ");
                EndContext();
                BeginContext(1276, 10, false);
#line 37 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml"
                       Write(ViewBag.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1286, 39, true);
                WriteLiteral("</p>\r\n                <p>ชื่ออาจารย์ : ");
                EndContext();
                BeginContext(1326, 27, false);
#line 38 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml"
                            Write(Model[@ViewBag.Id - 1].Name);

#line default
#line hidden
                EndContext();
                BeginContext(1353, 44, true);
                WriteLiteral("</p>\r\n                <p>ความถนัดด้านภาษา : ");
                EndContext();
                BeginContext(1398, 28, false);
#line 39 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml"
                                 Write(Model[@ViewBag.Id - 1].Skill);

#line default
#line hidden
                EndContext();
                BeginContext(1426, 80, true);
                WriteLiteral("</p>\r\n                <span>ชื่อเรื่องวิจัยของคุณ</span>\r\n                <span>");
                EndContext();
                BeginContext(1507, 13, false);
#line 41 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml"
                 Write(ViewBag.title);

#line default
#line hidden
                EndContext();
                BeginContext(1520, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1522, 16, false);
#line 41 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Teacher\Index.cshtml"
                                Write(ViewBag.titleEng);

#line default
#line hidden
                EndContext();
                BeginContext(1538, 374, true);
                WriteLiteral(@"</span><br />
                <span>แนบฟอร์ม CS1 </span>
                <a href=""../Print/Index"" target=""_blank"" class="" btn-lg btn btn-info btn-warning btn-block"">ดูฟอร์มCS1ของคุณ</a>
            </div>
            </div>
        <button type=""button"" class=""btn btn-info btn-lg btn-block"" onclick=""checksent()"">ส่งเอกสารยื่นหัวข้อCS1</button>
            </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1919, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Techer>> Html { get; private set; }
    }
}
#pragma warning restore 1591