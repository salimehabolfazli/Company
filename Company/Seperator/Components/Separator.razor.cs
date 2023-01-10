using Microsoft.AspNetCore.Components;

namespace Company.Seperator.Components
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
