namespace AdvancedCSharp
{
    // Q11: A base class constraint requires T to be, or derive from, a
    // specific class, so members declared on that base class can be used
    // inside the generic code.
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract string MakeSound();
    }

    public class Dog : Animal
    {
        public override string MakeSound() => $"{Name} says Woof!";
    }

    public class AnimalHandler<T> where T : Animal
    {
        public string Handle(T animal)
        {
            return animal.MakeSound();
        }
    }
}
