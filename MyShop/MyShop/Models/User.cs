namespace MyShop.Models; 

public abstract class User : BaseEntity 
{
    public abstract UserType Type { get; }
}

public sealed class Manager : User
{
    public override UserType Type => UserType.Manager;
}

public sealed class Visitor : User
{
    public override UserType Type => UserType.Visitor;
}


public enum UserType
{
    Manager, 
    Visitor
}