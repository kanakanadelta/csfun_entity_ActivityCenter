#pragma checksum "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1fabeac9e51638d4b75713e2ef2ee8ee59ecfa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1fabeac9e51638d4b75713e2ef2ee8ee59ecfa7", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "HomeNavPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#000;text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
  
  ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(35, 27, true);
            WriteLiteral("\n<div>\n  <!-- NAVBAR -->\n  ");
            EndContext();
            BeginContext(62, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1fabeac9e51638d4b75713e2ef2ee8ee59ecfa75267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(93, 426, true);
            WriteLiteral(@"
  <!-- TABLE -->
  <table id=""events-table"" style=""width:100%;border:1.5px solid #000;"">
    <thead>
      <thead>
        <tr>
          <th>Activity</th>
          <th>Date and Time</th>
          <th>Duration</th>
          <th>Event Coordinator</th>
          <th>Number of Participants</th>
          <th>Actions</th>
        </tr>
      </thead>
    </thead>
    <tbody>
      <!-- Dynamically Render rows for body -->
");
            EndContext();
#line 24 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
       foreach(var e in @ViewBag.Events)
      {

#line default
#line hidden
            BeginContext(568, 65, true);
            WriteLiteral("        <!-- Title -->\n        <tr>\n          <td>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 633, "\'", 658, 2);
            WriteAttributeValue("", 640, "/events/", 640, 8, true);
#line 29 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 648, e.EventId, 648, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 16, true);
            WriteLiteral(">\n              ");
            EndContext();
            BeginContext(676, 7, false);
#line 30 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
         Write(e.Title);

#line default
#line hidden
            EndContext();
            BeginContext(683, 94, true);
            WriteLiteral("\n            </a>\n          </td>\n          <!-- Date and Time -->\n          <td>\n            ");
            EndContext();
            BeginContext(778, 33, false);
#line 35 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
       Write(e.EventDateTime.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(811, 10, true);
            WriteLiteral(" &commat; ");
            EndContext();
            BeginContext(822, 36, false);
#line 35 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
                                                   Write(e.EventDateTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(858, 72, true);
            WriteLiteral("\n          </td>\n          <!-- Duration -->\n          <td>\n            ");
            EndContext();
            BeginContext(931, 10, false);
#line 39 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
       Write(e.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(941, 71, true);
            WriteLiteral("\n          </td>\n          <!-- Planner -->\n          <td>\n            ");
            EndContext();
            BeginContext(1013, 19, false);
#line 43 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
       Write(e.Planner.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1034, 18, false);
#line 43 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
                            Write(e.Planner.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 86, true);
            WriteLiteral("\n          </td>\n          <!-- Number of Participants -->\n          <td>\n            ");
            EndContext();
            BeginContext(1139, 20, false);
#line 47 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
       Write(e.Associations.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 59, true);
            WriteLiteral("\n          </td>\n          <!-- Actions -->\n          <td>\n");
            EndContext();
#line 51 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
             if(e.Planner.UserId == @ViewBag.UserId)
            {

#line default
#line hidden
            BeginContext(1285, 14, true);
            WriteLiteral("              ");
            EndContext();
            BeginContext(1299, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fabeac9e51638d4b75713e2ef2ee8ee59ecfa710715", async() => {
                BeginContext(1353, 68, true);
                WriteLiteral("\n                <input type=\"submit\" value=\"Delete\">\n              ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 1313, "events/", 1313, 7, true);
#line 53 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
AddHtmlAttributeValue("", 1320, e.EventId, 1320, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1330, "/delete", 1330, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1428, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 56 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
            }
            else if(@ViewBag.UserEvents.Contains(e))
            {

#line default
#line hidden
            BeginContext(1510, 14, true);
            WriteLiteral("              ");
            EndContext();
            BeginContext(1524, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fabeac9e51638d4b75713e2ef2ee8ee59ecfa713271", async() => {
                BeginContext(1578, 69, true);
                WriteLiteral("\n                <input type=\"submit\" value=\"Un-RSVP\">\n              ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 1538, "events/", 1538, 7, true);
#line 59 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
AddHtmlAttributeValue("", 1545, e.EventId, 1545, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1555, "/unRsvp", 1555, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1654, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 62 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1700, 14, true);
            WriteLiteral("              ");
            EndContext();
            BeginContext(1714, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fabeac9e51638d4b75713e2ef2ee8ee59ecfa715792", async() => {
                BeginContext(1766, 66, true);
                WriteLiteral("\n                <input type=\"submit\" value=\"RSVP\">\n              ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 1728, "events/", 1728, 7, true);
#line 65 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
AddHtmlAttributeValue("", 1735, e.EventId, 1735, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1745, "/rsvp", 1745, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 68 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
            }

#line default
#line hidden
            BeginContext(1854, 30, true);
            WriteLiteral("          </td>\n        </tr>\n");
            EndContext();
#line 71 "/Users/rtongson/Documents/csharp/exam/ActivityCenter/Views/Home/Home.cshtml"
      }

#line default
#line hidden
            BeginContext(1892, 103, true);
            WriteLiteral("    </tbody>\n  </table>\n  <!-- New Activity Button -->\n  <button style=\"float:right;margin:10px;\">\n    ");
            EndContext();
            BeginContext(1995, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fabeac9e51638d4b75713e2ef2ee8ee59ecfa718626", async() => {
                BeginContext(2083, 16, true);
                WriteLiteral("Add New Activity");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2103, 20, true);
            WriteLiteral(" \n  </button>\n</div>");
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
