#pragma checksum "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba1c01341d224203325e3950a8cd97e7cb48b899"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomerServiceHistoryPartial), @"mvc.1.0.view", @"/Views/Shared/CustomerServiceHistoryPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba1c01341d224203325e3950a8cd97e7cb48b899", @"/Views/Shared/CustomerServiceHistoryPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a4a27c12d2a1437d4ce6c3365aa98e328b69f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomerServiceHistoryPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<helperland1._0.ViewModel.CustomerDashboard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/calendar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("calender"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/clock.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/cap.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(".."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
  
    int ServiceHistoryCount = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""service_history"" class=""tab-contant"">
    <div class=""clearfix"">
        <div class=""d-flex justify-content-between"">
            <p class=""alignleft""> Service History </p>
            <button id=""export"" class=""ServiceHistroyExport"" >Export</button>
        </div>
        <table class=""table"" id=""ServiceHistoryTable"">
            <thead class=""table-light"">
                <tr class=""text-center"">
                    <th scope=""col"" class=""serviceHistoryServiceDetails""> Service Details <img src=""/image/sort.png""></th>
                    <th scope=""col"" class=""serviceHistoryServiceProvider""> Service Provider <img src=""/image/sort.png""></th>
                    <th scope=""col"" class=""serviceHistoryServicePayment""> Payment <img src=""/image/sort.png""></th>
                    <th scope=""col"" class=""serviceHistoryServiceStatus""> Status <img src=""/image/sort.png""></th>
                    <th scope=""col""> Rate SP </th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 25 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                 if (Model.Count() > 0)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                     foreach (var item in Model)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                         if (item.Status == 3 || item.Status == 4)
                        {


                            string disabled, rateClass, statusbtn;

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                             if (item.Status == 3)
                            {
                                rateClass = "rateactive";
                                statusbtn = "completed";
                                disabled = "";
                            }
                            else
                            {

                                statusbtn = "cancelled";
                                disabled = "disabled";
                                rateClass = "rateDisabled";
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                             
                            ServiceHistoryCount = ServiceHistoryCount + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr data-value=");
#nullable restore
#line 51 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                      Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"text-center\">\r\n                                <td data-label=\"Service Details\">\r\n                                    <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba1c01341d224203325e3950a8cd97e7cb48b8999115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 53 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                                     Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <p class=\"service-time\">");
#nullable restore
#line 54 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                       Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 54 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                         Write(item.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n                                </td>\r\n\r\n                                <td data-label=\"Service Provider\" class=\"clearfix\">\r\n");
#nullable restore
#line 59 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                     if (item.ServiceProvider != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"cap-icon\"> <img");
            BeginWriteAttribute("src", " src=", 2731, "", 2760, 1);
#nullable restore
#line 61 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
WriteAttributeValue("", 2736, item.UserProfilePicture, 2736, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"..\"> </div>\r\n                                        <div style=\"font-weight:400\" class=\"text-start\"> ");
#nullable restore
#line 62 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                                    Write(item.ServiceProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("                                        <div>\r\n");
#nullable restore
#line 65 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                             for (int i = 1; i <= 5; i++)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                 if (i <= item.AverageRating)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:#ECB91C;\"></i>\r\n");
#nullable restore
#line 70 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"

                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:silver;\"></i>\r\n");
#nullable restore
#line 75 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 79 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                             Write(item.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n");
#nullable restore
#line 81 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td data-label=\"Payment\">\r\n                                    <p class=\"price\">&euro; ");
#nullable restore
#line 84 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                       Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                </td>\r\n\r\n                                <td data-label=\"Status\">\r\n\r\n                                    <button disabled");
            BeginWriteAttribute("class", " class=", 4203, "", 4220, 1);
#nullable restore
#line 89 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
WriteAttributeValue("", 4210, statusbtn, 4210, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                 Write(statusbtn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n                                </td>\r\n                                <td data-label=\"Rate SP\">\r\n                                    <button");
            BeginWriteAttribute("class", " class=", 4385, "", 4402, 1);
#nullable restore
#line 93 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
WriteAttributeValue("", 4392, rateClass, 4392, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 93 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                        Write(disabled);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#myRatingModal\">Rate</button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 96 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <div class=\"card mobileview clearfix mx-auto\" style=\"width:100%; padding:0% 5% 0% 5%; \">\r\n\r\n\r\n");
#nullable restore
#line 106 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                     if (item.Status == 3 || item.Status == 4)
                    {

                        string disabled, rateClass, statusbtn;

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                         if (item.Status == 3)
                        {
                            rateClass = "rateactive";
                            statusbtn = "completed";
                            disabled = "";
                        }
                        else
                        {

                            statusbtn = "cancelled";
                            disabled = "disabled";
                            rateClass = "rateDisabled";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-body\" data-value=");
#nullable restore
#line 129 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                     Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\r\n                            <span>\r\n\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba1c01341d224203325e3950a8cd97e7cb48b89920578", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<h6 class=\"d-inline pe-2 \"> <span class=\"d-none d-sm-inline-block\">Service</span>  Date:</h6><span class=\"date mb-0\">");
#nullable restore
#line 134 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                                                                                                                                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba1c01341d224203325e3950a8cd97e7cb48b89922291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<h6 class=\"pe-2 d-inline  \"><span class=\"d-none d-sm-inline-block\">Service</span> Time:</h6> ");
#nullable restore
#line 135 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                                                                                                                    Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 135 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                                                                                                                                      Write(item.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            </span>\r\n                            <hr>\r\n");
#nullable restore
#line 140 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                             if (item.ServiceProvider != null)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h6 class=\"pe-2 \">Service Provider Name:</h6>\r\n                                <div class=\"cap-icon\">  <img");
            BeginWriteAttribute("src", " src=", 6407, "", 6436, 1);
#nullable restore
#line 144 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
WriteAttributeValue("", 6412, item.UserProfilePicture, 6412, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"..\">   </div>\r\n");
#nullable restore
#line 145 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                           Write(item.ServiceProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n");
#nullable restore
#line 147 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                     for (int i = 1; i <= 5; i++)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                 if (i <= item.AverageRating)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:#ECB91C;\"></i>\r\n");
#nullable restore
#line 152 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"

                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star \" style=\"color:silver;\"></i>\r\n");
#nullable restore
#line 157 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>");
#nullable restore
#line 161 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                     Write(item.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    \r\n                                </div>\r\n");
            WriteLiteral("                                <hr />\r\n");
#nullable restore
#line 166 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"




                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <p class=\"price\"><h6 class=\"d-inline pe-2\">Price:</h6> &euro; ");
#nullable restore
#line 173 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                                     Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <hr>\r\n                            <div class=\"d-flex justify-content-around\">\r\n");
            WriteLiteral("\r\n                                <button disabled");
            BeginWriteAttribute("class", " class=", 7962, "", 7979, 1);
#nullable restore
#line 178 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
WriteAttributeValue("", 7969, statusbtn, 7969, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 178 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                             Write(statusbtn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                <button");
            BeginWriteAttribute("class", " class=", 8040, "", 8057, 1);
#nullable restore
#line 179 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
WriteAttributeValue("", 8047, rateClass, 8047, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#myRatingModal\" ");
#nullable restore
#line 179 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                                                                                                           Write(disabled);

#line default
#line hidden
#nullable disable
            WriteLiteral(">Rate SP</button>\r\n\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 184 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\CustomerServiceHistoryPartial.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>

















</div>

<!-- rate model  -->

<div class=""modal"" id=""myRatingModal"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered"" style=""max-width:500px"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div class=""show_rating_model"" id=""show_rating_model"">

                    <div class=""row ms-2"">

                        <div class=""col cap-icon"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba1c01341d224203325e3950a8cd97e7cb48b89931770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                        <div class=""col "">
                            <div class=""row service-provider-ratingmodel ps-2"" style=""width: 200px;"">  </div>
                            <div class=""star-ratingmodel text-start"">
                            </div>



                        </div>
                    </div>
                </div>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>



            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba1c01341d224203325e3950a8cd97e7cb48b89933450", async() => {
                WriteLiteral(@"
                    <h4 class=""rateservicepro"">
                        Rate Your Service Provider
                    </h4>
                    <hr class=""reschedulehr"">

                    <div class=""ontimearrival starratings ratingfortimearrival row ml-1"">
                        <p class=""mr-2 ratingtxt"">On Time Arrival</p>

                        <span class=""ratings1s "">
                            <i class=""fa fa-star "" id=""ontime1""></i>
                            <i class=""fa fa-star "" id=""ontime2""></i>
                            <i class=""fa fa-star "" id=""ontime3""></i>
                            <i class=""fa fa-star "" id=""ontime4""></i>
                            <i class=""fa fa-star "" id=""ontime5""></i>
                            <span class=""infomsg""></span>
                        </span>
                    </div>

                    <div class=""ontimearrival starratings ratingforfriendly row ml-1"">
                        <p class=""mr-2 ratingtxt"">Friendly</p>

    ");
                WriteLiteral(@"                    <span class=""ratings2 "">
                            <i class=""fa fa-star "" id=""friendly1""></i>
                            <i class=""fa fa-star "" id=""friendly2""></i>
                            <i class=""fa fa-star "" id=""friendly3""></i>
                            <i class=""fa fa-star "" id=""friendly4""></i>
                            <i class=""fa fa-star "" id=""friendly5""></i>
                            <span class=""friendlymsg""></span>
                        </span>
                    </div>

                    <div class=""ontimearrival starratings ratingforquality row ml-1"">
                        <p class=""mr-2 ratingtxt"">Quality Of Service</p>

                        <span class=""ratings3 "">
                            <i class=""fa fa-star "" id=""quality1""></i>
                            <i class=""fa fa-star "" id=""quality2""></i>
                            <i class=""fa fa-star "" id=""quality3""></i>
                            <i class=""fa fa-star "" id=""quality4""><");
                WriteLiteral(@"/i>
                            <i class=""fa fa-star "" id=""quality5""></i>
                            <span class=""qualitymsg""></span>

                        </span>
                    </div>

                    <div class=""form-group givefeedback"">
                        <label for=""feedbackcomment"">Comments</label>
                        <textarea class=""form-control"" id=""feedbackcomment"" rows=""2""></textarea>
                    </div>
                    <div class=""text-center"">
                        <button type=""submit"" data-bs-dismiss=""modal"" class=""rate"" id=""confirm_rating"">Submit</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<helperland1._0.ViewModel.CustomerDashboard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
