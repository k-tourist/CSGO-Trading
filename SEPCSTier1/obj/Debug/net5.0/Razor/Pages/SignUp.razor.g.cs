#pragma checksum "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac4c4a91e5e0032d7b53d9455501050bcbab4c7"
// <auto-generated/>
#pragma warning disable 1591
namespace SEPCSTier1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using SEPCSTier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using SEPCSTier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
using Microsoft.AspNetCore.SignalR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
using SEPCSTier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
using SEPCSTier1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-6solt7yd44>SignUp</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container rounded bg-white mt-5 mb-5");
            __builder.AddAttribute(3, "b-6solt7yd44");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddAttribute(6, "b-6solt7yd44");
            __builder.AddMarkupContent(7, @"<div class=""col-md-3 border-right"" b-6solt7yd44><div class=""d-flex flex-column align-items-center text-center p-3 py-5"" b-6solt7yd44><img class=""rounded-circle mt-5"" width=""150px"" src=""https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg"" b-6solt7yd44><span class=""font-weight-bold"" b-6solt7yd44>Welcome</span><span class=""text-black-50"" b-6solt7yd44>To CSGO Trading</span><span b-6solt7yd44></span></div></div>
        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-5 border-right");
            __builder.AddAttribute(10, "b-6solt7yd44");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "p-3 py-5");
            __builder.AddAttribute(13, "b-6solt7yd44");
            __builder.AddMarkupContent(14, "<div class=\"d-flex justify-content-between align-items-center mb-3\" b-6solt7yd44><h4 class=\"text-right\" b-6solt7yd44>Profile Settings</h4></div>\r\n                \r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row mt-2");
            __builder.AddAttribute(17, "b-6solt7yd44");
            __builder.AddMarkupContent(18, "<h3 b-6solt7yd44>Create UserAccount</h3>\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-12");
            __builder.AddAttribute(21, "b-6solt7yd44");
            __builder.AddMarkupContent(22, "<label class=\"labels\" b-6solt7yd44>Username</label>");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "placeholder", "Username");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                                                                                              newUserAccount.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserAccount.username = __value, newUserAccount.username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(29, "b-6solt7yd44");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-12");
            __builder.AddAttribute(33, "b-6solt7yd44");
            __builder.AddMarkupContent(34, "<label class=\"labels\" b-6solt7yd44>Password</label>");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "password");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "placeholder", "Password");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                                                                                                  newUserAccount.password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserAccount.password = __value, newUserAccount.password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(41, "b-6solt7yd44");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                   \r\n                    <div class=\"row mt-3\" b-6solt7yd44></div>\r\n                    \r\n                   \r\n               \r\n                \r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "container-md");
            __builder.AddAttribute(45, "b-6solt7yd44");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.AddAttribute(48, "b-6solt7yd44");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col");
            __builder.AddAttribute(51, "b-6solt7yd44");
            __builder.AddMarkupContent(52, "<h1 b-6solt7yd44> Payment Information</h1>\r\n                                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group");
            __builder.AddAttribute(55, "b-6solt7yd44");
            __builder.AddMarkupContent(56, "<label for=\"inputAddress\" b-6solt7yd44>Name</label>\r\n                                    ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "id", "Name");
            __builder.AddAttribute(60, "placeholder", "Name");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                                                    newPaymentAccount.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPaymentAccount.name = __value, newPaymentAccount.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(63, "b-6solt7yd44");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                \r\n                                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group");
            __builder.AddAttribute(67, "b-6solt7yd44");
            __builder.AddMarkupContent(68, "<label for=\"inputAddress\" b-6solt7yd44>CardNumber</label>\r\n                                    ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "id", "CardNumber");
            __builder.AddAttribute(72, "placeholder", "**** **** **** ****");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                                                                         newPaymentAccount.cardnumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPaymentAccount.cardnumber = __value, newPaymentAccount.cardnumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(75, "b-6solt7yd44");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                \r\n                                \r\n                                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row");
            __builder.AddAttribute(79, "b-6solt7yd44");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col");
            __builder.AddAttribute(82, "b-6solt7yd44");
            __builder.AddMarkupContent(83, "<label for=\"inputAddress\" b-6solt7yd44>Expiration Date</label>\r\n                                            ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "placeholder", "**/**");
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                                                   newPaymentAccount.expirationdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPaymentAccount.expirationdate = __value, newPaymentAccount.expirationdate));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(89, "b-6solt7yd44");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col");
            __builder.AddAttribute(93, "b-6solt7yd44");
            __builder.AddMarkupContent(94, "<label for=\"inputAddress\" b-6solt7yd44>Security Code</label>\r\n                                            ");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "class", "form-control");
            __builder.AddAttribute(97, "placeholder", "***");
            __builder.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                                                 newPaymentAccount.securitycode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPaymentAccount.securitycode = __value, newPaymentAccount.securitycode));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(100, "b-6solt7yd44");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                                    ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "type", "submit");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                      () => { AddUserAccount(); AddnewPaymentAccount();  }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "class", "btn btn-primary");
            __builder.AddAttribute(106, "b-6solt7yd44");
            __builder.AddMarkupContent(107, "Create Account & Payment");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                       \r\n                \r\n                         ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "style", "color:red");
            __builder.AddAttribute(111, "b-6solt7yd44");
            __builder.AddContent(112, 
#nullable restore
#line 78 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                 errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
       

    public User newUserAccount = new User();
    private Payment newPaymentAccount = new Payment();
    private string errorMessage;

    protected async override Task OnInitializedAsync()
    {
        errorMessage = "";
       
    }


    public bool validateUsername()
    {
        if (newUserAccount.username == null)
        {
            errorMessage = "username can not be empty";
            return false;
        }

        if (newUserAccount.username.Length< 4)
        {
            errorMessage = "Username must contain more than 3 characters";
            return false;
        }

        if (newUserAccount.username.Length > 14)
        {
            errorMessage = "Username must contain less than 15 characters";
            return false;
        }
        else
        {
            return true;
        }
    }


    public bool validatePassword()
    {
        if (newUserAccount.password == null)
        {
            errorMessage = "Password cannot be empty";
            return false;
        }
        if (newUserAccount.password.Length < 8)
        {
            errorMessage = "Password length must be 8 or more";
            return false;
        }

        if (newUserAccount.password.Length > 14)
        {
            errorMessage = "password lenght must be 14 or less";
            return false;
        }
        else
        {
            return true;
        }
    }


    public bool validatePayment()
    {
        if (newPaymentAccount.name == null )
        {
            errorMessage = "CardholderName cannot be empty";
            return false;
        }
        
        if (newPaymentAccount.name.Length < 4 )
        {
            errorMessage = "CardholderName cannot be less than 4";
            return false;
        }
        
        if (newPaymentAccount.name.Length > 12 )
        {
            errorMessage = "CardholderName cannot be more than 12";
            return false;
        }


        if (newPaymentAccount.cardnumber == null ) {
            errorMessage = "CardNumber cannot be empty";
            return false;
        }

        if (newPaymentAccount.cardnumber.Length < 16 ) {
            errorMessage = "CardNumber must contain 16 characters";
            return false;
        }


        if (newPaymentAccount.cardnumber.Length > 16  ) {
            errorMessage = "CardNumber must contain 16 characters";
            return false;
        }

        if (string.IsNullOrEmpty(newPaymentAccount.expirationdate)) {
            errorMessage = "ExpirationDate cannot be empty";
            return false;
        }


        if (newPaymentAccount.securitycode == null) {
            errorMessage = "CVV must contain more than 0 characters";
            return false;
        }


        if (newPaymentAccount.securitycode.Length > 3 || newPaymentAccount.securitycode.Length < 3 ){
            errorMessage = "CVV must contain  3 characters";
            return false;
        }

        else {

            return true;

        }

      
    }


    public bool validateSignUp()
    {

        if (validateUsername() && validatePassword() && validatePayment())
        {
            errorMessage = "successfully";
            return true;
        }
        else
        {
           
            return false;
        }
        
        
    }

    private async void AddUserAccount()
    {
        if (validateSignUp())
        {
               UserData.AddUser(newUserAccount);
        }
      
        
    }

   
    
    
    
    
    
    private async void AddnewPaymentAccount()
    {
        if (validateSignUp())
        {
            Payment payment = await PaymentData.AddPayment(new Payment(newPaymentAccount.name, newPaymentAccount.cardnumber, newPaymentAccount.expirationdate, newPaymentAccount.securitycode));
            NavigationManager.NavigateTo("/login");
        }
          
           
        
      
      
        
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPaymentData PaymentData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData UserData { get; set; }
    }
}
#pragma warning restore 1591
