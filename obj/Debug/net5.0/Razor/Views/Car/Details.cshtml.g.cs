#pragma checksum "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\Car\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43c7c7ded4091ae20c4f9923d517a9facbabcab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Details), @"mvc.1.0.view", @"/Views/Car/Details.cshtml")]
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
#line 1 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\_ViewImports.cshtml"
using CarGallery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\_ViewImports.cshtml"
using CarGallery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43c7c7ded4091ae20c4f9923d517a9facbabcab0", @"/Views/Car/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e96e3194b5c9d654cc39bdec523dff4beab591d", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>");
#nullable restore
#line 3 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\Car\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<div class=\"thumbnail\">\n    <img");
            BeginWriteAttribute("alt", " alt=\"", 66, "\"", 83, 1);
#nullable restore
#line 6 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\Car\Details.cshtml"
WriteAttributeValue("", 72, Model.Name, 72, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 84, "\"", 105, 1);
#nullable restore
#line 6 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\Car\Details.cshtml"
WriteAttributeValue("", 90, Model.ImageUrl, 90, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"400px\">\n    <div class=\"caption-full\">\n        <h3>\n            ");
#nullable restore
#line 9 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\Car\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h3>\n        <h4>");
#nullable restore
#line 11 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\Car\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>");
#nullable restore
#line 12 "C:\Users\lucas.garaujo\Desktop\cargallery-main\cargallery-main\Views\Car\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
