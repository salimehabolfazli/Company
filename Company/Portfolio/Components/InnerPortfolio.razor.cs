using Microsoft.AspNetCore.Components;

namespace Company.Portfolio.Components
{
    public partial class InnerPortfolio
    {
        [CascadingParameter]
        public string Title { get; set; }
        [CascadingParameter]
        public string Description { get; set; }
        [CascadingParameter]
        public string ImgUrl { get; set; }
        [CascadingParameter]
        public string DataTitle { get; set; }
    }
}
