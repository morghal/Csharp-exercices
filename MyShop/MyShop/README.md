# MyShop - a C# console exercice

## Requirements

The app will provide a shop management system.  
Features will be splitted into 2 types of user : `Manager` & `Visitor`.  
Required features are the following :

- [All] Users
    - [All] Login
    - [All] Logout
    - [Manager] Add user
    - [Manager] Edit username or password
    - [Manager] Delete a user
- [Manager] Stock
    - List stock
    - Quickly add/remove one item
    - Add a new item
    - Update item quantity
    - Remove an item
- [All] Order
    - [Manager] List orders
    - [Manager] List orders of a specific status
    - [Manager] List orders of a Visitor 
    - [Manager] Change status of an order
    - [Visitor] List my orders
    - [Visitor] Mark an order as "Received"
- [All] Gallery
    - List items
    - Read product details
    - Search product by categories
    - Deep search product (single text checking every meaningful properties) 
    - Fuzzy search product
- [Visitor] Cart
    - List my cart with pricing
    - Add item to my cart
    - Update item quantity in my cart
    - Remove item from my cart
    - Validate my cart, creating an order with it

All methods must use common sense when implemented (ex: An order cannot contains 0 products)

No database is required here so stock, orders, logins, ... will be based on a json files.  
These files must IO as less as possible.

## Objectives/Limitations
- `Manager` and `Visitor` are polymorph.
- `Product` categories are defined through inheritance, not by enums.
- `Cart` price is computed on generic products. 
- `If(user == ROLE)` at the beginning of every methods is forbidden. Find a clever way to centralize this check.
- I need to be able to run my own UI implementation instead of the console app without changing anything.
- Provided services Interface's signatures can be changed but their name cannot and they have to be implemented.
- Following the previous point, object entities can only contains properties and small business logic. Data management is made through services classes
- Methods cannot contain more than 25 lines. 10 is a good average.
- Exact same code of more than 2 lines is forbidden. Dont repeat yourself.
- App must be usable in Release mode and Unix OSes (pay attention to file path 😉).
- Nuget packages are not allowed except `Newtonsoft` if prefered over `System.Text`.

## Hard mode
- Methods execution cannot take more than 200ms.
- Methods cannot contain more than 10 lines.
- Make services implement `IDataSource<T>` provided in \Interfaces to separate data management from domain processes
- A single json file is not allowed.
- User passwords are hashed.

## Useful links
- [Using class library](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0)
- [Extend types](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
- [Appsettings in ASP.NET](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0)
- [SHA512 for password hashing](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha512?view=net-7.0)