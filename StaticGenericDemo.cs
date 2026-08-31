namespace AdvancedCSharp
{
    // Q18: Static members in a generic type are NOT shared across all
    // closed types. Each distinct closed generic type (Counter<int>,
    // Counter<string>, ...) gets its OWN copy of the static field,
    // because the runtime generates a separate type per value-type
    // argument (and shares one implementation across reference-type
    // arguments, but still keeps the static data separate per type).
    public class Counter<T>
    {
        public static int InstanceCount;

        public Counter()
        {
            InstanceCount++;
        }
    }

    // Usage:
    // new Counter<int>(); new Counter<int>();     -> Counter<int>.InstanceCount == 2
    // new Counter<string>();                       -> Counter<string>.InstanceCount == 1 (separate counter)
}
