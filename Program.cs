using System;
using System.Collections;

namespace assignment_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList animalList = new ArrayList(); // Animal arraylist

            // Instantiate the AnimalManager
            AnimalManager animalManager = new AnimalManager(animalList);

            // Start the program with the first animal entry
            animalManager.AddAnimal();

            // Loop to allow the user to add more animals or exit
            while (true)
            {
                Console.Write("Enter 'x' to exit or press Enter to add another animal: ");
                string input = Console.ReadLine().ToLower();

                if (input == "x")
                {
                    break; // Exit the loop and display the list
                }

                animalManager.AddAnimal(); // Add another animal
            }

            // Display all animals in the list
            Console.WriteLine("\nAll animals in the list:");
            foreach (Animal animal in animalList)
            {
                animal.Speak();
            }
        }
    }

    // Base Animal class
    public abstract class Animal
    {
        public string Name { get; set; } // getting and setting name
        public abstract void Speak();
    }

    // Derived class for Dog, allows for preset animal of dog
    public class Dog : Animal
    {
        public override void Speak() => Console.WriteLine($"{Name} says: Woof!");
    }

    // Derived class for Cat, allows for preset animal of cat
    public class Cat : Animal
    {
        public override void Speak() => Console.WriteLine($"{Name} says: Meow!");
    }

    // Class for animals and sounds defined by the user
    public class CustomAnimal : Animal
    {
        private readonly string _sound;

        public CustomAnimal(string sound)
        {
            _sound = sound;
        }

        public override void Speak() => Console.WriteLine($"{Name} says: {_sound}!"); // formatting name and sound added by user
    }

    // Animal management class to handle user input and list management
    public class AnimalManager
    {
        private readonly ArrayList _animals;

        public AnimalManager(ArrayList animals)
        {
            _animals = animals;
        }

        public void AddAnimal()
        {
            Console.Write("Enter animal type (Dog, Cat, or custom animal):"); // User input
            string type = Console.ReadLine();

            Animal newAnimal = CreateAnimal(type);
            if (newAnimal != null)
            {
                Console.Write("Enter animal name: ");
                newAnimal.Name = Console.ReadLine();
                _animals.Add(newAnimal);
                Console.WriteLine($"** {newAnimal.Name} the {type} has been added to the list **\n");
            }
        }

        // creating animals
        private Animal CreateAnimal(string type)
        {
            return type switch
            {
                "Dog" => new Dog(),
                "Cat" => new Cat(),
                _ => CreateCustomAnimal(type) // For custom animals
            };
        }

        private Animal CreateCustomAnimal(string type)
        {
            Console.Write($"Enter the sound that a {type} makes: ");
            string sound = Console.ReadLine();

            return new CustomAnimal(sound);
        }
    }  
}
