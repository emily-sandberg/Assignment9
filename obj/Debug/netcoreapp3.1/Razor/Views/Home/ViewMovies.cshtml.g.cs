#pragma checksum "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd97e5d3c82b905055b81b09b8e4b094ee8ff441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewMovies), @"mvc.1.0.view", @"/Views/Home/ViewMovies.cshtml")]
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
#line 1 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/_ViewImports.cshtml"
using Assignment9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/_ViewImports.cshtml"
using Assignment9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd97e5d3c82b905055b81b09b8e4b094ee8ff441", @"/Views/Home/ViewMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b729fc83488da4ab55d3fe29f2f66e1677ef82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editMovieForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
  
    ViewData["Title"] = "View Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<br />\n<div class=\"text-center\">\n    <h2>Joel\'s Film Collection</h2>\n</div>\n\n<!--Print out films from database-->\n\n");
#nullable restore
#line 14 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card card-outline-primary m-1 p-1 card bg-light mb-3\">\n        <br />\n\n        <div class=\"ml-4\">\n            <h4>\n                ");
#nullable restore
#line 21 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
           Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h4>\n            <br />\n            <div class=\"text-muted\">\n                <p>");
#nullable restore
#line 25 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
              Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>");
#nullable restore
#line 26 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
              Write(x.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>");
#nullable restore
#line 27 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
              Write(x.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 28 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
                 if (x.Edited == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>This movie has been edited.</p>\n");
#nullable restore
#line 31 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>This movie hasn\'t been edited.</p>\n");
#nullable restore
#line 35 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\n                <p>Lent to: ");
#nullable restore
#line 37 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
                       Write(x.LentTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>Additional Notes: ");
#nullable restore
#line 38 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
                                Write(x.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <br />\n                <br />\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd97e5d3c82b905055b81b09b8e4b094ee8ff4417538", async() => {
                WriteLiteral("\n                    <button class=\"btn btn-sm btn-primary\" type=\"submit\">Edit</button>\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1163, "\"", 1181, 1);
#nullable restore
#line 43 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
WriteAttributeValue("", 1171, x.MovieId, 1171, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"movieId\" />\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <br />\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd97e5d3c82b905055b81b09b8e4b094ee8ff4419923", async() => {
                WriteLiteral("\n                    <input type=\"hidden\" name=\"movieId\"");
                BeginWriteAttribute("value", " value=\"", 1387, "\"", 1405, 1);
#nullable restore
#line 47 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
WriteAttributeValue("", 1395, x.MovieId, 1395, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <button class=\"btn btn-danger\" type=\"submit\">Delete</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <br />\n\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 55 "/Users/esandberg/Projects/Assignment9/Assignment9/Views/Home/ViewMovies.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
