#pragma checksum "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpUpcomingService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c02c5b84bf6d1699f0d07df2dccbb20ad565c3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SpUpcomingService), @"mvc.1.0.view", @"/Views/Shared/SpUpcomingService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c02c5b84bf6d1699f0d07df2dccbb20ad565c3d", @"/Views/Shared/SpUpcomingService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a4a27c12d2a1437d4ce6c3365aa98e328b69f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SpUpcomingService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""UpcomingService"" class=""tab-contant"">	<table id=""SPUpcomingServiceTable"" class=""table"">				<thead class=""table-light"">					<tr>						<th scope=""col"" style=""width:15%"">Service ID <img src=""/image/sort.png"" alt=""...""></th>						<th scope=""col""style=""width:20%"">Service date <img src=""/image/sort.png"" alt=""...""></th>						<th scope=""col"" style=""width:35%"">Customers details <img src=""/image/sort.png"" alt=""...""></th>						<th scope=""col"" style=""width:15%"">Completed</th>						<th scope=""col"" style=""width:15%"">Action</th>					</tr>				</thead>				<tbody id=""UpcomingServiceTbody"">					<tr data-value=""1"" >						<td data-label=""Service ID"">							<p class=""margin"">323436</p>						</td>						<td data-label=""Service date"">							<div><img src=""/image/calendar2.png"" alt=""calender""> 09/04/2018							</div>							<img src=""/image/layer-14.png"" alt=""clock""> 12:00-18:00						</td>");
            WriteLiteral("\t\t\t\t\t\t\t<td class=\"text-start\" data-lable=\"Customer Details\">\r\t\t\t\t\t\t\t\t<div class=\"ms-4\">David Bough</div>\r\t\t\t\t\t\t\t\t<div class=\"d-flex\" ><span><img  class=\"me-0\" src=\"/image/layer-15.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1253, "\"", 1259, 0);
            EndWriteAttribute();
            WriteLiteral(@"></span> <span>musterstrabe 5,12345							Bonn </span></div>								</td>						<td data-label=""Completed"">							<p class=""margin""><button class=""CompleteService d-none"">Complete</button></P>						</td>						<td data-label=""Action"">							<p class=""margin""><button class=""cancel"">Cancel</button></P>						</td>					</tr>					</tbody>		</table></div><div class=""modal"" tabindex=""-1"" id=""SPdeleteModelServiceRequest"">    <div class=""modal-dialog modal-dialog-centered"" style=""max-width: 500px"">        <div class=""modal-content"">             <input type=""hidden"" id=""CancelRequestId"" name=""CancelRequestId"" />            <div class=""modal-header"">                <h5 class=""modal-title"">Cancel Service Request</h5>                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>            </div>            <div class=""modal-body"">                <h4>Are you sure, want to cancel this request</h4>                <div class=""text-center"">                ");
            WriteLiteral("    <button class=\"customerCancel\" type=\"button\" data-bs-dismiss=\"modal\" class=\"mt-2 cancel\" id=\"SpCancelRequestBtn\">Yes, Cancel</button>\r                </div>\r            </div>\r        </div>\r    </div>\r</div>");
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
