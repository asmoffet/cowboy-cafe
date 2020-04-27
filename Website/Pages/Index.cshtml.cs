using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// a list of the IOrder Items to be displayed
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }
        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }
        /// <summary>
        /// the minimum desired price
        /// </summary>
        public double? priceMin { get; set; }
        /// <summary>
        /// the maximum desired price
        /// </summary>
        public double? priceMax { get; set; }
        /// <summary>
        /// the minimum desired calories
        /// </summary>
        public int? calMin { get; set; }
        /// <summary>
        /// the maximum desired calories
        /// </summary>
        public int? calMax { get; set; }

        public string[] types { get; set; }

        public void OnGet(double? priceMin, double? priceMax, int? calMin, int? calMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            types = Request.Query["type"];
            //nullable conversion workaround from Razorpage project
            this.priceMax = priceMax;
            this.priceMin = priceMin;
            this.calMax = calMax;
            this.calMin = calMin;

            Items = Menu.Search(SearchTerms);
            Items = Menu.filterByType(types, Items);
            Items = Menu.FilterItemsByPrice(Items, priceMin, priceMax);
            Items = Menu.FilterItemsByCalories(Items, calMin, calMax);
            
        }
    }
}
