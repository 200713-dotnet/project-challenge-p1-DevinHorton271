#pragma checksum "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcfbe337877c25752f0b9271a22800fbbbe65ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
#line 1 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/_ViewImports.cshtml"
using Project_1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/_ViewImports.cshtml"
using Project_1.Client.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcfbe337877c25752f0b9271a22800fbbbe65ae0", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325e9b2c4b2f30d42b5bdd228af2b2eb31a3c2cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_1.Client.ViewModels.PizzaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 7 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
 using(Html.BeginForm("PlaceOrder", "Order", null, FormMethod.Post))
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                          ;
  foreach (var crust in Model.Crusts)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.RadioButtonFor(m => m.Crust, crust.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                                  ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.LabelFor(m => m.Crust, crust.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                            ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.Crust));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                            ;
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br>\n");
#nullable restore
#line 17 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                          ;
  foreach (var size in Model.Sizes)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.RadioButtonFor(m => m.Size, size.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                                ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.LabelFor(m => m.Size, size.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                          ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.Size));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                           ;
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br>\n");
#nullable restore
#line 25 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
   for(int i = 0;i<Model.Toppings.Count;i++)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.CheckBoxFor(m => m.Toppings2[i].IsSelected));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                                     ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.DisplayFor(m => m.Toppings[i].Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                             ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
Write(Html.HiddenFor(m => m.Toppings2[i].Text));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
                                             ;
    
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br>\n  <button type=\"submit\">place order</button>\n");
#nullable restore
#line 34 "/home/devin/revature_dotnet/week_4/P1/Project_1.Client/Views/Order/Order.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_1.Client.ViewModels.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
