namespace MyShop.Models;

public class Stock : BaseEntity
{
    /// <summary> Available products in the stock associated with their quantity </summary>
    public IDictionary<Product, int> Products { get; set; }

}
