namespace CRUDPractice.Models.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product>? Products { get; set; }

        public string? SearchString { get; set; }

        public string? SortOrder { get; set; }

        public IDictionary<string, string> GetRouteValues(Dictionary<string, string> newRouteValues)
        {
            IDictionary<string, string> routeValues = new Dictionary<string, string>()
            {
                { "SearchString", SearchString },
                { "SortOrder", SortOrder }
            };

            foreach (var pair in newRouteValues)
            {
                routeValues[pair.Key] = pair.Value;
            }

            return routeValues;
        }
    }
}
