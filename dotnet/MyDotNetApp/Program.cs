using System;

namespace Hierarchical
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Cat : Animal
    {
        public void Jumps()
        {
            Console.WriteLine("The cat jumps.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Eat();
            cat.Eat();

        
            dog.Bark();
            cat.Jumps();
        }
    }
}