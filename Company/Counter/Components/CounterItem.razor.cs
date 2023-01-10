using Microsoft.AspNetCore.Components;

namespace Company.Counter.Components
{
	public partial class CounterItem
	{

		[Parameter]
		public string Number { get; set; }
		[Parameter]
		public string Text { get; set; }
	}
}
