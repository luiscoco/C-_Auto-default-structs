# Csharp11_Auto-default-structs

In C#, when you declare a struct without initializing its fields explicitly, the struct gets initialized with default values for its fields. This behavior is often referred to as "auto-default structs."

Here's a simple example to demonstrate this concept:

```csharp
struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        Point point; // Declaring a struct variable without initialization
        Console.WriteLine($"X: {point.X}, Y: {point.Y}"); // Output: X: 0, Y: 0
    }
}
```

In the above example, we define a struct called Point with two public fields, X and Y. In the Main method, we declare a variable point of type Point without initializing its fields explicitly. Since the struct is not explicitly initialized, it gets auto-initialized with default values. In this case, both X and Y fields are of type int, so their default values (when not explicitly initialized) are both set to 0.

When we print the values of X and Y to the console, we see that the auto-default initialization has set their values to 0.

It's important to note that unlike classes, structs are value types, and when you declare a struct variable without initializing it, all its fields will be automatically set to their respective default values. This behavior is consistent across all value types in C#.
