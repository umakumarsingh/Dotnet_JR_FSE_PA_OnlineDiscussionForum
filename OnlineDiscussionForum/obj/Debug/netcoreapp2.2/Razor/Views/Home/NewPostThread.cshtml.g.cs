#pragma checksum "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e40af9f1dcda108710b9a32ea0ea078ebea977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewPostThread), @"mvc.1.0.view", @"/Views/Home/NewPostThread.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NewPostThread.cshtml", typeof(AspNetCore.Views_Home_NewPostThread))]
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
#line 1 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\_ViewImports.cshtml"
using OnlineDiscussionForum;

#line default
#line hidden
#line 2 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\_ViewImports.cshtml"
using OnlineDiscussionForum.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e40af9f1dcda108710b9a32ea0ea078ebea977", @"/Views/Home/NewPostThread.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc24895ee8f7b06d238924f78ed5d5a21e76ef13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewPostThread : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineDiscussionForum.BusinessLayer.ViewModels.ForumThreadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select mr-sm-2 form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
  
    ViewData["Title"] = "Add New Post Thread";

#line default
#line hidden
            BeginContext(133, 469, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
<link rel=""stylesheet"" href=""/resources/demos/style.css"">
<script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>

<div class=""card"" style=""width:60%; margin:auto;"">
    <div class=""card-header bg-success text-white"">
        <h5>Add New Post Thread</h5>
    </div>
    <div class=""card-body"">
");
            EndContext();
#line 16 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(661, 23, false);
#line 18 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(699, 28, false);
#line 19 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(729, 141, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(871, 32, false);
#line 23 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
                   Write(Html.LabelFor(m => m.ThreadName));

#line default
#line hidden
            EndContext();
            BeginContext(903, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(930, 67, false);
#line 24 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
                   Write(Html.TextBoxFor(m => m.ThreadName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(997, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1023, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e40af9f1dcda108710b9a32ea0ea078ebea9777403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 25 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ThreadName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1088, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1253, 31, false);
#line 30 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
                   Write(Html.LabelFor(m => m.UserTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1310, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e40af9f1dcda108710b9a32ea0ea078ebea9779733", async() => {
                BeginContext(1492, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1522, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e40af9f1dcda108710b9a32ea0ea078ebea97710147", async() => {
                    BeginContext(1539, 13, true);
                    WriteLiteral("Please Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1561, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 31 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserTypes);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<OnlineDiscussionForum.Entities.UserType>();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1596, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1622, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e40af9f1dcda108710b9a32ea0ea078ebea97713581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 35 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserTypes);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1686, 216, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1903, 27, false);
#line 42 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
                   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1957, 62, false);
#line 43 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2019, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2045, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e40af9f1dcda108710b9a32ea0ea078ebea97716416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 44 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2105, 216, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(2322, 33, false);
#line 51 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
                   Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2355, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2382, 68, false);
#line 52 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
                   Write(Html.TextAreaFor(m => m.Description, new{ @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2476, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e40af9f1dcda108710b9a32ea0ea078ebea97719259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 53 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2542, 247, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group text-center\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Post</button>\r\n                <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2789, "\"", 2857, 4);
            WriteAttributeValue("", 2799, "location.href=\'", 2799, 15, true);
#line 59 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
WriteAttributeValue("", 2814, Url.Action("Index", "Home"), 2814, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 2842, "\';return", 2842, 8, true);
            WriteAttributeValue(" ", 2850, "false;", 2851, 7, true);
            EndWriteAttribute();
            BeginContext(2858, 44, true);
            WriteLiteral(">Back To Post</button>\r\n            </div>\r\n");
            EndContext();
#line 61 "D:\IIHT\Task-15\Dotnet_JR_FSE_PA_OnlineDiscussionForum\InMemory\OnlineDiscussionForum\Views\Home\NewPostThread.cshtml"
        }

#line default
#line hidden
            BeginContext(2913, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineDiscussionForum.BusinessLayer.ViewModels.ForumThreadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591