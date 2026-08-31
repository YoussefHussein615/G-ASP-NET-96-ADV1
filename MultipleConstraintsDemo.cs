using System;

namespace AdvancedCSharp
{
    // Q12: Multiple constraints are combined with commas after the
    // 'where' clause. Order rules: class/struct constraint first (if
    // any), then interfaces, then new() must always come last.
    public class Repository<T> where T : Animal, IComparable<T>, new()
    {
        public T CreateDefault()
        {
            return new T();
        }

        public T GetLarger(T a, T b)
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }
    }

    // Example type satisfying: derives from Animal, implements
    // IComparable<T>, and has a public parameterless constructor.
    public class Cat : Animal, IComparable<Cat>
    {
        public int Age { get; set; }

        public override string MakeSound() => $"{Name} says Meow!";

        public int CompareTo(Cat other)
        {
            return Age.CompareTo(other.Age);
        }
    }
}
