using Microsoft.AspNetCore.Components;

namespace SorooshHamrah.Company.UI.Portfolio.Components
{
    public partial class PortfolioItem
    {

        [Parameter]
        public string ImgUrl { get; set; }
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string Description { get; set; }
        [Parameter]
        public string DataTitle { get; set; }
    }
}
