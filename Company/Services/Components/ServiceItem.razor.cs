using Microsoft.AspNetCore.Components;

namespace SorooshHamrah.Company.UI.Services.Components
{
	public partial class ServiceItem
	{
		[Parameter]
		public string Title { get; set; }
		[Parameter]
		public string Description { get; set; }
	}
}
