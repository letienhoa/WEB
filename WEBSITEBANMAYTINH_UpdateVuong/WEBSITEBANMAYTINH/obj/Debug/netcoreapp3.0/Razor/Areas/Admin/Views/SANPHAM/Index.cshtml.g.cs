#pragma checksum "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ef0bd9fcacdfa72b25aa6b8ff60d9fd117ceaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SANPHAM_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SANPHAM/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\_ViewImports.cshtml"
using WEBSITEBANMAYTINH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\_ViewImports.cshtml"
using WEBSITEBANMAYTINH.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ef0bd9fcacdfa72b25aa6b8ff60d9fd117ceaf", @"/Areas/Admin/Views/SANPHAM/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a821ca5d4a280845b1148a8f9e3b0d35140647d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SANPHAM_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WEBSITEBANMAYTINH.Models.SANPHAM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tyle", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">SanPham LIST</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ef0bd9fcacdfa72b25aa6b8ff60d9fd117ceaf6629", async() => {
                WriteLiteral("&nbsp;New SanPham");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<table class=\"table table-striped border\">\r\n    <thead>\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LOAISANPHAM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NHASANXUAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"text-align:center\">\r\n                ");
#nullable restore
#line 43 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:center\">\r\n                ");
#nullable restore
#line 46 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td style=\"text-align:center\">\r\n                ");
#nullable restore
#line 50 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:center\">\r\n");
#nullable restore
#line 53 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
                 if (!item.LOAISANPHAM.TenLoaiSanPham.Equals("--None--"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LOAISANPHAM.TenLoaiSanPham));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
                                                                                  
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td style=\"text-align:center\">\r\n");
#nullable restore
#line 59 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
                 if (!item.NHASANXUAT.TenNhaSanXuat.Equals("--None--"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NHASANXUAT.TenNhaSanXuat));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
                                                                                
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td style=\"width:200px\">\r\n                <div class=\"btn-group\" role=\"group\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ef0bd9fcacdfa72b25aa6b8ff60d9fd117ceaf13165", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-edit\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ef0bd9fcacdfa72b25aa6b8ff60d9fd117ceaf15637", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-list-alt\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ef0bd9fcacdfa72b25aa6b8ff60d9fd117ceaf18116", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-trash\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\LENOVO\Desktop\WEBSITEBANMAYTINH\WEBSITEBANMAYTINH\Areas\Admin\Views\SANPHAM\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WEBSITEBANMAYTINH.Models.SANPHAM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
