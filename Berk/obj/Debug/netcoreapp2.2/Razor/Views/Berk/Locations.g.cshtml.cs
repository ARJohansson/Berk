#pragma checksum "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7951d3e7ed82a8610afcc1cdd0499f2619f0c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Berk_Locations), @"mvc.1.0.view", @"/Views/Berk/Locations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Berk/Locations.cshtml", typeof(AspNetCore.Views_Berk_Locations))]
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
#line 1 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\_ViewImports.cshtml"
using Berk;

#line default
#line hidden
#line 2 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\_ViewImports.cshtml"
using Berk.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7951d3e7ed82a8610afcc1cdd0499f2619f0c4", @"/Views/Berk/Locations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89871c61962058644c85c427ee8412f707472377", @"/Views/_ViewImports.cshtml")]
    public class Views_Berk_Locations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Location>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(273, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(325, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(352, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b7951d3e7ed82a8610afcc1cdd0499f2619f0c43718", async() => {
                BeginContext(358, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Messages</title>\r\n");
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
            BeginContext(455, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(457, 424, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b7951d3e7ed82a8610afcc1cdd0499f2619f0c44996", async() => {
                BeginContext(463, 32, true);
                WriteLiteral("\r\n    List of Messages: <br />\r\n");
                EndContext();
#line 22 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
     foreach (Location place in Model)
    {

#line default
#line hidden
                BeginContext(542, 42, true);
                WriteLiteral("       <p style=\"align-content:center\"> <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 584, "\"", 602, 1);
#line 24 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
WriteAttributeValue("", 591, place.Link, 591, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(603, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(605, 10, false);
#line 24 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
                                                         Write(place.Name);

#line default
#line hidden
                EndContext();
                BeginContext(615, 19, true);
                WriteLiteral("; </a></p> <br />\r\n");
                EndContext();
                BeginContext(643, 17, false);
#line 25 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
   Write(place.Description);

#line default
#line hidden
                EndContext();
#line 25 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
                          ;

#line default
#line hidden
                BeginContext(661, 9, true);
                WriteLiteral(" <br />\r\n");
                EndContext();
#line 26 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
        
        //<a asp-action="Comment">Add a Comment or Review</a> <br />

#line default
#line hidden
                BeginContext(750, 16, true);
                WriteLiteral("        <br />\r\n");
                EndContext();
#line 29 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Berk\Locations.cshtml"
    }

#line default
#line hidden
                BeginContext(773, 101, true);
                WriteLiteral("    <br>\r\n    <a href=\"ContactPage\">Add a new message</a><br />\r\n    <a href=\"/Home/Index\">Home</a>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(881, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Location>> Html { get; private set; }
    }
}
#pragma warning restore 1591
