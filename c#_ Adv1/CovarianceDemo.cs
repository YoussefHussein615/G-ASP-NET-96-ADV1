namespace AdvancedCSharp
{
    // Q15: Covariance ('out' keyword) lets a generic interface with
    // IProducer<out T> be used through a MORE DERIVED type reference
    // than it was created with, e.g. IProducer<Animal> can point to an
    // object that is actually IProducer<Dog>, because the interface only
    // ever *produces* (returns) T, never accepts it as a parameter.
    public interface IProducer<out T>
    {
        T Produce();
    }

    public class DogProducer : IProducer<Dog>
    {
        public Dog Produce()
        {
            return new Dog { Name = "Rex" };
        }
    }

    // Usage:
    // IProducer<Dog> dogProducer = new DogProducer();
    // IProducer<Animal> animalProducer = dogProducer; // allowed because of 'out'
    // Animal a = animalProducer.Produce();
}
