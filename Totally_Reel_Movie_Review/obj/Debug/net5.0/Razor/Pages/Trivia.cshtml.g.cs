#pragma checksum "/Users/assyasellak/Desktop/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/Trivia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e8f2b37764f0786a3987c3735137748854b09e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Totally_Reel_Movie_Review.Pages.Pages_Trivia), @"mvc.1.0.razor-page", @"/Pages/Trivia.cshtml")]
namespace Totally_Reel_Movie_Review.Pages
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
#line 1 "/Users/assyasellak/Desktop/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/assyasellak/Desktop/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/_ViewImports.cshtml"
using Totally_Reel_Movie_Review;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/assyasellak/Desktop/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/_ViewImports.cshtml"
using Totally_Reel_Movie_Review.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/assyasellak/Desktop/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/_ViewImports.cshtml"
using Totally_Reel_Movie_Review.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e8f2b37764f0786a3987c3735137748854b09e2", @"/Pages/Trivia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa73c9a337c440fe693c7090941a4c60bbdf328", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Trivia : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/assyasellak/Desktop/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/Trivia.cshtml"
  
    ViewData["Title"] = "Trivia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Trivia</h1>\n    <p>Nerd</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
