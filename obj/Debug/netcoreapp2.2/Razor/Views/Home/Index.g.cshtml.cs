#pragma checksum "/Users/runkanchano/Desktop/Vitcome/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e906e2459f2b01b168686dea872eb081c7fd66e"
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
#line 1 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#line 2 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e906e2459f2b01b168686dea872eb081c7fd66e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42f8c1e7f84b2085c62db58c14ae0e4f8b26c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Select", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/runkanchano/Desktop/Vitcome/Views/Home/Index.cshtml"
   ViewData["Title"] = "ระบบยืนสมัครวิจัยวิทยาการคอมพิวเตอร์"; 

#line default
#line hidden
            BeginContext(65, 144, true);
            WriteLiteral("\n<script>\n    function topFunction() {\n        document.body.scrollTop = -50;\n        document.documentElement.scrollTop = +50;\n    }\n</script>\n");
            EndContext();
            BeginContext(209, 677, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e906e2459f2b01b168686dea872eb081c7fd66e4543", async() => {
                BeginContext(215, 664, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/gh/froala/design-blocks@master/dist/css/froala_blocks.min.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/froala-editor@2.9.1/css/froala_editor.pkgd.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/froala-editor@2.9.1/css/froala_style.min.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(886, 2747, true);
            WriteLiteral(@"


<section class=""fdb-block"" data-block-type=""contents"" data-id=""1"" draggable=""true"">
    <div class=""col-fill-right"" style=""background-image: url(&quot;https://images.unsplash.com/photo-1521714161819-15534968fc5f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80&quot;); z-index: 10000;""></div>

    <div class=""container py-5"">
        <div class=""row"">
            <div class=""col-12 col-md-5 text-center"" style=""z-index: 10000;"">
                <h2>ระบบยื่นสมัครการทำวิจัย CS1</h2>
                <p class=""lead"">ระบบนี้จัดทำขึ้นเพื่อการใช้อำนวยความสะดวกให้กับอาจารย์และนักเรียนภายในมหาวิทยาลัยราชภัฎจันทรเกษม.</p>
                <p class=""mt-4 mb-5""><a class=""btn btn-secondary"" href=""#section1"">ไปหน้าล็อกอิน</a></p>
                
            </div>
        </div>
</section>
<a name=""section1""></a>
<section class=""fdb-block"" style=""background-image: url(https://cdn.jsdelivr.net/gh/froala/design-blocks@2.0.1/dist/imgs//hero/red.svg);"" data-block-type=""forms"" data-id=""4"" draggable=""tr");
            WriteLiteral(@"ue"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-md-8 col-lg-7 col-xl-5 text-center"" style=""z-index: 10000;"">
                <div class=""fdb-box"">
                    <div class=""row""><div class=""col""><h1>Log In</h1></div></div>



                    <div class=""row mt-4"">
                        <div class=""col"">
                            <input type=""text"" class=""form-control"" placeholder=""รหัสนักศึกษา"" value="""">
                        </div>
                    </div><div class=""row mt-4"">
                        <div class=""col"">
                            <input type=""password"" class=""form-control mb-1"" placeholder=""รหัสผ่าน"" value="""">
                            <p class=""text-right"">
                                <a href=""#section2"">สมัครสมาชิก</a>


                            </p>
                        </div>
                    </div>
                    <div class=""row mt-4"">
                        <div class=""col"">

   ");
            WriteLiteral(@"                         <button class=""btn btn-outline-secondary"" type=""button"">Submit</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""fdb-block"" data-block-type=""forms"" data-id=""6"" draggable=""true"">
    <div class=""container""><a name=""section2""></a>
        <div class=""row justify-content-center"">
            <div class=""col-12 col-md-8 col-lg-7 col-md-5 text-center"" style=""z-index: 10000;"">
                <div class=""fdb-box fdb-touch"">
                    <div class=""row"">
                        <h1 style=""display:block;margin:auto;"">Register</h1>
                        ");
            EndContext();
            BeginContext(3633, 2775, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e906e2459f2b01b168686dea872eb081c7fd66e9316", async() => {
                BeginContext(3694, 2707, true);
                WriteLiteral(@"
                            <div class=""form-group "">
                                <label for=""exampleInputEmail1"">รหัสนักศึกษา</label>
                                <input type=""number"" class=""form-control"" name=""idstudent"" aria-describedby=""emailHelp"" placeholder=""Enter IDstudent"">
                                <small id=""emailHelp"" class=""form-text text-muted"">กรุณากรอกรหัสนักศึกษา.</small>
                            </div>
                            <div class=""form-group"">
                                <label for=""exampleInputPassword1"">รหัสผ่าน</label>
                                <input type=""password"" class=""form-control"" name=""password"" placeholder=""Password"">
                            </div>
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text"">ชื่อและนามสกุล</span>
                                </div>
                                <input type=""tex");
                WriteLiteral(@"t"" aria-label=""First name"" name=""name"" class=""form-control"" placeholder=""ชื่อ"">
                                <input type=""text"" aria-label=""Last name"" name=""lastname"" class=""form-control"" placeholder=""นามสกุล"">
                            </div>
                            <div class=""form-group "" style=""padding-top:8px; text-align: center;"">
                                <div class=""mx-auto form-control "">
                                    <input type=""checkbox"" aria-label=""Checkbox for following text input"" name=""year"" value=""3""> <span>ปี3</span>
                                    <input type=""checkbox"" aria-label=""Checkbox for following text input"" name=""year"" value=""4""><span>ปี4</span>
                                    <input type=""checkbox"" aria-label=""Checkbox for following text input"" name=""year"" value=""5""> <span>ภาคนอกเวลา</span>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <labe");
                WriteLiteral(@"l for=""exampleInputPassword1"">อีเมล</label>
                                <input type=""email"" class=""form-control"" name=""email"" placeholder=""Email"">
                            </div>
                            <div class=""form-group"">
                                <label for=""exampleInputPassword1"">เบอร์โทรติดต่อได้</label>
                                <input type=""number"" class=""form-control"" name=""telephone"" placeholder=""Telephone"">
                            </div>

                            <button style=""display: block;margin-left: auto;margin-right: auto;"" type=""submit"" class=""btn btn-primary"">Submit</button>
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
            BeginContext(6408, 5241, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>


</section>
<section class=""fdb-block py-5 fp-active"" data-block-type=""testimonials"" data-id=""3"" draggable=""true"">
    <div class=""container py-5"" style=""background-image: url(https://cdn.jsdelivr.net/gh/froala/design-blocks@2.0.1/dist/imgs//shapes/2.svg);"">
        <div class=""row align-items-center justify-content-center"">
            <div class=""col-lg-9 col-xl-6"" style=""z-index: 10000;"">
                <div class=""fdb-box"">
                    <div class=""row""><div class=""col-8 col-sm-6 col-md-4 col-xl-3 ml-auto mr-auto fr-box"" role=""application"" style=""z-index: 10000;""><div class=""fr-wrapper"" dir=""auto""><div aria-disabled=""false"" class=""fr-element fr-view"" contenteditable=""true"" dir=""auto"" spellcheck=""true"">
                        <p><img alt=""image"" class=""img-fluid rounded"" src=""https://scontent.fbkk5-8.fna.fbcdn.net/v/t1.0-9/62144328_2444717582215695_877768251604467712_n.jpg?_nc_cat=106&_nc_oc=AQlcyEEsiR");
            WriteLiteral(@"1STs22We0wIkZFEinD1dpm3xIgfrHMVFbZaeUWPcZJclCjNtHcZYTcl9PysF5rocFhScAvx9Vn_PfT&_nc_ht=scontent.fbkk5-8.fna&oh=71bfc903b120b1b09ca4314d241d2d87&oe=5E09165F""></p></div></div></div><div class=""col-md-8 mt-4 mt-md-0 fr-box"" role=""application"" style=""z-index: 10000;""><div class=""fr-wrapper"" dir=""auto""><div aria-disabled=""false"" class=""fr-element fr-view"" contenteditable=""true"" dir=""auto"" spellcheck=""true"">
                        <p class=""lead"">""ผมนาย ธันวา เม๊าะหะมะ ผู้จัดทำโปรเจคและออกแบบระบบโดยรวม ศึกษาอยู่ชั้นปีที่ 4 มหาวิทยาลัยราชภัฎจันทรเกษม.""</p>
                        <p class=""h3 mt-4 mt-xl-5""><strong>Programmer&Design</strong></p>
                        </div></div></div></div>
                </div>
            </div>

            <div class=""col-lg-9 col-xl-6 mt-4 mt-xl-0"" style=""z-index: 10000;"">
                <div class=""fdb-box"">
                    <div class=""row"">
                        <div class=""col-8 col-sm-6 col-md-4 col-xl-3 ml-auto mr-auto fr-box"" role=""application"" style=""z-index: 1");
            WriteLiteral(@"0000;"">
                            <div class=""fr-wrapper"" dir=""auto""><div aria-disabled=""false"" class=""fr-element fr-view"" contenteditable=""true"" dir=""auto"" spellcheck=""true"">
                                <p><img alt=""image"" class=""img-fluid rounded"" src=""https://scontent.fbkk5-3.fna.fbcdn.net/v/t1.0-9/19990360_1450085998411381_5422867734176143455_n.jpg?_nc_cat=105&_nc_oc=AQno44mmyCfi35P_EnovA3GivX2FfMUR5ec7mo2cmYYX040eyNFkH9RCekFEYQ0bNJj1g3obpPx6M-tNhar2CRSs&_nc_ht=scontent.fbkk5-3.fna&oh=4169afde4e2fb5da4c7622b8fe204aa9&oe=5E0207D2""></p></div></div>
                        </div><div class=""col-md-8 mt-4 mt-md-0 fr-box"" role=""application"" style=""z-index: 10000;""><div class=""fr-wrapper"" dir=""auto"">
                        <div aria-disabled=""false"" class=""fr-element fr-view"" contenteditable=""true"" dir=""auto"" spellcheck=""true"">
                        <p class=""lead"">""ผมนาย รัญ ผู้ออกแบบฐานข้อมูลและระบบของโปรเจค ศึกษาอยู่ชั้นปีที่ 4 มหาวิทยลัยราชภัฎจันทรเกษม.""</p>
                        <p class=""h3 mt-");
            WriteLiteral(@"4 mt-xl-5""><strong>Deverroper&Datasign</strong></p>
                        </div></div></div>
                    </div>
                </div>
            </div>
        </div>                 
    </div>
</section>

<footer class=""fdb-block footer-large"" data-block-type=""footers"" data-id=""2"">
    <div class=""container"">
        <div class=""row text-center"">
            <div class=""col fr-box"" role=""application"" style=""z-index: 10000;"">
                <div class=""fr-wrapper"" dir=""auto""><div class=""fr-element fr-view"" dir=""auto"" contenteditable=""true"" aria-disabled=""false"" spellcheck=""true"">
                    <h3>Address </h3><p>39/1 Ratchadaphisek Rd, Khwaeng Chan Kasem, Khet Chatuchak, Krung Thep Maha Nakhon 10900</p><p>+02 942 6800</p></div></div>
            </div>
        </div>

        <div class=""row mt-4"">
            <div class=""col text-center fr-box"" role=""application"" style=""z-index: 10000;"">
                <div class=""fr-wrapper"" dir=""auto""><div class=""fr-element fr-view"" dir=""auto"" content");
            WriteLiteral(@"editable=""true"" aria-disabled=""false"" spellcheck=""true""><p class=""lead""><a class=""mx-2"" href=""https://www.froala.com""><!-- <i class=""fab fa-twitter"" aria-hidden=""true""></i> --></a> <a class=""mx-2"" href=""https://www.froala.com""><!-- <i class=""fab fa-facebook"" aria-hidden=""true""></i> --></a> <a class=""mx-2"" href=""https://www.froala.com""><!-- <i class=""fab fa-instagram"" aria-hidden=""true""></i> --></a> <a class=""mx-2"" href=""https://www.froala.com""><!-- <i class=""fab fa-pinterest"" aria-hidden=""true""></i> --></a> <a class=""mx-2"" href=""https://www.froala.com""><!-- <i class=""fab fa-google"" aria-hidden=""true""></i> --></a></p></div></div>
            </div>
        </div>
    </div>
</footer>


<script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/froala-editor@2.9.");
            WriteLiteral("1/js/froala_editor.pkgd.min.js\"></script>\n<script src=\"https://use.fontawesome.com/releases/v5.5.0/js/all.js\"></script>\n\n");
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
