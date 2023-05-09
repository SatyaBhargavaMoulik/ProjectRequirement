#pragma checksum "C:\Users\silic\OneDrive\Desktop\New folder (2)\JQuery_Ajax_PostBack\JQuery_Ajax_Postback\Views\AjaxExample\LoadCountries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90a170690a7b436e47dcfe2a3cde4792c44a6861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AjaxExample_LoadCountries), @"mvc.1.0.view", @"/Views/AjaxExample/LoadCountries.cshtml")]
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
#line 1 "C:\Users\silic\OneDrive\Desktop\New folder (2)\JQuery_Ajax_PostBack\JQuery_Ajax_Postback\Views\_ViewImports.cshtml"
using JQuery_Ajax_Postback;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\silic\OneDrive\Desktop\New folder (2)\JQuery_Ajax_PostBack\JQuery_Ajax_Postback\Views\_ViewImports.cshtml"
using JQuery_Ajax_Postback.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90a170690a7b436e47dcfe2a3cde4792c44a6861", @"/Views/AjaxExample/LoadCountries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc6793bdae4bea3b1c554b373bacd0823074af3", @"/Views/_ViewImports.cshtml")]
    public class Views_AjaxExample_LoadCountries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\silic\OneDrive\Desktop\New folder (2)\JQuery_Ajax_PostBack\JQuery_Ajax_Postback\Views\AjaxExample\LoadCountries.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a170690a7b436e47dcfe2a3cde4792c44a68613709", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>LoadCountries</title>
    <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#Country"").change(function () {
                $(""#State"").empty();
                $.ajax({
                    type: 'POST',
                    url: '");
#nullable restore
#line 21 "C:\Users\silic\OneDrive\Desktop\New folder (2)\JQuery_Ajax_PostBack\JQuery_Ajax_Postback\Views\AjaxExample\LoadCountries.cshtml"
                     Write(Url.Action("GetStates"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    dataType: 'json',
                    data: { id: $(""#Country"").val() },
                    success: function (x) {
                        $.each(x, function (i, y) {
                            $(""#State"").append('<option value=""' + y.Value + '"">' +
                                y.Text + '</option>');
                        });
                    }
                });
                return false;
            });


        })
    </script>
    
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a170690a7b436e47dcfe2a3cde4792c44a68615955", async() => {
                WriteLiteral("\r\n    <div>\r\n        <p>Country : ");
#nullable restore
#line 41 "C:\Users\silic\OneDrive\Desktop\New folder (2)\JQuery_Ajax_PostBack\JQuery_Ajax_Postback\Views\AjaxExample\LoadCountries.cshtml"
                Write(Html.DropDownList("Country", ViewData["countryList"] as List<SelectListItem>));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <p>State : ");
#nullable restore
#line 43 "C:\Users\silic\OneDrive\Desktop\New folder (2)\JQuery_Ajax_PostBack\JQuery_Ajax_Postback\Views\AjaxExample\LoadCountries.cshtml"
              Write(Html.DropDownList("State", new SelectList(String.Empty, "Value", "Text"), "Please Select State", new { style = "width:250px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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