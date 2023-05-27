using MyShop.Models;

namespace MyShop.Interfaces;

public interface IOrderService
{
    /// <summary> List all orders. </summary>
    /// <returns> List of matching Order or an empty list if nothing is found. </returns>
    public IEnumerable<Order> List();

    /// <summary> List orders of the provided <paramref name="status"/>. </summary>
    /// <returns> List of matching Order or an empty list if nothing is found. </returns>
    public IEnumerable<Order> List(OrderStatus status);
    
    /// <summary> List orders for the provided <paramref name="userId"/>. </summary>
    /// <returns> List of matching Order or an empty list if nothing is found. </returns>
    public IEnumerable<Order> List(int userId);

    /// <summary> Change the status of the provided <paramref name="order"/></summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool UpdateStatus(Order order, OrderStatus newStatus);
}
