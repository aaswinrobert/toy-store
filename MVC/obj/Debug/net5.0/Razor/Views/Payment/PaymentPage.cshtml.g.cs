#pragma checksum "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d86f2bb8c74bdd324c08d89bd9031a5cd28fab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_PaymentPage), @"mvc.1.0.view", @"/Views/Payment/PaymentPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d86f2bb8c74bdd324c08d89bd9031a5cd28fab", @"/Views/Payment/PaymentPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_PaymentPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Controllers.PaymentController.OrderModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- // Click this button automatically when this page load using javascript -->
<!-- You can hide this button -->
<button id=""rzp-button1"" hidden>Pay</button>
<script src=""https://checkout.razorpay.com/v1/checkout.js""></script>
<script>
var options = {
    ""key"": """);
#nullable restore
#line 13 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
       Write(Html.DisplayFor(model => model.razorpayKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", // Enter the Key ID generated from the Dashboard\r\n    \"amount\": \"");
#nullable restore
#line 14 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
          Write(Html.DisplayFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", // Amount is in currency subunits. Default currency is INR. Hence, 50000 refers to 50000 paise\r\n    \"currency\": \"");
#nullable restore
#line 15 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
            Write(Html.DisplayFor(model => model.currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n    \"name\": \"");
#nullable restore
#line 16 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
        Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n    \"description\": \"");
#nullable restore
#line 17 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
               Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n    \"image\": \"https://example.com/your_logo\", // You can give your logo url\r\n    \"order_id\": \"");
#nullable restore
#line 19 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
            Write(Html.DisplayFor(model => model.orderId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
    ""handler"": function (response){
        // After payment successfully made response will come here
        // Set the data in hidden form
        document.getElementById('rzp_paymentid').value = response.razorpay_payment_id;
        document.getElementById('rzp_orderid').value = response.razorpay_order_id;

        // // Let's submit the form automatically
        document.getElementById('rzp-paymentresponse').click();
    },
    ""prefill"": {
        ""name"": """);
#nullable restore
#line 30 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
            Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"email\": \"");
#nullable restore
#line 31 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
             Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"contact\": \"");
#nullable restore
#line 32 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
               Write(Html.DisplayFor(model => model.contactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n    },\r\n    \"notes\": {\r\n        \"address\": \"");
#nullable restore
#line 35 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
               Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
    },
    ""theme"": {
        ""color"": ""#F37254""
    }
};
var rzp1 = new Razorpay(options);

//<!-- onload function -->
window.onload = function(){
    document.getElementById('rzp-button1').click();
};

document.getElementById('rzp-button1').onclick = function(e){
    rzp1.open();
    e.preventDefault();
}
</script>

<!-- This form is hidden, and submit when payment successfully made -->
");
#nullable restore
#line 55 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
 using (Html.BeginForm("Complete", "Payment"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
Write(Html.Hidden("rzp_paymentid"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
Write(Html.Hidden("rzp_orderid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" id=\"rzp-paymentresponse\" class=\"btn btn-primary\" hidden>Submit</button>\r\n");
#nullable restore
#line 62 "E:\CompleteProject ToyShop Code B-G1\Project\MVC\Views\Payment\PaymentPage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Controllers.PaymentController.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591