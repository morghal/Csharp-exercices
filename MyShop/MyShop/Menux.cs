namespace MyShop;

public static class Menux
{
    /// <summary>
    ///  Reference the console menu loop here<br />
    ///  Directly code is not option, you must extract the behavior in a separate file (Object or static class, your choice)<br />
    /// </summary>
    /// <remarks> Hint: loop, Console namespace</remarks>
    public static void Show()
    {
        Console.WriteLine($"Welcome to {"I_SHOULD_BE_A_VAR"}");
        Console.WriteLine("Press any key to exit...");
        var holder = Console.Read();
    }
}
