#pragma checksum "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\BackendTeacher\MainIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d7dac0a203eef91065e06eabdd97d681921118"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackendTeacher_MainIndex), @"mvc.1.0.view", @"/Views/BackendTeacher/MainIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BackendTeacher/MainIndex.cshtml", typeof(AspNetCore.Views_BackendTeacher_MainIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d7dac0a203eef91065e06eabdd97d681921118", @"/Views/BackendTeacher/MainIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42f8c1e7f84b2085c62db58c14ae0e4f8b26c0", @"/Views/_ViewImports.cshtml")]
    public class Views_BackendTeacher_MainIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<showdata>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BackendTeacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 149, true);
            WriteLiteral("<h3 style=\"text-align:center;\">อาจารย์</h3>\r\n<div class=\"form-group card-body card\">\r\n    <p>รายละเอียดForm ของนักศึกษา</p>\r\n\r\n\r\n    <p>ชื่อนักศึกษา:");
            EndContext();
            BeginContext(167, 12, false);
#line 7 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\BackendTeacher\MainIndex.cshtml"
               Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(179, 29, true);
            WriteLiteral("</p>\r\n    <p>ชื่อเรื่องวิจัย:");
            EndContext();
            BeginContext(209, 13, false);
#line 8 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\BackendTeacher\MainIndex.cshtml"
                  Write(ViewBag.title);

#line default
#line hidden
            EndContext();
            BeginContext(222, 27, true);
            WriteLiteral(" </p>\r\n    <p>Form cs1>> : ");
            EndContext();
            BeginContext(250, 17, false);
#line 9 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\BackendTeacher\MainIndex.cshtml"
               Write(ViewBag.timeimage);

#line default
#line hidden
            EndContext();
            BeginContext(267, 38, true);
            WriteLiteral("  </p>\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 305, "\"", 357, 2);
            WriteAttributeValue("", 312, "../print/Showcs1backend?idstudent=", 312, 34, true);
#line 10 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\BackendTeacher\MainIndex.cshtml"
WriteAttributeValue("", 346, ViewBag.id, 346, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(358, 79, true);
            WriteLiteral(" role=\"button\">ดูข้อมูลCs1</a>\r\n\r\n\r\n\r\n    <span>ให้สถานะนักศึกษา</span>\r\n\r\n    ");
            EndContext();
            BeginContext(437, 1164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d7dac0a203eef91065e06eabdd97d6819211187519", async() => {
                BeginContext(509, 224, true);
                WriteLiteral("\r\n        <div class=\"input-group input-group-lg\">\r\n            <div class=\"input-group-prepend\">\r\n                <span class=\"input-group-text\" id=\"inputGroup-sizing-lg\">Comment</span>\r\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 733, "\"", 752, 1);
#line 20 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\BackendTeacher\MainIndex.cshtml"
WriteAttributeValue("", 741, ViewBag.id, 741, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(753, 67, true);
                WriteLiteral(" id=\"idstudent\" name=\"idstudent\">\r\n            </div>\r\n            ");
                EndContext();
                BeginContext(820, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "78d7dac0a203eef91065e06eabdd97d6819211188623", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 22 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\BackendTeacher\MainIndex.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.comment);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(909, 685, true);
                WriteLiteral(@"
            <p><input type=""radio"" class=""btn btn-lg "" id=""status"" name=""status"" value=""1""> Pass<br></p>
            <p><input type=""radio"" id=""status"" name=""status"" value=""2""> Fail<br></p>




            <button type=""submit"" class=""btn btn-danger"">Comfrim</button>
            <!--</div>
     <div class=""row"">
         <div class=""col-4""><a href=""#"" class=""btn btn-danger "" style=""width:100%;"">ไม่รับนักศึกษาคนนี้</a></div>
         <div class=""col-4""><a href=""#"" class=""btn btn-info "" style=""width:100%;"">ไม่รับนักศึกษาคนนี้</a></div>
         <div class=""col-4""><a href=""#"" class=""btn btn-success "" style=""width:100%;"">ไม่รับนักศึกษาคนนี้</a></div>
     </div>-->
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1601, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<showdata> Html { get; private set; }
    }
}
#pragma warning restore 1591
