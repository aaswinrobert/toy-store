#pragma checksum "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5262728a8387ec9603df1f812fab13f01f11bd3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Checkout), @"mvc.1.0.view", @"/Views/Orders/Checkout.cshtml")]
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
#line 1 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
using MVC.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5262728a8387ec9603df1f812fab13f01f11bd3a", @"/Views/Orders/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("submit check_out"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("payment.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("creditly-card-form agileinfo_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
  
    ViewData["Title"] = "Shopping Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

 <div class=""inner_page-banner one-img"">
      </div>
      <!--//banner -->
      <!-- short -->
      <div class=""using-border py-3"">
         <div class=""inner_breadcrumb  ml-4"">
            <ul class=""short_ls"">
               <li>
                  <a >");
#nullable restore
#line 20 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                 Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                  <span>/ /</span>
               </li>
               <li>CheckOut Page</li>
            </ul>
         </div>
      </div>



<section class=""checkout py-lg-4 py-md-3 py-sm-3 py-3"">
            <div class=""container py-lg-5 py-md-4 py-sm-4 py-3"">
               <div class=""shop_inner_inf"">
                  <div class=""privacy about"">
                     <div class=""checkout-left"">
                        <div class=""col-md-4 checkout-left-basket"">
                           <h4>Continue to basket</h4>

                            

                           <ul>
");
#nullable restore
#line 41 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                         foreach (var item in Model.ShoppingCart.ShoppingCartItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <li>");
#nullable restore
#line 43 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                             Write(item.Toys.ToyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i></i> <span>");
#nullable restore
#line 43 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                                                               Write(item.Toys.ToyPrice*item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></li>\r\n");
#nullable restore
#line 44 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                        }     

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                         if( Model.ShoppingCartTotal >1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>Total Service Charges <i>-</i> <span>55.00</span></li>\r\n                              <li>Total <i>-</i> <span> ");
#nullable restore
#line 48 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                                                    Write(Model.ShoppingCartTotal+55);

#line default
#line hidden
#nullable disable
            WriteLiteral("    </span></li>\r\n");
#nullable restore
#line 49 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>Total Service Charges <i>-</i> <span>0.00</span></li>\r\n                              <li>Total <i>-</i> <span>  ₹ 00.00    </span></li>\r\n");
#nullable restore
#line 53 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Orders\Checkout.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                              \r\n                           </ul>\r\n\r\n\r\n                        \r\n                        </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                        <div class=\"col-md-8 address_form\">\r\n                           \r\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5262728a8387ec9603df1f812fab13f01f11bd3a10673", async() => {
                WriteLiteral(@"
                              <section class=""creditly-wrapper wrapper"">
                                 <div class=""information-wrapper"">
                                    <div class=""first-row form-group"">
                                       <div class=""controls"">
                                         
                                          <input class=""billing-address-name form-control"" type=""text"" name=""name"" placeholder=""Full name"" required>
                                       </div>
                                       <div class=""card_number_grids"">
                                          <div class=""card_number_grid_left"">
                                             <div class=""controls"">
                                                
                                                <input class=""form-control"" type=""text"" placeholder=""Mobile number"" required>
                                             </div>
                                          </div>
     ");
                WriteLiteral(@"                                     <div class=""card_number_grid_right"">
                                             <div class=""controls"">
                                               
                                                <input class=""form-control"" type=""text"" placeholder=""Landmark"" required>
                                             </div>
                                          </div>
                                          <div class=""clear""> </div>
                                       </div>
                                       <div class=""controls"">
                                         
                                          <input class=""form-control"" type=""text"" placeholder=""Town/City"" required>
                                       </div>
                                       <div class=""controls"">
                                          
                                          <select class=""form-control option-w3ls"" required>
                  ");
                WriteLiteral("                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5262728a8387ec9603df1f812fab13f01f11bd3a13127", async() => {
                    WriteLiteral("Office");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5262728a8387ec9603df1f812fab13f01f11bd3a14187", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5262728a8387ec9603df1f812fab13f01f11bd3a15245", async() => {
                    WriteLiteral("Commercial");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                          </select>\r\n                                       </div>\r\n                                    </div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5262728a8387ec9603df1f812fab13f01f11bd3a16450", async() => {
                    WriteLiteral("Delivery to this Address");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                 </div>\r\n                              </section>\r\n                           ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                           <div class=\"checkout-right-basket\" style=\"position:center\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5262728a8387ec9603df1f812fab13f01f11bd3a19591", async() => {
                WriteLiteral("Back To Cart ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
                        <div class=""clearfix""> </div>
                        <div class=""clearfix""></div>
                     </div>
                  </div>
               </div>
               <!-- //top products -->
            </div>
      </section>







");
            WriteLiteral(@"

<!--js working-->
      <script src='js/jquery-2.2.3.min.js'></script>
      <!--//js working-->
      <!-- cart-js -->	
      <script src=""js/minicart.js""></script>
      <script>
         toys.render();
         
         toys.cart.on('toys_checkout', function (evt) {
         	var items, len, i;
         
         	if (this.subtotal() > 0) {
         		items = this.items();
         
         		for (i = 0, len = items.length; i < len; i++) {}
         	}
         });
      </script>
      <!--// cart-js -->
      <!--quantity-->
      <script>
         $('.value-plus').on('click', function () {
         	var divUpd = $(this).parent().find('.value'),
         		newVal = parseInt(divUpd.text(), 10) + 1;
         	divUpd.text(newVal);
         });
         
         $('.value-minus').on('click', function () {
         	var divUpd = $(this).parent().find('.value'),
         		newVal = parseInt(divUpd.text(), 10) - 1;
         	if (newVal >= 1) divUpd.text(newVal);
         })");
            WriteLiteral(@";
      </script>
      <!--quantity-->
      <!--closed-->
      <script>
         $(document).ready(function (c) {
         	$('.close1').on('click', function (c) {
         		$('.rem1').fadeOut('slow', function (c) {
         			$('.rem1').remove();
         		});
         	});
         });
      </script>
      <script>
         $(document).ready(function (c) {
         	$('.close2').on('click', function (c) {
         		$('.rem2').fadeOut('slow', function (c) {
         			$('.rem2').remove();
         		});
         	});
         });
      </script>
      <script>
         $(document).ready(function (c) {
         	$('.close3').on('click', function (c) {
         		$('.rem3').fadeOut('slow', function (c) {
         			$('.rem3').remove();
         		});
         	});
         });
      </script>
      <!--//closed-->
      <!-- start-smoth-scrolling -->
      <script src=""js/move-top.js""></script>
      <script src=""js/easing.js""></script>
      <script>
         jQue");
            WriteLiteral(@"ry(document).ready(function ($) {
         	$("".scroll"").click(function (event) {
         		event.preventDefault();
         		$('html,body').animate({
         			scrollTop: $(this.hash).offset().top
         		}, 900);
         	});
         });
      </script>
      <!-- start-smoth-scrolling -->
      <!-- here stars scrolling icon -->
      <script>
         $(document).ready(function () {
         
         	var defaults = {
         		containerID: 'toTop', // fading element id
         		containerHoverID: 'toTopHover', // fading element hover id
         		scrollSpeed: 1200,
         		easingType: 'linear'
         	};
         	$().UItoTop({
         		easingType: 'easeOutQuart'
         	});
         
         });
      </script>
      <!-- //here ends scrolling icon -->
      <!--bootstrap working-->
      <script src=""js/bootstrap.min.js""></script>
      <!-- //bootstrap working-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591