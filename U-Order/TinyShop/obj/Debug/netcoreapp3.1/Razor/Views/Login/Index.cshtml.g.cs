#pragma checksum "E:\efcore1\TinyShop\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c914531eac92ec081627c6ea729f58c972725565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
#line 1 "E:\efcore1\TinyShop\Views\_ViewImports.cshtml"
using TinyShop;

#line default
#line hidden
#line 2 "E:\efcore1\TinyShop\Views\_ViewImports.cshtml"
using TinyShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c914531eac92ec081627c6ea729f58c972725565", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd6c6cd47b01eb7f0435ccd35d9e7ec2edf54cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(155, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c914531eac92ec081627c6ea729f58c9727255653697", async() => {
                BeginContext(161, 186, true);
                WriteLiteral("\r\n    <title>添加产品</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <!-- import CSS -->\r\n    <link href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\"\r\n          rel=\"stylesheet\" />\r\n");
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
            BeginContext(354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(356, 2969, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c914531eac92ec081627c6ea729f58c9727255655081", async() => {
                BeginContext(381, 2937, true);
                WriteLiteral(@"

<el-container id=""app"" style=""height: 900px; background-color: rgb(0, 132, 255);"">
    <el-main >
       
        <el-row>
            <el-col :span=""12"" offset=""8"">
                <br></br>
                <br></br>
                <el-card class=""box-card"" style=""height: 400px; width: 500px;"">
                    <el-form :model=""user"" label-width=""auto"">
                        <el-form-item>
                            <h1>登 录</h1>
                        </el-form-item>
                        <el-divider></el-divider>
                        <el-form-item>
                            <el-input v-model=""products.userNumber"" placeholder=""请输入用户名""></el-input>
                        </el-form-item>
                        <el-form-item>
                            <el-input v-model=""products.userPassword"" placeholder=""请输入密码"" :show-password=true></el-input>
                        </el-form-item>
                        <el-divider></el-divider>
                        <el-form-item ");
                WriteLiteral(@"style=""text-align: center;"">
                            <el-button style=""width: 200px;"" type=""primary"" round v-on:click=""onAddButtonClick""><i class=""el-icon-user-solid""></i> 登 录</el-button>
                            <el-button v-on:click=""onButtonClick"" style=""width: 200px;"" type=""success"" round> 注册</el-button>
                        </el-form-item>
                    </el-form>
                </el-card>
            </el-col>
        </el-row>

    </el-main>
</el-container>
    <!-- import Vue before Element -->
    <script src=""https://unpkg.com/vue/dist/vue.js""></script>
    <!-- import JavaScript -->
    <script src=""https://unpkg.com/element-ui/lib/index.js""></script>
    <script src=""https://cdn.bootcdn.net/ajax/libs/axios/0.19.2/axios.js""></script>
    <script>
        const app = new Vue({
            el: ""#app"",
            data: {
                products: {
                    userNumber: '',
                    userPassword: ''
                    }
                ");
                WriteLiteral(@"
            },
            methods: {
                async onAddButtonClick() {
                    const response = await axios.post('/Login/UserYanzheng', this.products
                    );
                    if (response.data.code === 'manage') {
                        window.location = ""/Product/Index"";
                        }
                    else if (response.data.code === 'success') {
                       
                        window.location = ""/Product/UserOrder"";
                    } else {
                        this.$message({
                            message: '登录失败',
                            type: 'error'
                        });
                    }
                },
                onButtonClick() {
                    window.location = ""/Login/Zhuce"";
                }
            }
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3325, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
