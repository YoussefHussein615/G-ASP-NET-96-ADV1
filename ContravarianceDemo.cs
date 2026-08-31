using System;

namespace AdvancedCSharp
{
    // Q16: Contravariance ('in' keyword) lets a generic interface with
    // IConsumer<in T> be used through a LESS DERIVED type reference than
    // it was created with, e.g. IConsumer<Dog> can point to an object
    // that is actually IConsumer<Animal>, because the interface only
    // ever *consumes* (accepts) T as a parameter, never returns it.
    public interface IConsumer<in T>
    {
        void Consume(T item);
    }

    public class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal item)
        {
            Console.WriteLine($"Consuming animal: {item.Name}");
        }
    }

    // Usage:
    // IConsumer<Animal> animalConsumer = new AnimalConsumer();
    // IConsumer<Dog> dogConsumer = animalConsumer; // allowed because of 'in'
    // dogConsumer.Consume(new Dog { Name = "Rex" });
}
