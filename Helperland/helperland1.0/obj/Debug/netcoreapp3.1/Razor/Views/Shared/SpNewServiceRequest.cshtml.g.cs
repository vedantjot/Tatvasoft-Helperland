#pragma checksum "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afaf4861b721c43ff11df17a851bf339147bcf5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SpNewServiceRequest), @"mvc.1.0.view", @"/Views/Shared/SpNewServiceRequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afaf4861b721c43ff11df17a851bf339147bcf5b", @"/Views/Shared/SpNewServiceRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a4a27c12d2a1437d4ce6c3365aa98e328b69f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SpNewServiceRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<helperland1._0.ViewModel.SPDashboard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<div id=\"NewServiceRequest\" class=\"tab-contant\">\r\n\r\n\t<div class=\"clearfix\">\r\n\t\t<div class=\"d-flex justify-content-between\">\r\n\t\t\t<p class=\"alignleft \"> Customer Service Request </p>\r\n\t\t\t\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afaf4861b721c43ff11df17a851bf339147bcf5b4051", async() => {
                WriteLiteral(" <button class=\"alignright \">Add new request</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

		</div>
		<input type=""checkbox"" id=""newRequestPet""  style=""margin-left:2%; transform: scale(1.5); "" checked=""checked"">
            <label for=""vehicle1""> Include pet at home </label><br><br />



		<table id=""SPServiceRequestTable"" class=""table"">


			<thead class=""table-light"">
				<tr class=""text-center"">
					<th scope=""col"" style=""width:10%"">  ID</th>
					<th scope=""col"" style=""width:20%""> Service Date</th>
					<th scope=""col"" style=""width:30%""> Customer Details</th>
					<th scope=""col"" style=""width:15%""> Payment</th>
					<th scope=""col"" style=""width:15%"">  Conflict</th>
					<th scope=""col"" style=""width:10%""> Actions</th>
				</tr>
			</thead>
			<tbody>

");
#nullable restore
#line 34 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                 if (Model.Count() > 0)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                     foreach (var item in Model)
					{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr class=\"text-center\" data-value=");
#nullable restore
#line 39 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                      Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t<td data-label=\"Service ID\">");
#nullable restore
#line 41 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                   Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td data-label=\"Service Date\">\r\n\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<span><img src=\"/image/calendar2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1388, "\"", 1394, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n\t\t\t\t\t\t\t\t\t<span class=\"upcoming-date\"><b>");
#nullable restore
#line 46 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                              Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<span><img src=\"/image/layer-14.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1544, "\"", 1550, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 50 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                     Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 50 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                       Write(item.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td class=\"text-start\" data-lable=\"Customer Details\">\r\n\t\t\t\t\t\t\t\t<div class=\"ms-4\">");
#nullable restore
#line 54 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                             Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t<div class=\"d-flex\" ><span><img  class=\"me-0\" src=\"/image/layer-15.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1839, "\"", 1845, 0);
            EndWriteAttribute();
            WriteLiteral("></span> <span>");
#nullable restore
#line 55 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                                                                                        Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> <span class=\"d-none\">");
#nullable restore
#line 55 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                                                                                                                                   Write(item.HasPet);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></div>\r\n\t\t\t\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t\t\t<td data-lable=\"Payment\" class=\"price\">\r\n\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 59 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                 Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &euro;\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td data-lable=\"Time Conflict\" >\r\n");
#nullable restore
#line 62 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                   
									string conflictIdtemp= "Conflict" +@item.ServiceRequestId;
								

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<a class=\"newReqConflictBtn d-none\"");
            BeginWriteAttribute("id", " id=", 2233, "", 2252, 1);
#nullable restore
#line 65 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
WriteAttributeValue("", 2237, conflictIdtemp, 2237, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Conflict</a>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td data-lable=\"Actions\">\r\n\t\t\t\t\t\t\t\t<a class=\"newReqAcceptBtn\">Accept</a>\r\n\t\t\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 72 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"


					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                     
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


			</tbody>


		</table>


	</div>


</div>




<!--Sp New Service requ details model -->


<button id=""spserviceReqdetailsbtn"" data-bs-toggle=""modal"" data-bs-target=""#detailsModelServiceRequest"" class=""d-none"">details</button>



	<div class=""modal"" tabindex=""-1"" id=""detailsModelServiceRequest"">
		<div class=""modal-dialog modal-dialog-centered"">
			<div class=""modal-content text-start"" style=""padding:2% !important"">
				<div class=""modal-header"">
					<h5 class=""modal-title"">Service Details</h5>
					<button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""
						aria-label=""Close""></button>
				</div>
				<div class=""modal-body float-start row"">
					<div class=""col"">
						<h4 id=""SpServiceReqDatetime"">05/10/2021 08:00 - 11:30</h4>
						<p>Duration: <span id=""SpServiceReqDuration""> 3 hrs </span> </p>
						<hr>
						<p>Service id: <span id=""SpServiceReqId""> 8852</span></p>
						<div class=""row"">
							<p class=""col-2 d-inline"">Extras: </p>
							<div cl");
            WriteLiteral(@"ass=""col-10 d-inline"" id=""SpServiceReqExtra""></div>
						</div>

						<p>Total Payment: <span id=""SpServiceReqAmount"" class=""price"">8750 &euro;</span> </p>
						<hr>
						<p>Customer Name:<span id=""SpServiceReqCustomerName"" > darshit</span></p>
						<p>Service Address: <span id=""SpServiceReqAddress"">adress ,sasdsad, surat 395006</span></p>

						<hr>

						<p>Comments <span id=""SpServiceReqComment""></span></p>



						<hr>




					

					<div id=""detailPopUpNew""><button id=""newServiceReqAccept"" type=""submit"">Accept</button></div>

					<div id=""detailPopUpUpComing""><button id=""newServiceReqCompleteBtn"" type=""submit"">Complete</button>
						<button id=""newServiceReqCancelBtn"" type=""submit"">Cancel</button>
						</div>
					</div>
					<div class=""col"" id=""newServiceReqMap"">
						


					</div>

				</div>
			</div>
		</div>
	</div>



");
            WriteLiteral(@"
 <button type=""button"" class=""btn btn-primary d-none"" id=""acceptAlert"" data-bs-toggle=""modal"" data-bs-target=""#alertPopup"">
  alert popup 
</button>

<div class=""modal fade"" id=""alertPopup"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered"" style=""max-width:500px"">
	<div class=""modal-content"">
	  <div class=""modal-header"">

		<button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
	  </div>
	  <div class=""modal-body"">

			  <h4 class=""modal-title"" id=""NewServiceAcceptStatus"">  </h4>
			  <h5 id=""Model_SID""></h5>
	 
		  
		  </div>
	  
	</div>
  </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<helperland1._0.ViewModel.SPDashboard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
