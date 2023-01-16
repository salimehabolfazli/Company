using Microsoft.AspNetCore.Components;

namespace SorooshHamrah.Company.UI.Seperator.Components
{
    public partial class Separator
    {
        [Parameter]
        public string ImgUrl { get; set; }
        [Parameter]
        public string Content { get; set; }
        [Parameter]
        public string BtnName { get; set; }
    }
}
