#pragma checksum "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\Shared\CandidateComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24670d90ffed227ebfd9d40b58e0a0c44c71dfe1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Orcasound.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    public partial class CandidateComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "D:\Repo\OrcaSound\ModeratorFrontEnd\Orcasound\Orcasound.UI\Shared\CandidateComponent.razor"
       
	private string[] resultList = new string[] { "Yes", "No", "Don't Know" };
	private string background = "orca-data-strip-normal";

	[Parameter]
	public EventCallback<Candidate> OnSubmitClick { get; set; }

	[Parameter]
	public Candidate Candidate { get; set; }

	private void SetFoundValue(Candidate candidate, string found)
	{
		candidate.Found = found;
	}

	private void OnFocus()
	{
		background = "orca-data-strip-focused";
	}

	private async Task OnBlur()
	{
		await JSRuntime.InvokeVoidAsync("StopPlaying", Candidate.PlayerId);
		background = "orca-data-strip-normal";

	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
