#pragma checksum "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7094cfad5d295575a37edd6eb11d5a7fe786ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Techer), @"mvc.1.0.view", @"/Views/Home/Techer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Techer.cshtml", typeof(AspNetCore.Views_Home_Techer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7094cfad5d295575a37edd6eb11d5a7fe786ca", @"/Views/Home/Techer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ceef2bbbea8f7e1eb485cc90e0c774edd14efc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Techer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Techer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(21, 615, true);
            WriteLiteral(@"
<style>
    body {
        /* background-image: url('https://images.pexels.com/photos/875858/pexels-photo-875858.png?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940');*/
    }
</style>
<!---->


<div class=""container"">
    <div class=""row"">

        <div class=""mx-auto"">
            <div class=""alert alert-warning"" role=""alert"">
                นักศึกษาสามารถกดที่ชื่ออาจารย์เพื่อเข้าสู่การยื่นเสนอหัวข้อ CS1 ได้โดยคลิ้กที่ตารางข้างล่างนี้
            </div>
            <h1 style=""color:white;"">เลือกอาจารย์ที่ปรึกษาวิจัย</h1>
        </div>
        <table class=""table table-hover"">
            ");
            EndContext();
            BeginContext(636, 1724, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e7094cfad5d295575a37edd6eb11d5a7fe786ca4808", async() => {
                BeginContext(699, 401, true);
                WriteLiteral(@"
                <thead>
                    <tr>
                        <!--<th scope=""col"">#</th>-->
                        <th scope=""col"">ลำดับ</th>
                        <th scope=""col"">ชื่ออาจารย์</th>
                        <th scope=""col"">สกิล</th>
                        <th scope=""col"">สถานะ</th>

                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 33 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(1173, 27, true);
                WriteLiteral("                        <tr");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1200, "\"", 1259, 3);
                WriteAttributeValue("", 1210, "window.open(\'../Teacher?id=", 1210, 27, true);
#line 35 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
WriteAttributeValue("", 1237, item.Id, 1237, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1245, "\',\'_self\',\'\');", 1245, 14, true);
                EndWriteAttribute();
                BeginContext(1260, 136, true);
                WriteLiteral(">\r\n                            <!--<tr>-->\r\n                            <!-- <th scope=\"row\"><input type=\"checkbox\" name=\"check\" value=\"");
                EndContext();
                BeginContext(1397, 7, false);
#line 37 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                                                                                       Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1404, 91, true);
                WriteLiteral("\"aria-label=\"Checkbox for following text input\"> </th>-->\r\n                            <td>");
                EndContext();
                BeginContext(1496, 7, false);
#line 38 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                           Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1503, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1543, 9, false);
#line 39 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                           Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1552, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1592, 10, false);
#line 40 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                           Write(item.Skill);

#line default
#line hidden
                EndContext();
                BeginContext(1602, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 41 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                             if (@item.Status >= 5)
                            {

#line default
#line hidden
                BeginContext(1693, 58, true);
                WriteLiteral("                                <td><p style=\"color:red;\">");
                EndContext();
                BeginContext(1752, 11, false);
#line 43 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                                                     Write(item.Status);

#line default
#line hidden
                EndContext();
                BeginContext(1763, 13, true);
                WriteLiteral("/5</p></td>\r\n");
                EndContext();
#line 44 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(1872, 59, true);
                WriteLiteral("                                <td><p style=\"color:blue;\">");
                EndContext();
                BeginContext(1932, 11, false);
#line 47 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                                                      Write(item.Status);

#line default
#line hidden
                EndContext();
                BeginContext(1943, 13, true);
                WriteLiteral("/5</p></td>\r\n");
                EndContext();
#line 48 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                            }

#line default
#line hidden
                BeginContext(1987, 31, true);
                WriteLiteral("                        </tr>\r\n");
                EndContext();
#line 50 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
                    }

#line default
#line hidden
                BeginContext(2041, 312, true);
                WriteLiteral(@"
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td><!--<button type=""submit"" class=""btn btn-success"">ส่งข้อมูลการเลือก</button>--></td>
                    </tr>
                </tbody>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2360, 45, true);
            WriteLiteral("\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n<p>");
            EndContext();
            BeginContext(2406, 12, false);
#line 64 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
Write(ViewBag.show);

#line default
#line hidden
            EndContext();
            BeginContext(2418, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(2428, 13, false);
#line 65 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
Write(ViewBag.show1);

#line default
#line hidden
            EndContext();
            BeginContext(2441, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(2451, 13, false);
#line 66 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
Write(ViewBag.show2);

#line default
#line hidden
            EndContext();
            BeginContext(2464, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(2474, 13, false);
#line 67 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
Write(ViewBag.show3);

#line default
#line hidden
            EndContext();
            BeginContext(2487, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(2497, 13, false);
#line 68 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Home\Techer.cshtml"
Write(ViewBag.show4);

#line default
#line hidden
            EndContext();
            BeginContext(2510, 8, true);
            WriteLiteral("</p>\r\n\r\n");
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