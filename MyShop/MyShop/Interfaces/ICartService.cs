using MyShop.Models;

namespace MyShop.Interfaces; 

public interface ICartService
{
    public Cart List(int userId);

    /// <summary> Add a product to the cart </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool AddProduct(Cart card, Product product, int quantity = 1);

    /// <summary> Change quantity of a product in the cart </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool UpdateProduct(Cart card, int newQuantity);

    /// <summary> Remove a product from the cart </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool RemoveProduct(Cart card, int productId);

    /// <summary> Transform a <see cref="Cart"/> to a brand new <see cref="Order"/>. </summary>
    public Order ToOrder(Cart cart);

    public decimal GetTotalPrice();
}
