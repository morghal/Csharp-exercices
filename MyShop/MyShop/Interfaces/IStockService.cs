using MyShop.Models;

namespace MyShop.Interfaces;

public interface IStockService
{
    /// <summary> List everything in the stock in UI-friendly way </summary>
    public IEnumerable<string> List(Stock stock);

    /// <summary> Remove a product from the stock </summary>
    /// <returns> Whether the method run as expected or not </returns>
    /// <remarks> 
    ///  The product might not exist in the "database" yet. <br />
    ///  In this case, it must be created, persisted then passed to any classes that may need it.
    /// </remarks>
    public bool AddProduct(Stock stock, Product product, int quantity = 1);

    /// <summary> Remove a product from the stock </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool UpdateProduct(Stock stock, int newQuantity);

    /// <summary> Remove a product from the stock </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool RemoveProduct(Stock stock, int productId);

    /// <summary> Quickly add/remove one quantoty of the matching product. </summary>
    /// <param name="addOrRemove"> true is an adddition, false is removal </param>
    /// <returns> Whether the method run as expected or not </returns>
    public bool QuickProductUpdate(Stock stock, int productId, bool addOrRemove);
}
