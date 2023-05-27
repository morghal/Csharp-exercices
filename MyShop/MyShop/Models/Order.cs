namespace MyShop.Models; 

public class Order : BaseEntity 
{
    /// <summary> Products in the order with their quantity </summary>
    public IDictionary<Product, int> Products { get; set; }

    public DateTime CreatedAt { get; set; }

    public OrderStatus Status { get; set; }
}

public enum OrderStatus
{
    /// <summary> Orde has been created but not paid yet </summary>
    Created,
    /// <summary> Payment of the order has been received by the shop </summary>
    Paid,
    /// <summary> Order is in its way to the visitor </summary>
    Shipped,
    /// <summary> Order has been received by the visitor </summary>
    Received,
    /// <summary> Order has been cancelled and refunded to the visitor </summary>
    Refunded
}
