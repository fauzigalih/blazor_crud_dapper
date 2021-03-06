#pragma checksum "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\Pages\VideoAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5e088f24cf2a2e033fa942fe710c7700479c704"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDapperCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using BlazorDapperCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\_Imports.razor"
using BlazorDapperCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\Pages\VideoAdd.razor"
using BlazorDapperCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videoadd")]
    public partial class VideoAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "E:\All Program Project\ASP NET Core\BlazorDapperCRUD\Pages\VideoAdd.razor"
       
    //Create empty video object
    Video video = new Video();

    //Execute on page load
    protected override void OnInitialized()
    {
        DateTime defaultDate = new DateTime(2020, 01, 01);
        video.datePublished = defaultDate;
        video.isActive = true;
    }

    protected async Task VideoInsert()
    {
        await VideoService.VideoInsert(video);
        NavigationManager.NavigateTo("/videolist");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/videolist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVideoService VideoService { get; set; }
    }
}
#pragma warning restore 1591
