namespace AdvancedCSharp
{
    // Q9: The 'new()' constraint requires T to have a public parameterless
    // constructor, so the generic code is allowed to create instances of
    // T itself with "new T()".
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    public class Widget
    {
        public string Name { get; set; } = "Unnamed Widget";
    }

    // Usage: new Factory<Widget>().CreateInstance(); -> OK, Widget has a public parameterless ctor
}
