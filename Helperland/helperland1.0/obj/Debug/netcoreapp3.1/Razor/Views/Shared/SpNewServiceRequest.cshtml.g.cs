#pragma checksum "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540682ce8ba92df90b4c6d3e87cd52d806e60089"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540682ce8ba92df90b4c6d3e87cd52d806e60089", @"/Views/Shared/SpNewServiceRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a4a27c12d2a1437d4ce6c3365aa98e328b69f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SpNewServiceRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<helperland1._0.ViewModel.SPDashboard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div id=\"NewServiceRequest\" class=\"tab-contant\">\r\n\r\n    <div class=\"clearfix\">\r\n");
            WriteLiteral(@"        <input type=""checkbox"" id=""newRequestPet"" style=""margin-left:2%; transform: scale(1.5); "" checked=""checked"">
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
            WriteLiteral("                        <tr class=\"text-center\" data-value=");
#nullable restore
#line 39 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                      Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\r\n                            <td data-label=\"Service ID\">");
#nullable restore
#line 41 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                   Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td data-label=\"Service Date\">\r\n\r\n                                <div>\r\n                                    <span><img src=\"/image/calendar2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1728, "\"", 1734, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    <span class=\"upcoming-date\"><b>");
#nullable restore
#line 46 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                                              Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                                </div>\r\n                                <div>\r\n                                    <span><img src=\"/image/layer-14.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1986, "\"", 1992, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    <span>");
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
            WriteLiteral("</span>\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"text-start\" data-lable=\"Customer Details\">\r\n                                <div class=\"ms-4\">");
#nullable restore
#line 54 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                             Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"d-flex\"><span><img class=\"me-0\" src=\"/image/layer-15.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2420, "\"", 2426, 0);
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
            WriteLiteral(" </span></div>\r\n                            </td>\r\n\r\n                            <td data-lable=\"Payment\" class=\"price\">\r\n                                <span>");
#nullable restore
#line 59 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                 Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &euro;\r\n                            </td>\r\n                            <td data-lable=\"Time Conflict\">\r\n");
#nullable restore
#line 62 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
                                  
                                    string conflictIdtemp = "Conflict" + @item.ServiceRequestId;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"newReqConflictBtn d-none\"");
            BeginWriteAttribute("id", " id=", 3020, "", 3039, 1);
#nullable restore
#line 65 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Shared\SpNewServiceRequest.cshtml"
WriteAttributeValue("", 3024, conflictIdtemp, 3024, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Conflict</a>\r\n                            </td>\r\n                            <td data-lable=\"Actions\">\r\n                                <a class=\"newReqAcceptBtn\">Accept</a>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
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
                <div class=""col-md-6  col-sm-12"">
                    <h4 id=""SpServiceReqDatetime"">05/10/2021 08:00 - 11:30</h4>
                    <p>Duration: <span id=""SpServiceReqDura");
            WriteLiteral(@"tion""> 3 hrs </span> </p>
                    <hr>
                    <p>Service id: <span id=""SpServiceReqId""> 8852</span></p>
                    <div class=""row"">
                        <p class=""col-2 d-inline"">Extras: </p>
                        <div class=""col-10 d-inline"" id=""SpServiceReqExtra""></div>
                    </div>

                    <p>Total Payment: <span id=""SpServiceReqAmount"" class=""price"">8750 &euro;</span> </p>
                    <hr>
                    <p>Customer Name:<span id=""SpServiceReqCustomerName""> darshit</span></p>
                    <p>Service Address: <span id=""SpServiceReqAddress"">adress ,sasdsad, surat 395006</span></p>

                    <hr>

                    <p>Comments <span id=""SpServiceReqComment""></span></p>



                    <hr>


                    <div id=""detailPopUpNew""><button id=""newServiceReqAccept"" type=""submit"">Accept</button></div>

                    <div id=""detailPopUpUpComing"">
                        ");
            WriteLiteral(@"<button id=""newServiceReqCompleteBtn"" type=""submit"">Complete</button>
                        <button id=""newServiceReqCancelBtn"" data-bs-toggle=""modal"" data-bs-target=""#SPdeleteModelServiceRequest"" type=""submit"">Cancel</button>
                    </div>

                


                </div>
                <div class=""col-md-6 col-sm-12"" id=""newServiceReqMap"">
                </div>

            </div>
        </div>
    </div>
</div>



  ");
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
