#pragma checksum "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d9585708a5e8093d5eb333c49669bbec54f662a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DSUSoundBoothScheduler.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__ManageNav), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml", typeof(DSUSoundBoothScheduler.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__ManageNav))]
namespace DSUSoundBoothScheduler.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\_ViewImports.cshtml"
using DSUSoundBoothScheduler.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\_ViewImports.cshtml"
using Data;

#line default
#line hidden
#line 1 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using DSUSoundBoothScheduler.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using DSUSoundBoothScheduler.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d9585708a5e8093d5eb333c49669bbec54f662a", @"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74fc475686c14d278d4f3b198353688b100beb94", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7ad183500ff9f1ffa303bc52ebbaf94614268a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c50533c52fa5aaf17801f8b34f71cca251ab3dc", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__ManageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("change-password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./PersonalData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
            BeginContext(170, 47, true);
            WriteLiteral("<ul class=\"nav nav-pills nav-stacked\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 217, "\"", 267, 1);
#line 6 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 225, ManageNavPages.IndexNavClass(ViewContext), 225, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(268, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(269, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d9585708a5e8093d5eb333c49669bbec54f662a7138", async() => {
                BeginContext(291, 7, true);
                WriteLiteral("Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(302, 14, true);
            WriteLiteral("</li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 316, "\"", 375, 1);
#line 7 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 324, ManageNavPages.ChangePasswordNavClass(ViewContext), 324, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(377, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d9585708a5e8093d5eb333c49669bbec54f662a9047", async() => {
                BeginContext(429, 8, true);
                WriteLiteral("Password");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(441, 14, true);
            WriteLiteral("</li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 455, "\"", 512, 1);
#line 8 "C:\Users\johnj\Documents\COLLEGE\Fall2018\Tech Fellows\DSUSoundProductionHome\DSUSoundBoothScheduler\DSUSoundBoothScheduler\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 463, ManageNavPages.PersonalDataNavClass(ViewContext), 463, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(513, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(514, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d9585708a5e8093d5eb333c49669bbec54f662a11038", async() => {
                BeginContext(543, 13, true);
                WriteLiteral("Personal data");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(560, 14, true);
            WriteLiteral("</li>\r\n</ul>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<DSUSoundBoothSchedulerUser> SignInManager { get; private set; }
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
