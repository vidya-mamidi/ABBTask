#pragma checksum "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d08da3a608a4b668efc5c7ddc35f3a3a20112e"
// <auto-generated/>
#pragma warning disable 1591
namespace ABBTask.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using ABBTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\_Imports.razor"
using ABBTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
using ABBTask.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
using ABBTask.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Album")]
    public partial class Albums : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Album Data</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width:1000px");
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
     if (albums == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<thead>\r\n                <tr>\r\n                    <th>UserId</th>\r\n                    <th>Id</th>\r\n                    <th>Title</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 26 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
                 foreach (var user in albums)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 29 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
                             user.userId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 30 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
                             user.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 31 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
                             user.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                       \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 34 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 37 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Vidya\source\repos\ABBTask\ABBTask\Pages\Albums.razor"
      


    public List<Album> albums { get; set; }

    [Inject]
    public IAlbumServices AlbumServices { get; set; }

    protected override async Task OnInitializedAsync()
    {
        albums = (await AlbumServices.GetAlbums()).ToList();

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
