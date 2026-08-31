namespace AdvancedCSharp
{
    // Q19: You can inherit from a generic class in three ways:
    // 1) Close the generic type with a concrete type argument.
    // 2) Inherit and stay generic, passing the type parameter through.
    // 3) Add extra type parameters in the derived class.

    // 1) Closed / concrete inheritance
    public class IntContainer : Container<int>
    {
    }

    // 2) Open / still-generic inheritance
    public class LoggingContainer<T> : Container<T>
    {
        public void AddWithLog(T item)
        {
            Add(item);
            System.Console.WriteLine($"Added item, count is now {Count}");
        }
    }
}
