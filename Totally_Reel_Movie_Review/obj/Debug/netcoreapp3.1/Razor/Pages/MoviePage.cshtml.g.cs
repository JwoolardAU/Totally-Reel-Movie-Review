#pragma checksum "/Users/assyasellak/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/MoviePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cdf5f46fc2a5d93102ef13edcea6ad93bf8d345"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Totally_Reel_Movie_Review.Pages.Pages_MoviePage), @"mvc.1.0.razor-page", @"/Pages/MoviePage.cshtml")]
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
#line 1 "/Users/assyasellak/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/_ViewImports.cshtml"
using Totally_Reel_Movie_Review;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdf5f46fc2a5d93102ef13edcea6ad93bf8d345", @"/Pages/Movie Title.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d887497da2c273a3becaa93988ceea929a9cb784", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MoviePage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/assyasellak/Totally-Reel-Movie-Review/Totally_Reel_Movie_Review/Pages/Movie Title.cshtml"
  
    ViewData["Title"] = "Movie Title";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Movie Title</h1>
    <p>Maybe include some tags that are unique/specific to this movie</p>
    <p>Here is a quick overview of this movie</p>
</div>

    <h2>Movie Details</h2>
    <h3>Synopsis</h3>
    <p>You are now reading the synopsis of this movie. Movie go boom. wow. much intrigue. the end.</p>
    <h3>Director</h3>
    <p>some dude accused of doing some weird stuff</p>
    <h3>Cast</h3>
    <ul style=""list-style-image: url('../wwwroot/icons8-film-reel-16.png');"">
        <li>Hot guy #1</li>
        <li>Hot gut #2</li>
        <li>Really hot guy #2</li>
        <li>links to actor pages ???</li>
    </ul>
    <h2>Reviews/Comments</h2>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
