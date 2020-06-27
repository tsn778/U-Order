#pragma checksum "E:\efcore1\TinyShop\Views\Product\Shopping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8064e3baf1f9c5f5001b8f70bfe624a05a16021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Shopping), @"mvc.1.0.view", @"/Views/Product/Shopping.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Shopping.cshtml", typeof(AspNetCore.Views_Product_Shopping))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8064e3baf1f9c5f5001b8f70bfe624a05a16021", @"/Views/Product/Shopping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd6c6cd47b01eb7f0435ccd35d9e7ec2edf54cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Shopping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8064e3baf1f9c5f5001b8f70bfe624a05a160213732", async() => {
                BeginContext(161, 186, true);
                WriteLiteral("\r\n    <title>浏览产品</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <!-- import CSS -->\r\n    <link href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\"\r\n          rel=\"stylesheet\" />\r\n");
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
            BeginContext(356, 6217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8064e3baf1f9c5f5001b8f70bfe624a05a160215116", async() => {
                BeginContext(381, 6185, true);
                WriteLiteral(@"
    <el-container id=""app"">
        <el-main>
            <el-row>
                <el-col style=""padding: 10px;"">
                    <el-button type=""primary""
                               v-on:click=""onViewButtonClick"">
                        view视图显示
                    </el-button>
                    <el-button type=""primary""
                               v-on:click=""onTableButtonClick"">
                        Table表单显示
                    </el-button>
                    <el-button type=""success"" plain
                               icon=""el-icon-shopping-cart-2""
                               v-on:click=""onCartTableClick"">
                        购物车
                    </el-button>
                    <el-button type=""danger"" plain
                               icon=""el-icon-user-solid""
                               v-on:click=""onLoginClick"">
                        登录
                    </el-button>
                </el-col>
            </el-row>

            <el-ro");
                WriteLiteral(@"w>
                <el-col>
                    <el-table :border=""true""
                              :data=""products""
                              style=""width: 100%"">
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""产品编号""
                                         prop=""productNumber"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""产品名称""
                                         prop=""productName"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""产品类型""
                                         prop=""productType"">
                        </el-table-col");
                WriteLiteral(@"umn>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""价格""
                                         prop=""price"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""数量""
                                         prop=""shuliang"">

                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""总共""
                                         prop=""total"">

                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""时间"">

    ");
                WriteLiteral(@"                    </el-table-column>
                    </el-table>
                </el-col>
            </el-row>

            <el-row>
                <el-col style=""text-align: center;"">
                    <el-form-item label=""总金额""
                                  prop=""a"">

                    </el-form-item>
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
                products: [],
                a: '0'
            },
            methods: {
                async GetAllCart() {
                    let response = await axios.get('/Product/GetUserSh');

         ");
                WriteLiteral(@"           if (response.data.code === 'success') {
                        this.products = response.data.data;
                    } else {
                        this.$message({
                            message: '记录获取失败',
                            type: 'error'
                        });
                    }
                },

                onTableButtonClick() {
                    window.location.href = ""/Product/TableOrder"";
                },
                onViewButtonClick() {
                    window.location.href = ""/Product/UserOrder"";
                },
                onCartTableClick() {
                    window.location.href = ""/Product/CartTable"";
                },
                onLoginClick() {
                    window.location.href = ""/Login/Index"";
                },
                async YanUser() {
                    // 检索用户是否登录
                    let response = await axios.get('/Login/YanUser');

                    if (response.data.code =");
                WriteLiteral(@"== 'success') {
                        this.GetAllCart();
                    } else {
                        this.$message({
                            message: '您还未登录',
                            type: 'error'
                        });
                        this.$confirm('您还未登录，请进入登录界面登录,确定进入登录页面吗？',
                            '提示',
                            {
                                confirmButtonText: '确定',
                                cancelButtonText: '取消',
                                type: 'warning'
                            })
                            .then(async () => {
                                window.location.href = ""/Login/Index"";
                            })
                            .catch(async () => {
                                window.location.href = ""/Product/UserOrder"";
                            });;
                    }
                },

            },

            mounted() {
                this.YanUser();


  ");
                WriteLiteral("          }\r\n        });\r\n    </script>\r\n");
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
            BeginContext(6573, 11, true);
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