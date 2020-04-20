using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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
        /// The order items to display on the index page 
        /// </summary>
        public IEnumerable<CowboyCafe.Data.IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The current item categories
        /// </summary>
        [BindProperty]
        public string[] ItemCategories { get; set; }

        /// <summary>
        /// The minimum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The minimum calories
        /// </summary>
        [BindProperty]
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty]
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        /// <param name="SearchTerms">Current search terms</param>
        /// <param name="ItemCategories">Current item categoies</param>
        /// <param name="PriceMin">Current min price</param>
        /// <param name="PriceMax">Current max price</param>
        /// <param name="CaloriesMin">Current min calories</param>
        /// <param name="CaloriesMax">Current max calories</param>
        public void OnGet(string SearchTerms, string[] ItemCategories, double? PriceMin, double? PriceMax, double? CaloriesMin, double? CaloriesMax)
        {
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.SearchTerms = SearchTerms;
            this.ItemCategories = ItemCategories;
            Items = CowboyCafe.Data.Menu.Search(SearchTerms);
            Items = CowboyCafe.Data.Menu.FilterByCategory(Items, ItemCategories);
            Items = CowboyCafe.Data.Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = CowboyCafe.Data.Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
        }
    }
}
