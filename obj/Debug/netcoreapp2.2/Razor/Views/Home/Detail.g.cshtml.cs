<<<<<<< HEAD
#pragma checksum "/Users/runkanchano/Desktop/Vitcome/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c32bebefd0ff1dfc53589639f5fb4a67dbd54c2"
=======
#pragma checksum "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24b9f5423e501f91b733ad04c45c4f8f7a599bd7"
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#line 2 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore.Models;

#line default
#line hidden
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c32bebefd0ff1dfc53589639f5fb4a67dbd54c2", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42f8c1e7f84b2085c62db58c14ae0e4f8b26c0", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b9f5423e501f91b733ad04c45c4f8f7a599bd7", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ceef2bbbea8f7e1eb485cc90e0c774edd14efc", @"/Views/_ViewImports.cshtml")]
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
<<<<<<< HEAD
            BeginContext(0, 249, true);
            WriteLiteral("\n\n    <style>\n        .form-check {\n        display:inline;\n        }\n\n    </style>\n<h3 style=\"text-align:center;\"><b>แบบฟอร์มยืนหัวข้องานวิจัยทางเทคโนโลยีสารสนเทศ <br>คณะวิทยาศาสตร์ มหาวิทยาลัยราชภัฎจันทรเกษม</h3>\n<div class=\"card-body card \">\n    ");
            EndContext();
            BeginContext(249, 3126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c32bebefd0ff1dfc53589639f5fb4a67dbd54c23467", async() => {
                BeginContext(255, 3113, true);
=======
            BeginContext(0, 259, true);
            WriteLiteral(@"

    <style>
        .form-check {
        display:inline;
        }

    </style>
<h3 style=""text-align:center;""><b>แบบฟอร์มยืนหัวข้องานวิจัยทางเทคโนโลยีสารสนเทศ <br>คณะวิทยาศาสตร์ มหาวิทยาลัยราชภัฎจันทรเกษม</h3>
<div class=""card-body card "">
    ");
            EndContext();
            BeginContext(259, 3198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b9f5423e501f91b733ad04c45c4f8f7a599bd73536", async() => {
                BeginContext(265, 3185, true);
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""inputEmail4"">ชื่อ</label>
            <input type=""email"" class=""form-control"" name=""name"" placeholder=""ชื่อ"">
        </div>
        <div class=""form-group col-md-6"">
            <label for=""inputPassword4"">นามสกุล</label>
            <input type=""password"" class=""form-control"" name=""lastname"" placeholder=""นามสกุล"">
        </div>
    </div>
    <div class=""row"">
    <div class=""form-group col-lg-6"">
        <label for=""inputAddress"">รหัสนักศึกษา</label>
        <input type=""text"" class=""form-control "" name=""idstudent"" placeholder=""รหัสนักศึกษา"">
    </div>
    <div class=""form-group col-lg-6""style=""display:inline-block;padding-top:3%;"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
            <label class=""form-check-label"" for=""gridCheck"">
                ภาคในเวลา
            </label>

        </div>
<<<<<<< HEAD
        <div class=""form-check"">
            <inpu");
                WriteLiteral(@"t class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
=======
        <div class=""form-c");
                WriteLiteral(@"heck"">
            <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
            <label class=""form-check-label"" for=""gridCheck"">
                ภาคนอกเวลา
            </label>

        </div>
    </div>
        </div>
     <div class=""row"">
    <div class=""form-group col-lg-6"">
        <label for=""inputAddress2"">ชื่อหัวข้อที่นำเสนอ</label>
        <input type=""text"" class=""form-control"" name=""headder"" placeholder=""กรุณาใส่ชื่อหัวข้อ"">
    </div>
    <div class=""form-group col-lg-6"">
        <label for=""inputAddress2"">ชื่อหัวข้อที่นำเสนอภาษาอังกฤษ</label>
        <input type=""text"" class=""form-control""name=""headdereng"" placeholder=""กรุณาใส่ชื่อหัวข้อภาษาอังกฤษ"">
    </div>
        </div>
    <div class=""form-group"">
        <label for=""inputAddress2"">ความเป็นมาและความสำคัญ</label>
        <textarea class=""form-control"" aria-label=""With textarea""name=""text1""placeholder=""กรุณาใส่ความเป็นมาและความสำคัญ""></textarea>

    </div>
    <div class=""form-group"">
<<<<<<< HEAD
        <label for=""inputAddress2"">วัตถุประสงค์</label>
        <t");
                WriteLiteral(@"extarea class=""form-control"" aria-label=""With textarea""name=""text2""placeholder=""กรุณาใส่วัตถุประสงค์""></textarea>
=======
        <label fo");
                WriteLiteral(@"r=""inputAddress2"">วัตถุประสงค์</label>
        <textarea class=""form-control"" aria-label=""With textarea""name=""text2""placeholder=""กรุณาใส่วัตถุประสงค์""></textarea>
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9

    </div>
    <div class=""form-group"">
        <label for=""inputAddress2"">หลักการทถษฏีและเหตุผล</label>
        <textarea class=""form-control"" aria-label=""With textarea""name=""text3""placeholder=""กรุณาใส่หลักการทฤษฏีและเหตุผล""></textarea>

    </div>
    <label for=""inputAddress2"">ระยะเวลาดำเนินการ</label>
    <div class=""custom-file"">
        <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01"" aria-describedby=""inputGroupFileAddon01"">
        <label class=""custom-file-label"" for=""inputGroupFile01"">กรุณาใส่แผนภาพGantChart หรือไฟล์.CSV</label>
    </div>
    <div class=""form-group"">
        <label for=""inputAddress2"">แผนการดำเนินงาน ขอบเขตการศึกษา</label>
        <textarea class=""form-control"" aria-label=""With textarea""name=""text4""placeholder=""กรุณาใส่แผนการดำเนินงาน และขอบเขตการศึกษา""></textarea>

    </div>



<<<<<<< HEAD
    <button type=""submit"" class=""btn btn-info btn-lg btn-block""style=""co");
                WriteLiteral("lor:white;\">บันทึกฟอร์ม CS1</button>\n    ");
=======
 ");
                WriteLiteral("   <button type=\"submit\" class=\"btn btn-info btn-lg btn-block\"style=\"color:white;\">บันทึกฟอร์ม CS1</button>\r\n    ");
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
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
<<<<<<< HEAD
            BeginContext(3375, 32, true);
            WriteLiteral("\n</div>\n        <br>\n        <p>");
            EndContext();
            BeginContext(3408, 12, false);
#line 86 "/Users/runkanchano/Desktop/Vitcome/Views/Home/Detail.cshtml"
=======
            BeginContext(3457, 35, true);
            WriteLiteral("\r\n</div>\r\n        <br>\r\n        <p>");
            EndContext();
            BeginContext(3493, 12, false);
#line 86 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Detail.cshtml"
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
      Write(ViewBag.name);

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(3420, 29, true);
            WriteLiteral("</p>\n        <br>\n        <p>");
            EndContext();
            BeginContext(3450, 16, false);
#line 88 "/Users/runkanchano/Desktop/Vitcome/Views/Home/Detail.cshtml"
=======
            BeginContext(3505, 31, true);
            WriteLiteral("</p>\r\n        <br>\r\n        <p>");
            EndContext();
            BeginContext(3537, 16, false);
#line 88 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Detail.cshtml"
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
      Write(ViewBag.lastname);

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(3466, 29, true);
            WriteLiteral("</p>\n        <br>\n        <p>");
            EndContext();
            BeginContext(3496, 17, false);
#line 90 "/Users/runkanchano/Desktop/Vitcome/Views/Home/Detail.cshtml"
=======
            BeginContext(3553, 31, true);
            WriteLiteral("</p>\r\n        <br>\r\n        <p>");
            EndContext();
            BeginContext(3585, 17, false);
#line 90 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Detail.cshtml"
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
      Write(ViewBag.idstudent);

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(3513, 16, true);
            WriteLiteral("</p>\n        <p>");
            EndContext();
            BeginContext(3530, 17, false);
#line 91 "/Users/runkanchano/Desktop/Vitcome/Views/Home/Detail.cshtml"
=======
            BeginContext(3602, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(3620, 17, false);
#line 91 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Detail.cshtml"
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
      Write(ViewBag.supername);

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(3547, 4, true);
=======
            BeginContext(3637, 4, true);
>>>>>>> 982824c14c9a316737877a7a999c5271dc4c99c9
            WriteLiteral("</p>");
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
