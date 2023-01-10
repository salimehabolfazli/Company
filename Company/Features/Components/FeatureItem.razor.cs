using Microsoft.AspNetCore.Components;

namespace Company.Features.Components
{
	public partial class FeatureItem
	{

		[Parameter]
		public string Title { get; set; }
		[Parameter]
		public string Description { get; set; }
	}
}
