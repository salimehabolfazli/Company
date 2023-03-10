using Microsoft.AspNetCore.Components;

namespace SorooshHamrah.Company.UI.Blogs.Components
{
    public partial class BlogItem
    {
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string Content { get; set; }
        [Parameter]
        public string ImgUrl { get; set; }
        [Parameter]
        public string ImgTitle { get; set; }
    }
}
