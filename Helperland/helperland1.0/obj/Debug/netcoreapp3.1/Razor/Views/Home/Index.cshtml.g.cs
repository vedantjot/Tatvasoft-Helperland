#pragma checksum "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "663a6b959521cb9f7d9f7993666867f88981d278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663a6b959521cb9f7d9f7993666867f88981d278", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a4a27c12d2a1437d4ce6c3365aa98e328b69f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\tatvasoft\Tatvasoft-helperland\Helperland\Helperland1.0\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663a6b959521cb9f7d9f7993666867f88981d2784346", async() => {
                WriteLiteral(@"
  <!-- Required meta tags -->
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

  <!-- Bootstrap CSS -->
  <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
    integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">

  <!--Custome Css-->
 
  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "663a6b959521cb9f7d9f7993666867f88981d2785022", async() => {
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
                WriteLiteral("\r\n\r\n  <!--fonts-->\r\n\r\n\r\n\r\n  <title>Home page</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663a6b959521cb9f7d9f7993666867f88981d2786972", async() => {
                WriteLiteral(@"


  <!--header-->
  <div class=""container-fluid  header-container"">



    <nav class=""navbar navbar-expand-lg navbar-dark "">
      <div class=""container-fluid"">
        <a class=""home-navbar-brand navbar-brand"" href=""#"">
          <img src=""image\logo-large.png"" alt=""logo"">
        </a>
        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavAltMarkup""
          aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
          <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
          <div class=""navbar-nav home-navbar-nav ms-auto"">

            <a class=""nav-link home-nav-link nav-link-book-a-cleaner"" href=""#"">Book a Cleaner</a>
            <a class="" nav-link home-nav-link "" href=""Home/price""> Prices</a>
            <a class=""nav-link home-nav-link "">Our Guarantee</a>
            <a class=""nav-link home-nav-link "">Blog</a");
                WriteLiteral(@">
            <a class=""nav-link home-nav-link "">Contact us</a>
            <a class=""nav-link home-nav-link  nav-link-login"">Login</a>
            <a class=""nav-link home-nav-link  nav-link-become-a-helper"">Become a Helper</a>
            <a class=""nav-link home-nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button""
              data-bs-toggle=""dropdown"" aria-expanded=""false"">
              <img src=""image\ic-flag.png"">
            </a>
          </div>
        </div>
      </div>
    </nav>



    <div class=""row header-text-container"">
      <div class=""col  align-self-start"">
        <div>
          <p class=""header-title"">

            Lorem ipsum text
          </p>
        </div>

        <div class=""header-text"">
          <p> <img src=""image\ic-check.png""");
                BeginWriteAttribute("alt", " alt=\"", 2464, "\"", 2470, 0);
                EndWriteAttribute();
                WriteLiteral("> Lorem ipsum dolor sit amet, consectetur adipiscing</p>\r\n          <p> <img src=\"image\\ic-check.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2572, "\"", 2578, 0);
                EndWriteAttribute();
                WriteLiteral("> Lorem ipsum dolor sit amet, consectetur adipiscing</p>\r\n          <p> <img src=\"image\\ic-check.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2680, "\"", 2686, 0);
                EndWriteAttribute();
                WriteLiteral(@"> Lorem ipsum dolor sit amet, consectetur adipiscing</p>
        </div>


      </div>

    </div>

    <div class=""row"">
      <div class=""col text-center"">

        <button class=""header-book-button"">Let’s Book a Cleaner</button>
      </div>
    </div>


    <div class=""row header-process-container"">

      <div class=""col-md process-card"">

        <img src=""image/step-1.png"" class=""img-fluid"" alt=""..."">
        <br>
        <p class=""process-card-text"">Enter your postcode</p>

      </div>

      <div class=""col-md d-none d-lg-block process-card"">

        <img src=""image/step-arrow-1.png"" class=""img-fluid"" alt=""..."">
        <br>


      </div>

      <div class=""col-md process-card"">

        <img src=""image/step-2.png"" class=""img-fluid"" alt=""..."">
        <br>
        <p class=""process-card-text"">Select your plan</p>

      </div>

      <div class=""col-md d-none d-lg-block process-card"">

        <img src=""image/step-arrow-1-copy.png"" class=""img-fluid"" alt=");
                WriteLiteral(@"""..."">
        <br>


      </div>

      <div class=""col-md process-card"">

        <img src=""image/step-3.png"" class=""img-fluid"" alt=""..."">
        <br>
        <p class=""process-card-text"">Pay securely online</p>

      </div>

      <div class=""col-md d-none d-lg-block process-card"">

        <img src=""image/step-arrow-1.png"" class=""img-fluid"" alt=""..."">
        <br>


      </div>

      <div class=""col-md process-card"">

        <img src=""image/step-4.png"" class=""img-fluid"" alt=""..."">
        <br>
        <p class=""process-card-text"">Enjoy amazing service</p>

      </div>








    </div>

    <br>
    <br>

    <div class=""row"">
      <div class=""col text-center"">

        <img src=""image/down-custome-new.png"" class=""img-fluid down-arrow"" alt=""..."">


      </div>
    </div>


  </div>



  <!--Home ends-->

  <!--Why section-->

  <div class=""container-fluid"">

    <div class=""why-title"">
      <p>Why Helperland</p>
    </div>

    <");
                WriteLiteral(@"div class=""row why-row"">

      <div class=""col why-card"">
        <img src=""image/helper-img-1.png"" class=""img-fluid why-card-image"">
        <p class=""why-card-text-big"">
          Experience & Vetted Professionals
        </p>
        <p class=""why-card-text-small"">
          dominate the industry in scale and scope with an adaptable, extensive network that consistently delivers
          exceptional results.

        </p>

      </div>

      <div class=""col why-card"">
        <img src=""image/group-23.png"" class=""img-fluid why-card-image"">
        <p class=""why-card-text-big"">
          Secure Online Payment
        </p>


        <p class=""why-card-text-small"">

          Payment is processed securely online. Customers pay safely online and manage the booking.
        </p>

      </div>

      <div class=""col why-card"">
        <img src=""image/group-24.png"" class=""img-fluid why-card-image"">
        <p class=""why-card-text-big"">
          Dedicated Customer Service
       ");
                WriteLiteral(@" </p>
        <p class=""why-card-text-small"">
          to our customers and are guided in all we do by their needs. The team is always happy to support you and offer
          all the information.

        </p>

      </div>

    </div>




  </div>

  <!--why section ends-->

  <!--Blog section starts-->




  <div class=""container-fluid"">

    <div class=""row"">

      <div class=""col-md-1 d-none d-lg-block"">
        <img src=""image/blog-left-bg.png"" class=""img-fluid"">

      </div>

      <div class=""col-md-10"">

        <div class=""row photo-row"">
          <div class=""col-md-8"">
            <p class=""photo-text-big"">Lorem ipsum dolor sit amet,<br> consectetur

            </p>
            <p class=""photo-text-small"">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit.
              Donec nisi sapien, suscipit ut accumsan vitae, pulvinar ac libero.
              <br>
              Aliquam erat volutpat. Nullam quis ex odio. Nam bibendum cursus ");
                WriteLiteral(@"purus, vel efficitur urna finibus vitae.
              Nullam finibus aliquet pharetra. Morbi in sem dolor.
              Integer pretium hendrerit ante quis vehicula.
              <br>
              Mauris consequat ornare enim, sed lobortis quam ultrices sed.

            </p>

          </div>
          <div class=""col-md-4"">
            <img src=""image/group-36.png"" class=""img-fluid"">
          </div>

        </div>



        <div class=""blog-title"">
          <p>Our Blog</p>
        </div>

        <div class=""row blog-row"">
          <div class=""col blog-card"">
            <img src=""image/group-28.png"" class=""img-fluid blog-card-image"">
            <p class=""blog-card-title"">
              Lorem ipsum dolor sit amet
            </p>
            <p class=""blog-card-date"">
              January 28, 2019

            </p>
            <p class=""blog-card-content"">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.
");
                WriteLiteral(@"

            </p>
            <p class=""blog-card-link"">
              Read the Post

              <img src=""image/shape-2.png"" class=""img-fluid"">

            </p>


          </div>

          <div class=""col blog-card"">
            <img src=""image/group-29.png"" class=""img-fluid blog-card-image"">
            <p class=""blog-card-title"">
              Lorem ipsum dolor sit amet
            </p>
            <p class=""blog-card-date"">
              January 28, 2019

            </p>
            <p class=""blog-card-content"">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.


            </p>
            <p class=""blog-card-link"">
              Read the Post

              <img src=""image/shape-2.png"" class=""img-fluid"">

            </p>


          </div>

          <div class=""col blog-card"">
            <img src=""image/group-30.png"" class=""img-fluid blog-card-image"">
            <p class=""blog-card-title"">
   ");
                WriteLiteral(@"           Lorem ipsum dolor sit amet
            </p>
            <p class=""blog-card-date"">
              January 28, 2019

            </p>
            <p class=""blog-card-content"">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.


            </p>
            <p class=""blog-card-link"">
              Read the Post

              <img src=""image/shape-2.png"" class=""img-fluid"">

            </p>


          </div>
        </div>

      </div>

      <div class=""col-md-1 d-none d-lg-block"">

        <img src=""image/blog-right-bg.png"" class=""img-fluid"">

      </div>


    </div>

  </div>

  <!--Blog section ends-->



  <!--customer section starts-->

  <div class=""container-fluid customer-container"">
    <div class=""customer-title"">
      <p>What Our Customers Say</p>
    </div>

    <div class=""row customer-row"">
      <div class=""col customer-card"">
        <div class=""row"">
          <div class=""");
                WriteLiteral(@"col-sm-4"">
            <img src=""image/group-31.png"" class=""img-fluid customer-card-image"">

          </div>
          <div class=""col-sm-6"">
            <p class=""customer-card-name"">Lary Watson</p>
            <p class=""customer-card-city"">Manchester</p>


          </div>
          <div class=""col-sm-2"">
            <img src=""image/message.png"" class=""img-fluid customer-card-image"">

          </div>

        </div>


        <p class=""customer-card-content"">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum
          metus pulvinar aliquet consequat. Praesent nec malesuada nibh.
          <br>
          <br>
          Nullam et metus congue, auctor augue sit amet, consectetur tortor.


        </p>
        <p class=""customer-card-link"">
          Read the Post

          <img src=""image/shape-2.png"" class=""img-fluid"">

        </p>


      </div>

      <div class=""col customer-card"">
        <div class=""row"">
          <div class=""col");
                WriteLiteral(@"-sm-4"">
            <img src=""image/group-32.png"" class=""img-fluid customer-card-image"">

          </div>
          <div class=""col-sm-6"">
            <p class=""customer-card-name"">John Smith</p>
            <p class=""customer-card-city"">Manchester</p>


          </div>
          <div class=""col-sm-2"">
            <img src=""image/message.png"" class=""img-fluid customer-card-image"">

          </div>

        </div>


        <p class=""customer-card-content"">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum
          metus pulvinar aliquet consequat. Praesent nec malesuada nibh.
          <br><br>
          Nullam et metus congue, auctor augue sit amet, consectetur tortor.


        </p>
        <p class=""customer-card-link"">
          Read the Post

          <img src=""image/shape-2.png"" class=""img-fluid"">

        </p>


      </div>

      <div class=""col customer-card"">
        <div class=""row"">
          <div class=""col-sm-4"">
       ");
                WriteLiteral(@"     <img src=""image/group-33.png"" class=""img-fluid customer-card-image"">

          </div>
          <div class=""col-sm-6"">
            <p class=""customer-card-name"">Lars Johnson</p>
            <p class=""customer-card-city"">Manchester</p>


          </div>
          <div class=""col-sm-2"">
            <img src=""image/message.png"" class=""img-fluid customer-card-image"">

          </div>

        </div>


        <p class=""customer-card-content"">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum
          metus pulvinar aliquet consequat. Praesent nec malesuada nibh.
          <br><br>
          Nullam et metus congue, auctor augue sit amet, consectetur tortor.


        </p>
        <p class=""customer-card-link"">
          Read the Post

          <img src=""image/shape-2.png"" class=""img-fluid"">

        </p>


      </div>



    </div>

    <div class=""row contact-row"">

      <div class=""col-sm-2 contact-col-top"">
        <img src=""im");
                WriteLiteral(@"age/top-arrow.png"" class=""img-fluid contact-col-top-image"">


      </div>
      <div class=""col-sm-8 contact-col-email"">
        <p class=""contact-text"">
          GET OUR NEWSLETTER
        </p>

        <div class=""row "">
          <div class=""col-sm-7 contact-email-col"">
            <input class=""contact-email-textbox"" placeholder=""  YOUR EMAIL"">
          </div>
          <div class=""col-sm-5 contact-submit-col"">
            <button class=""contact-submit-button"">submit</button>

          </div>

        </div>



      </div>

      <div class=""col-sm-2 contact-col-faq contact-col-faq-image"">
        <img src=""image/layer-598.png"" class=""img-fluid"">

      </div>

    </div>



  </div>

  <!--customer section ends-->

  <!--footer-->

  <div class=""container-fluid footer-container"">
    <div class=""row"">
      <div class=""col-sm-3 footer-logo-col"">
        <img src=""image/footer-logo.png"" class=""img-fluid footer-logo-image"">


      </div>
      <div class=");
                WriteLiteral(@"""col-sm-6 footer-nav-col"">

        <a class=""footer-nav-link "">HOME</a>
        <a class=""footer-nav-link "">ABOUT</a>
        <a class=""footer-nav-link "">TESTIMONIALS</a>
        <a class=""footer-nav-link "">FAQ</a>
        <a class=""footer-nav-link "">INSURANCE</a>
        <a class=""footer-nav-link "">IMPRESSUM</a>




      </div>
      <div class=""col-sm-3 footer-social-col"">

        <img src=""image/ic-facebook.png"" class=""img-fluid footer-social-image"">
        <img src=""image/ic-instagram.png"" class=""img-fluid footer-social-image"">





      </div>
    </div>
  </div>



  <!--footer ends-->


  <!--Privacy start-->

  <div class=""row privacy-row"">
    <div class=""col-sm-9 privacy-text-col"">
      <p class=""privacy-text"">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut feugiat nunc libero, ac malesuada ligula aliquam ac.
        <a>Privacy Policy</a>

      </p>

    </div>
    <div class=""col-sm-3 privacy-button-col"">
      <button class=""pr");
                WriteLiteral(@"ivacy-button"">
        OK!
      </button>

    </div>
  </div>
  <!--privacy ends-->



  <!-- Optional JavaScript; choose one of the two! -->

  <!-- Option 1: Bootstrap Bundle with Popper -->
  <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
    integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p""
    crossorigin=""anonymous""></script>


");
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
            WriteLiteral("\r\n\r\n</html>");
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