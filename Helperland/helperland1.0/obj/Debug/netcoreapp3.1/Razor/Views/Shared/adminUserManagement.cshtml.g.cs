#pragma checksum "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\adminUserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97cd7ba5d05fd9be19277f78a133938f2d779287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_adminUserManagement), @"mvc.1.0.view", @"/Views/Shared/adminUserManagement.cshtml")]
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
#line 1 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\_ViewImports.cshtml"
using helperland1._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\_ViewImports.cshtml"
using helperland1._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97cd7ba5d05fd9be19277f78a133938f2d779287", @"/Views/Shared/adminUserManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a4a27c12d2a1437d4ce6c3365aa98e328b69f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_adminUserManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
 <div class=""col-10  table-col tab-contant"" id=""Usermanagement"">


    

            <div class=""row"">


                <div class=""col"">
                    <h4>User management</h4>

                </div>

                <div class=""col "" style="" text-align:right"">
                    <button class="" adduser""><span>+</span> Add new call center</button>

                </div>



            </div>
            <br>
            <div class=""row  form"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97cd7ba5d05fd9be19277f78a133938f2d7792875467", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""row"">


                        <div class=""col"">
                            
                            <input id=""UserFilterName"" type=""text"" class=""form-control  "" placeholder=""User Name"">
                        </div>
                        <div class=""col"">
                            <select  id=""UserFilterRole"" class=""form-select"" aria-label=""Default select example"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97cd7ba5d05fd9be19277f78a133938f2d7792876243", async() => {
                    WriteLiteral("User Role");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97cd7ba5d05fd9be19277f78a133938f2d7792877824", async() => {
                    WriteLiteral("customer");
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
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97cd7ba5d05fd9be19277f78a133938f2d7792879081", async() => {
                    WriteLiteral("Service provider");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97cd7ba5d05fd9be19277f78a133938f2d77928710346", async() => {
                    WriteLiteral("Admin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""input-group col"">
                            <span class=""input-group-text  "" id=""basic-addon1"">+45</span>
                            <input id=""UserFilterPhone"" type=""text"" class=""form-control  "" placeholder=""Mobile number"">
                        </div>
                        <div class=""col"">
                            <input id=""UserFilterPostalCode"" type=""text"" class=""form-control  "" placeholder=""Zip code"">

                        </div>

                        </div>


                        <div class=""row mt-4"">

                             <div class=""col"">
                            
                            <input id=""UserFilterEmail"" type=""text"" class=""form-control  "" placeholder=""Email"">
                        </div>

                            <div class=""col"">
                                <input  id=""UserFilterFromDate""  type=""text"" class=""form-contr");
                WriteLiteral(@"ol"" placeholder=""From Date""   onfocus=""(this.type='date')"" onblur=""if(this.value==''){this.type='text'}""  >
                            </div>
                            <div class=""col"">
                                <input id=""UserFilterToDate"" type=""text"" class=""form-control"" placeholder=""To Date"" onfocus=""(this.type='date')"" onblur=""if(this.value==''){this.type='text'}"">
                            </div>
                         <div class=""col"">
                                <a  id=""UserFilterSearch""  class=""btn btn-primary form-search me-4"" id=""filterSubmit"">Serach</a>
                                      <button id=""UserFilterClear"" type=""reset"" class=""btn btn-primary form-clear"" id=""filterclear"">Clear</button>

                            </div>
                <div class=""col""></div>
                            </div>

                        
                       
                        
                            
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""row  table"">

                <table class=""admin-table"" id=""adminUserTable"">
                    <thead class=""table-light"">
                        <tr>
                            <th class=""thdate"" scope=""col"">User Name<img src=""/image/sort.png"" alt=""...""></th>
                            <th  class=""thsp"" scope=""col"">Date of Registration<img src=""/image/sort.png"" alt=""...""></th>
                            <th  class=""thdate"" scope=""col"">User Type<img src=""/image/sort.png"" alt=""...""></th>
                            <th  class=""thdate"" scope=""col"">Phone<img src=""/image/sort.png"" alt=""...""></th>
                            <th  class=""thdate"" scope=""col"">Postal Code<img src=""/image/sort.png"" alt=""...""></th>
                            <th class=""thstatus"" scope=""col"">Status<img src=""/image/sort.png"" alt=""...""></th>
                            <th  class=""thstatus"" scope=""col"">Actions</th>
                        </tr>
                    </thead>");
            WriteLiteral(@"
                    <tbody id=""AdminUserTbody"">
                        <tr>
                            <td data-label=""User Name"">
                                <p>Lyum Watson</p>

                            </td>
                            <td data-label=""Role"">
                                <p>  </p>
                            </td>
                            <td data-label=""Date of Registration"">
                                <p> <img src=""/image/calendar2.png"" alt=""calender""> 29/12/2000 </p>
                            </td>
                            <td data-label=""User Type"">
                                <p>Customer</p>
                            </td>

                            <td data-label=""Phone"">
                                <p>8141657947</p>
                            </td>
                            <td data-label=""Postal Code"">
                                <p>365601</p>
                            </td>
                            <td data-labe");
            WriteLiteral(@"l=""Status"">
                                <button class=""active"">Active</button>
                                </td>
                            <td data-label=""Actions"">
                                <div class=""popup"" onclick=""reply_click(this.id)"" id=""a""><img
                                        src=""/image/group-38.png"" alt=""..."">
                                    <div class=""popuptext"" id=""a_popup"">
                                        <p>Active </p>
                                        <p>Deactive</p>
                                        <p>Approve</p>
                                        <p>DisApprove</p>
                                    </div>
                                </div>
                            </td>
                        </tr>
                       </tbody>

                </table>
               <span class=""copyright""> ??2018 Helperland. All rights reserved.
               </span>

            </div>







 </div>     ");
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
