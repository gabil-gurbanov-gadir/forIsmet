#pragma checksum "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "957e9babc6596b4e98b2af78ad82cf9639598759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
#line 1 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\_ViewImports.cshtml"
using Eduhome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957e9babc6596b4e98b2af78ad82cf9639598759", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4645d12995731f20e89d000d9be3cfeead715910", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "957e9babc6596b4e98b2af78ad82cf96395987595058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 871, "~/uploads/teachers/", 871, 19, true);
#nullable restore
#line 29 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 890, Model.Image, 890, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 34 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 35 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                   Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 37 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                  Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
#nullable restore
#line 39 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 40 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" years experience</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 49 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 50 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span> ");
#nullable restore
#line 51 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                                        Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1949, "\"", 1965, 1);
#nullable restore
#line 53 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 1956, Model.Fb, 1956, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2042, "\"", 2060, 1);
#nullable restore
#line 54 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2049, Model.Pint, 2049, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2138, "\"", 2157, 1);
#nullable restore
#line 55 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2145, Model.Vimeo, 2145, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2231, "\"", 2249, 1);
#nullable restore
#line 56 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2238, Model.Twit, 2238, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
");
#nullable restore
#line 66 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                         foreach (var item in Model.TeacherSkills)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-4\">\r\n                                <div class=\"skill-bar-item\">\r\n                                    <span>");
#nullable restore
#line 70 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <div class=\"progress\">\r\n                                        <div data-wow-delay=\"1.2s\" data-wow-duration=\"1.5s\"");
            BeginWriteAttribute("style", " style=\"", 3019, "\"", 3145, 11);
            WriteAttributeValue("", 3027, "width:", 3027, 6, true);
#nullable restore
#line 72 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3033, item.Value, 3034, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3045, "%;", 3045, 2, true);
            WriteAttributeValue(" ", 3047, "visibility:", 3048, 12, true);
            WriteAttributeValue(" ", 3059, "visible;", 3060, 9, true);
            WriteAttributeValue(" ", 3068, "animation-duration:", 3069, 20, true);
            WriteAttributeValue(" ", 3088, "1.5s;", 3089, 6, true);
            WriteAttributeValue(" ", 3094, "animation-delay:", 3095, 17, true);
            WriteAttributeValue(" ", 3111, "1.2s;", 3112, 6, true);
            WriteAttributeValue(" ", 3117, "animation-name:", 3118, 16, true);
            WriteAttributeValue(" ", 3133, "fadeInLeft;", 3134, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-black\">");
#nullable restore
#line 73 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                                                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 78 "C:\Users\GabilGG\Documents\CodeWorks\04. Projects\PushPrj\p220_be_21_backendproject-gabil-gurbanov-gadir\BackendProject_Qabil\Eduhome\Views\Teacher\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
