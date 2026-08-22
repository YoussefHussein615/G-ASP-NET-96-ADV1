namespace AdvancedCSharp
{
    // Q8: The 'class' constraint restricts T to be a reference type
    // (any class, interface, delegate, or array). Value types like int
    // or a struct are not allowed.
    public class ClassConstraintDemo<T> where T : class
    {
        public T Value { get; set; }

        public ClassConstraintDemo(T value)
        {
            Value = value;
        }

        public bool IsNull()
        {
            return Value == null;
        }
    }

    // Usage: new ClassConstraintDemo<string>("hello"); -> OK, string is a reference type
    //        new ClassConstraintDemo<int>(5);           -> compile error
}
