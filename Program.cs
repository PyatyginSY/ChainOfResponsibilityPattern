using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ChainOfResponsibilityPattern");
            Console.WriteLine("");

            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            Client.ClientCode(monkey);

            Console.WriteLine("");

            Client.ClientCode(squirrel);
        }
    }
}
