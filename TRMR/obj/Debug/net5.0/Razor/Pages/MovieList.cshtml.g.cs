#pragma checksum "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4f01801bde375f606742004b81ad4ab5aece2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TRMR.Pages.Pages_MovieList), @"mvc.1.0.razor-page", @"/Pages/MovieList.cshtml")]
namespace TRMR.Pages
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
#line 1 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\_ViewImports.cshtml"
using TRMR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\_ViewImports.cshtml"
using TRMR.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\_ViewImports.cshtml"
using TRMR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4f01801bde375f606742004b81ad4ab5aece2a", @"/Pages/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d955fd7e8ecdc9278170b6dcb71143be6eee19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MovieList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
  
   ViewData["Title"] = "MovieList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav class=""nav2""> 

   <ul class=""list-unstyled components"">
      <li><a href=""#Suspense"">Suspense </a></li>
      <li><a href=""#RomCom"">RomCom</a></li>
      <li><a href=""#Horror"">Horror</a></li>
      <li><a href=""#Action"">Action</a></li>
      <li><a href=""#SciFi"">SciFi</a></li>
      <li><a href=""#Drama""> Drama </a></li>
      <li><a href=""#Romance""> Romance </a></li>
      <li><a href=""#Thriller""> Thriller </a></li>
      <li><a href=""#Documentary""> Documentary </a></li>
      <li><a href=""#Adventure"">Adventure</a></li>
      <li><a href=""#Musical""> Musical</a></li>
      <li><a href=""#Mystery""> Mystery </a></li>
      <li><a href=""#Comedy"">Comedy</a></li>
      <li><a href=""#Sport""> Sport</a></li>
      <li><a href=""#ShortFilm""> Short Film </a></li>
   </ul>

</nav>

<div id=""MovieList"">
   <main role=""main"" class=""pb-3"">
      <div class=""row content"">
         <div class=""col"">
            <div id=""MovieIndex"">
               <h2>List of all TRMR Movies by Genre</h2>

");
            WriteLiteral("               <hr>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                foreach (string genre in Model.Genres)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div");
            BeginWriteAttribute("id", " id=\"", 1217, "\"", 1228, 1);
#nullable restore
#line 40 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
WriteAttributeValue("", 1222, genre, 1222, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><br></div>\r\n                  <div class=\"item\">\r\n                     <h3>");
#nullable restore
#line 42 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                    Write(genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                     <ul class=\"MovieList\">\r\n");
#nullable restore
#line 44 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                          int genreMovCount = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                         foreach (var movie in Model.Movies)
                        {
                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                            if(movie.Genre == genre){

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <li><a");
            BeginWriteAttribute("href", " href = \"", 1594, "\"", 1629, 2);
            WriteAttributeValue("", 1603, "MovieTemplate?id=", 1603, 17, true);
#nullable restore
#line 48 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
WriteAttributeValue("", 1620, movie.Id, 1620, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                                                                    Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                              genreMovCount++;
                           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                            
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                         if(genreMovCount == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <li style=\"color:blue;\"><i>TRMR does not currently have any ");
#nullable restore
#line 53 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                                                                                  Write(genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" movies up for review</i></li>\r\n");
#nullable restore
#line 54 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                     </ul>\r\n                  </div>\r\n");
#nullable restore
#line 57 "C:\Users\gamer\Desktop\Fall_2020\InternetProg\FINAL\Totally-Reel-Movie-Review\TRMR\Pages\MovieList.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n         </div>\r\n      </div>\r\n   </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovieListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovieListModel>)PageContext?.ViewData;
        public MovieListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
