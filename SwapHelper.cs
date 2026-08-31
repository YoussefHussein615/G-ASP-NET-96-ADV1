namespace AdvancedCSharp
{
    // Q4: Generic method Swap<T> - swaps the values of two variables of
    // the same type, whatever that type is decided by the caller.
    public static class SwapHelper
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
