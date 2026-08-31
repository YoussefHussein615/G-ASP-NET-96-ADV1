namespace AdvancedCSharp
{
    // Q7: The 'struct' constraint restricts T to be a non-nullable value
    // type (int, double, bool, custom structs, enums...). It cannot be a
    // reference type, and it cannot be Nullable<T> itself.
    public class StructConstraintDemo<T> where T : struct
    {
        public T Value { get; set; }

        public StructConstraintDemo(T value)
        {
            Value = value;
        }

        public bool IsDefault()
        {
            return Value.Equals(default(T));
        }
    }

    // Usage: new StructConstraintDemo<int>(5);      -> OK, int is a struct
    //        new StructConstraintDemo<string>("x");  -> compile error
}
