#pragma checksum "E:\TaiLieuOnThi\ThuNgan\0306191337_0306191313\0306191337_0306191313\Views\Accounts\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0479384cbdf974a6c95e060112589a468479d12e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Login), @"mvc.1.0.view", @"/Views/Accounts/Login.cshtml")]
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
#line 1 "E:\TaiLieuOnThi\ThuNgan\0306191337_0306191313\0306191337_0306191313\Views\_ViewImports.cshtml"
using _0306191337_0306191313;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TaiLieuOnThi\ThuNgan\0306191337_0306191313\0306191337_0306191313\Views\_ViewImports.cshtml"
using _0306191337_0306191313.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0479384cbdf974a6c95e060112589a468479d12e", @"/Views/Accounts/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c0d3cc460e0ba45693ca508e50fbc50a87fecf", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_0306191337_0306191313.Models.login>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signupform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<link href=""//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<div class=""container"">
    <div id=""loginbox"" style=""margin-top:50px;"" class=""mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2"">
        <div class=""panel panel-info"">
            <div class=""panel-heading"">
                <div class=""panel-title"">Sign In</div>
                <div style=""float:right; font-size: 80%; position: relative; top:-10px""><a href=""#"">Forgot password?</a></div>
            </div>

            <div style=""padding-top:30px"" class=""panel-body"">

                <div style=""display:none"" id=""login-alert"" class=""alert alert-danger col-sm-12""></div>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0479384cbdf974a6c95e060112589a468479d12e6249", async() => {
                WriteLiteral(@"

                    <div style=""margin-bottom: 25px"" class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                        <input id=""login-username"" type=""text"" class=""form-control"" name=""username""");
                BeginWriteAttribute("value", " value=\"", 1405, "\"", 1413, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""username or email"">
                    </div>

                    <div style=""margin-bottom: 25px"" class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-lock""></i></span>
                        <input id=""login-password"" type=""password"" class=""form-control"" name=""password"" placeholder=""password"">
                    </div>



                    <div class=""input-group"">
                        <div class=""checkbox"">
                            <label>
                                <input id=""login-remember"" type=""checkbox"" name=""remember"" value=""1""> Remember me
                            </label>
                        </div>
                    </div>


                    <div style=""margin-top:10px"" class=""form-group"">
                        <!-- Button -->

                        <div class=""col-sm-12 controls"">
                            <button type=""submit"" class=""btn btn-primary""> LOGIN</button>
     ");
                WriteLiteral(@"                       <a id=""btn-fblogin"" href=""#"" class=""btn btn-primary"">Login with Facebook</a>

                        </div>
                    </div>


                    <div class=""form-group"">
                        <div class=""col-md-12 control"">
                            <div style=""border-top: 1px solid#888; padding-top:15px; font-size:85%"">
                                Don't have an account!
                                <a href=""#"" onClick=""$('#loginbox').hide(); $('#signupbox').show()"">
                                    Sign Up Here
                                </a>
                            </div>
                        </div>
                    </div>
                ");
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
            WriteLiteral(@"



            </div>
        </div>
    </div>
    <div id=""signupbox"" style=""display:none; margin-top:50px"" class=""mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2"">
        <div class=""panel panel-info"">
            <div class=""panel-heading"">
                <div class=""panel-title"">Sign Up</div>
                <div style=""float:right; font-size: 85%; position: relative; top:-10px""><a id=""signinlink"" href=""#"" onclick=""$('#signupbox').hide(); $('#loginbox').show()"">Sign In</a></div>
            </div>
            <div class=""panel-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0479384cbdf974a6c95e060112589a468479d12e10990", async() => {
                WriteLiteral(@"

                    <div id=""signupalert"" style=""display:none"" class=""alert alert-danger"">
                        <p>Error:</p>
                        <span></span>
                    </div>



                    <div class=""form-group"">
                        <label for=""email"" class=""col-md-3 control-label"">Email</label>
                        <div class=""col-md-9"">
                            <input type=""text"" class=""form-control"" name=""email"" placeholder=""Email Address"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""firstname"" class=""col-md-3 control-label"">First Name</label>
                        <div class=""col-md-9"">
                            <input type=""text"" class=""form-control"" name=""firstname"" placeholder=""First Name"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""lastname"" clas");
                WriteLiteral(@"s=""col-md-3 control-label"">Last Name</label>
                        <div class=""col-md-9"">
                            <input type=""text"" class=""form-control"" name=""lastname"" placeholder=""Last Name"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""password"" class=""col-md-3 control-label"">Password</label>
                        <div class=""col-md-9"">
                            <input type=""password"" class=""form-control"" name=""password"" placeholder=""Password"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""icode"" class=""col-md-3 control-label"">Invitation Code</label>
                        <div class=""col-md-9"">
                            <input type=""text"" class=""form-control"" name=""icode""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5746, "\"", 5760, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <!-- Button -->
                        <div class=""col-md-offset-3 col-md-9"">
                            <button id=""btn-signup"" type=""button"" class=""btn btn-info""><i class=""icon-hand-right""></i> &nbsp Sign Up</button>
                            <span style=""margin-left:8px;"">or</span>
                        </div>
                    </div>

                    <div style=""border-top: 1px solid #999; padding-top:20px"" class=""form-group"">

                        <div class=""col-md-offset-3 col-md-9"">
                            <button id=""btn-fbsignup"" type=""button"" class=""btn btn-primary""><i class=""icon-facebook""></i>   Sign Up with Facebook</button>
                        </div>

                    </div>   
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<p> ");
#nullable restore
#line 141 "E:\TaiLieuOnThi\ThuNgan\0306191337_0306191313\0306191337_0306191313\Views\Accounts\Login.cshtml"
Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_0306191337_0306191313.Models.login> Html { get; private set; }
    }
}
#pragma warning restore 1591