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
        /// <summary>
        /// the types of entrees
        /// </summary>
        public string[] types { get; set; }
        /// <summary>
        /// the update for what to display on the razor page
        /// </summary>
        /// <param name="priceMin">the minimun search price</param>
        /// <param name="priceMax">the maximum search price</param>
        /// <param name="calMin">the minimum calorie amount</param>
        /// <param name="calMax">the maximum calorie amount</param>
        public void OnGet(double? priceMin, double? priceMax, int? calMin, int? calMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            types = Request.Query["type"];
            //nullable conversion workaround from Razorpage project
            this.priceMax = priceMax;
            this.priceMin = priceMin;
            this.calMax = calMax;
            this.calMin = calMin;

            /*
            Items = Menu.Search(SearchTerms);
            Items = Menu.filterByType(types, Items);
            Items = Menu.FilterItemsByPrice(Items, priceMin, priceMax);
            Items = Menu.FilterItemsByCalories(Items, calMin, calMax);
            */
            Items = Menu.CompleteMenu();
            //filter through searching
            if(SearchTerms != null)
            {
                Items = Items.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            //filter by type
            if(types != null)
            {
                if (types.Contains("entree") && types.Contains("side") && types.Contains("drink"))
                {
                    Items = Items.Where(item => item is Entree || item is Side || item is Drink);
                }
                else if (types.Contains("entree") && types.Contains("side"))
                {
                    Items = Items.Where(item => item is Entree || item is Side);
                }
                else if (types.Contains("entree") && types.Contains("drink"))
                {
                    Items = Items.Where(item => item is Entree || item is Drink);
                }
                else if (types.Contains("side") && types.Contains("drink"))
                {
                    Items = Items.Where(item => item is Drink || item is Side);
                }
                else if (types.Contains("entree"))
                {
                    Items = Items.Where(item => item is Entree);
                }
                else if (types.Contains("side"))
                {
                    Items = Items.Where(item => item is Side);
                }
                else if (types.Contains("drink"))
                {
                    Items = Items.Where(item => item is Drink);
                }
            }
            //checking price
            if(priceMax != null && priceMin != null)
            {
                Items = Items.Where(item => item.Price >= priceMin && item.Price <= priceMax);
            }
            if (priceMax != null)
            {
                Items = Items.Where(item => item.Price <= priceMax);
            }
            if (priceMin != null)
            {
                Items = Items.Where(item => item.Price >= priceMin);
            }
            //checking calories
            if (calMax != null && calMin != null)
            {
                Items = Items.Where(item => item.Calories >= calMin && item.Calories <= calMax);
            }
            if (calMax != null)
            {
                Items = Items.Where(item => item.Calories <= calMax);
            }
            if (calMin != null)
            {
                Items = Items.Where(item => item.Calories >= calMin);
            }

        }
    }
}
