using Microsoft.AspNetCore.Components;

namespace Company.Shared
{
	public partial class SectionTitle
	{
		[Parameter]
		public string Title { get; set; }
		[Parameter]
		public string Description { get; set; }
	}
}
