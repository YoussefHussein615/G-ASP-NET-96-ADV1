namespace c___Adv1
{
    /*
     
Q1: What is a generic class? Why use generics?
    A generic class is a class defined with one or more type
    parameters(placeholders), e.g. class Box<T>. The actual type is
    supplied when the class is used, e.g.Box<int> or Box<string>.
    Generics are used to write reusable, type-safe code: the same
    class/method works for many data types without duplicating code,
    without boxing value types, and with compile - time type checking
    instead of runtime casts(which avoids InvalidCastException and
    boxing/unboxing overhead).

Q3: What are multiple type parameters?
    A generic type or method can declare more than one type
    parameter, separated by commas, e.g.Pair<TKey, TValue>.Each
    parameter is independent and can be a different concrete type
    when the generic is used.

Q6: What is a generic interface?
    An interface that itself takes type parameters, e.g.
    IRepository<T>.Any class implementing it must specify(or pass
    through) the type argument, letting the same contract(Add,
    GetById, GetAll, Remove...) work for any entity type.

Q7: What is the 'struct' constraint?
    "where T : struct" restricts T to non-nullable value types
    (int, double, bool, custom structs, enums). Reference types and
    Nullable<T> are not allowed.

Q8: What is the 'class' constraint?
    "where T : class" restricts T to reference types (classes,
    interfaces, delegates, arrays). Value types are not allowed.

Q9: What is the 'new()' constraint?
    "where T : new()" requires T to expose a public parameterless
    constructor, so generic code can do "new T()" to create
    instances itself.

Q10: What is the interface constraint?
    "where T : ISomeInterface" requires T to implement a specific
    interface, so the generic code can call that interface's members
    on any T.

Q11: What is the base class constraint?
    "where T : SomeBaseClass" requires T to be, or derive from, a
    specific class, giving the generic code access to that base
    class's members.

Q12: How do you apply multiple constraints?
    List them after a single 'where' clause, separated by commas:
    where T : BaseClass, ISomeInterface, new ()
    Rule: an optional class/struct constraint comes first, then any
    interface constraints, and new () must always be listed last.

Q13: What does the 'default' keyword do in generics?
    default(T) (or just 'default' with target-typing) returns the
    default value for T: 0/0.0/false for value types, null for
    reference types.It is needed because you can't hardcode "null"
    or "0" when T's category (value vs reference) isn't known ahead
    of time.

Q15: What is covariance? Explain the 'out' keyword.
    Covariance lets a generic interface/delegate be used through a
    MORE derived type parameter than it was declared with, e.g.
    IProducer<Dog> can be treated as IProducer<Animal>.It's marked
    with 'out' on the type parameter and is only valid when T is
    used purely in OUTPUT positions (return values), never as an
    input parameter.

Q16: What is contravariance? Explain the 'in' keyword.
    Contravariance lets a generic interface/delegate be used through
    a LESS derived type parameter than it was declared with, e.g.
    IConsumer<Animal> can be treated as IConsumer<Dog>.It's marked
    with 'in' on the type parameter and is only valid when T is used
    purely in INPUT positions (method parameters), never as a return
    value.

Q17: What is the difference between covariance and contravariance?
    Covariance ('out') preserves the direction of the inheritance
    relationship and applies to types you only get back OUT
    (return values): IProducer<Dog> -> IProducer<Animal>.
    Contravariance('in') reverses the direction and applies to
    types you only put IN(parameters): IConsumer<Animal> ->
    IConsumer<Dog>.In short: covariance = "more specific becomes
    more general" for outputs; contravariance = "more general
    becomes more specific" for inputs.

Q18: How do static members work in generic types?
    Static members are not shared across every closed generic type.
    Each distinct combination of type arguments (Counter<int>,
    Counter<string>, ...) gets its own independent copy of the
    static field/state.

Q19: How can you inherit from a generic class?
    Three ways: (1) close the generic type with a concrete type
    argument, e.g. class IntContainer : Container<int>; (2) inherit
    while staying generic, passing the type parameter through, e.g.
    class LoggingContainer<T> : Container<T>; (3) the derived class
    can introduce additional type parameters of its own.

*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("=== q2: container<t> ===");
            //var container = new container<string>();
            //container.add("first");
            //container.add("second");
            //console.writeline($"count: {container.count}, item 0: {container.get(0)}");

            //console.writeline("\n=== q3: pair<tkey, tvalue> ===");
            //var pair = new pair<string, int>("age", 25);
            //console.writeline(pair);

            //console.writeline("\n=== q4: swap<t> ===");
            //int x = 1, y = 2;
            //swaphelper.swap(ref x, ref y);
            //console.writeline($"x={x}, y={y}");

            //console.writeline("\n=== q5: findmax<t> ===");
            //var numbers = new list<int> { 4, 9, 2, 7, 1 };
            //console.writeline($"max: {maxfinder.findmax(numbers)}");

            //console.writeline("\n=== q6: irepository<t> ===");
            //irepository<string> repo = new inmemoryrepository<string>();
            //repo.add("alice");
            //repo.add("bob");
            //console.writeline($"repository item 1: {repo.getbyid(1)}");

            //console.writeline("\n=== q7: struct constraint ===");
            //var structdemo = new structconstraintdemo<int>(0);
            //console.writeline($"isdefault: {structdemo.isdefault()}");

            //console.writeline("\n=== q8: class constraint ===");
            //var classdemo = new classconstraintdemo<string>("hello");
            //console.writeline($"isnull: {classdemo.isnull()}");

            //console.writeline("\n=== q9: new() constraint ===");
            //var factory = new factory<widget>();
            //widget widget = factory.createinstance();
            //console.writeline($"created: {widget.name}");

            //console.writeline("\n=== q10: interface constraint ===");
            //var shapeprinter = new shapeprinter<circle>();
            //shapeprinter.printarea(new circle(3));

            //console.writeline("\n=== q11: base class constraint ===");
            //var handler = new animalhandler<dog>();
            //console.writeline(handler.handle(new dog { name = "rex" }));

            //console.writeline("\n=== q12: multiple constraints ===");
            //var catrepo = new constrainedrepository<cat>();
            //var c1 = new cat { name = "whiskers", age = 2 };
            //var c2 = new cat { name = "tom", age = 5 };
            //console.writeline($"larger cat: {catrepo.getlarger(c1, c2).name}");

            //console.writeline("\n=== q13/q14: default keyword & safelist<t> ===");
            //var safelist = new safelist<int>();
            //safelist.add(10);
            //console.writeline($"valid index: {safelist.getsafe(0)}, invalid index: {safelist.getsafe(5)}");

            //console.writeline("\n=== q15: covariance (out) ===");
            //iproducer<dog> dogproducer = new dogproducer();
            //iproducer<animal> animalproducer = dogproducer;
            //console.writeline($"produced: {animalproducer.produce().name}");

            //console.writeline("\n=== q16: contravariance (in) ===");
            //iconsumer<animal> animalconsumer = new animalconsumer();
            //iconsumer<dog> dogconsumer = animalconsumer;
            //dogconsumer.consume(new dog { name = "buddy" });

            //console.writeline("\n=== q18: static members in generic types ===");
            //new counter<int>();
            //new counter<int>();
            //new counter<string>();
            //console.writeline($"counter<int>.instancecount = {counter<int>.instancecount}");
            //console.writeline($"counter<string>.instancecount = {counter<string>.instancecount}");

            //console.writeline("\n=== q19: inheriting from a generic class ===");
            //var intcontainer = new intcontainer();
            //intcontainer.add(42);
            //console.writeline($"intcontainer count: {intcontainer.count}");

            //var loggingcontainer = new loggingcontainer<string>();
            //loggingcontainer.addwithlog("logged item");

            //console.writeline("\n=== q20: cache<tkey, tvalue> ===");
            //var cache = new cache<string, string>(timespan.fromminutes(10));
            //cache.add("user:1", "alice");
            //console.writeline($"contains user:1: {cache.contains("user:1")}");
            //if (cache.tryget("user:1", out string cachedvalue))
            //    console.writeline($"cached value: {cachedvalue}");
            //cache.remove("user:1");
            //console.writeline($"contains user:1 after remove: {cache.contains("user:1")}");
        }
    }
}
