using MyShop.Models;

namespace MyShop.Interfaces;

public interface IUserService
{
    /// <summary> Create a user </summary>
    public User Create(string username, string password, UserType type);

    /// <summary> Update the username and/or password of the user matching the provided <paramref name="userId"/> </summary>
    public User Update(int userId, string username, string password);

    /// <summary> Delete the user of the provided <paramref name="userId"/> </summary>
    public User Delete(int userId);

    /// <summary> Try to login a user using the provided <paramref name="username"/> and <paramref name="password"/> </summary>
    /// <remarks> Currently connected user must be kept somewhere. </remarks>
    public (bool result, string errorCode) Login(string username, string password);

    /// <summary> Logout the currently connected user </summary>
    public (bool result, string errorCode) Logout();
}
