namespace AdvancedCSharp
{
    // Q3: Multiple type parameters. Pair<TKey, TValue> holds two related
    // values of possibly different types.
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"({Key}, {Value})";
        }
    }
}
