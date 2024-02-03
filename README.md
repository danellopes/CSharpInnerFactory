### Example of the Inner Factory

This example of the faceted builder design pattern was develop using C# language.

This technique allows is to make use of the Factory, without making our constructor public. To do this, we make the Factory class into an Inner class, or Inner factory. This way, it call access the private constructor and still serves as a more organized way to initiate an object.

This approach is not possible using Salesforce Apex, since the platform doesn't allow for inner static classes or methods.

If you're interested in the [udemy course](https://www.udemy.com/course/design-patterns-csharp-dotnet) by [Dmitri Nesteruk](https://www.udemy.com/user/dmitrinesteruk/).
