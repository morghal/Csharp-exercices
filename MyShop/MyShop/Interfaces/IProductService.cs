using MyShop.Models;

namespace MyShop.Interfaces; 

public interface IProductService 
{
    /// <summary> List products in a UI-friendly way. Can be restricted to a subset of products by providing <paramref name="specificIds"/> </summary>
    public IEnumerable<string> List(IEnumerable<int>? specificIds = null);

    /// <summary> Get a specific product details </summary>
    public Product GetDetails(int productId);

    /// <summary> Find products of the provided <paramref name="categoryName"/> </summary>
    /// <returns> List of matching product or an empty list if nothing is found. </returns>
    public IEnumerable<string> GetByCategory(string categoryName);

    /// <summary> Search all properties of products using the provided <paramref name="searchText"/> </summary>
    /// <returns> List of matching product or an empty list if nothing is found. </returns>
    public IEnumerable<string> DeepSearch(string searchText);

    /// <summary> Apply a fuzzy search on product names</summary>
    /// <returns> List of matching product or an empty list if nothing is found. </returns>
    public IEnumerable<string> FuzzySearch(string searchText);

    /// <summary> Display a product in a UI-friendly way </summary>
    public string Format(Product product);
}
