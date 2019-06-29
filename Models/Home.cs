using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;
using System.Linq;


namespace StartBootstrap.Freelancer.Blazor.Models
{
    public partial class Home
    {
        public IEnumerable<PortfolioItem> PortfolioItemsTyped => PortfolioItems?.Cast<PortfolioItem>();
        public IEnumerable<NavigationItem> NavigationItemsTyped => Navigation?.Cast<NavigationItem>();
    }
}