#pragma checksum "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55de4ffc6ccd80fa5cd18fa566736660f8d5b40d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageAdmin), @"mvc.1.0.view", @"/Views/Message/MessageAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Message/MessageAdmin.cshtml", typeof(AspNetCore.Views_Message_MessageAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55de4ffc6ccd80fa5cd18fa566736660f8d5b40d", @"/Views/Message/MessageAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89871c61962058644c85c427ee8412f707472377", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessageBoard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(210, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(237, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55de4ffc6ccd80fa5cd18fa566736660f8d5b40d4203", async() => {
                BeginContext(243, 94, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>MessageAdmin</title>\r\n");
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
            BeginContext(344, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(346, 468, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55de4ffc6ccd80fa5cd18fa566736660f8d5b40d5485", async() => {
                BeginContext(352, 42, true);
                WriteLiteral("\r\n    List of Messages to Admins: <br />\r\n");
                EndContext();
#line 20 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
     foreach (Message message in Model)
    {
        

#line default
#line hidden
                BeginContext(451, 18, false);
#line 22 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
   Write(message.MemberName);

#line default
#line hidden
                EndContext();
#line 22 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
                           ;

#line default
#line hidden
                BeginContext(470, 9, true);
                WriteLiteral(" <br />\r\n");
                EndContext();
                BeginContext(488, 19, false);
#line 23 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
   Write(message.MessageText);

#line default
#line hidden
                EndContext();
#line 23 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
                            ;

#line default
#line hidden
                BeginContext(508, 17, true);
                WriteLiteral(" <br />\r\n        ");
                EndContext();
                BeginContext(525, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55de4ffc6ccd80fa5cd18fa566736660f8d5b40d7275", async() => {
                    BeginContext(597, 5, true);
                    WriteLiteral("Reply");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-memberName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
                                               WriteLiteral(message.MemberName);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["memberName"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-memberName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["memberName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(606, 25, true);
                WriteLiteral(" <br />\r\n        <br />\r\n");
                EndContext();
#line 26 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\BerkCommunityPage\Berk\Berk\Views\Message\MessageAdmin.cshtml"
    }

#line default
#line hidden
                BeginContext(638, 169, true);
                WriteLiteral("    <br>\r\n    <a href=\"MessageBoard\">Add a new message</a><br />\r\n    <a href=\"Messages\">Message other Community Members</a> <br />\r\n    <a href=\"/Home/Index\">Home</a>\r\n");
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
            BeginContext(814, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
