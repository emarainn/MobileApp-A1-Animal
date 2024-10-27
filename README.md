# MobileApp-A1-Animal
This program was built for my mobile applications class. It allows users to add animals—like Dog, Cat, or custom animals with unique sounds—to a list and display them. Users enter the animal type, name, and sound (if custom) and can keep adding animals or type 'x' to view all entries with their sounds.

This C# console application allows users to add animals—either predefined ones like Dog and Cat, or custom animals with user-defined sounds—and display them along with their sounds. The program begins by prompting the user to enter an animal type, name, and, if custom, a sound. It stores the animals in an ArrayList and uses an AnimalManager class to manage user input and animal creation. A loop enables users to continue adding animals or type 'x' to exit and display all entries. The design uses polymorphism through a base Animal class, with derived classes for Dog, Cat, and custom animals, each implementing a Speak() method to print the animal’s name and sound. This structure ensures dynamic behavior while maintaining smooth interaction via user input.

 Main Program Execution (Main method)
Purpose: The entry point of the program where the logic starts.
Key Actions:
Creates an ArrayList (animalList) to store the animals.
Instantiates AnimalManager to manage user interactions and animal creation.
Prompts the user to add the first animal by calling AddAnimal().
Runs a loop that allows the user to:
Add more animals by pressing Enter.
Exit by typing 'x'.
After exiting the loop, it displays all the animals in the list with their corresponding sounds.
2. Animal Class (Base Class)
Purpose: A base (abstract) class that defines a generic animal structure.
Key Elements:
Name: A string property that stores the name of the animal.
Speak(): An abstract method that every derived animal class must implement to define the sound the animal makes.
3. Dog and Cat Classes (Derived Classes)
Purpose: These classes inherit from Animal and define the specific sounds for dogs and cats.
Key Details:
Dog.Speak(): Prints "<Name> says: Woof!".
Cat.Speak(): Prints "<Name> says: Meow!".
4. CustomAnimal Class
Purpose: This class allows user-defined animals with custom sounds.
Key Details:
The user provides the animal’s name and its unique sound during input.
Speak(): Prints "<Name> says: <custom sound>!".
5. AnimalManager Class
Purpose: Handles user input and manages the list of animals.
Key Methods:
AddAnimal():

Prompts the user to enter:
The type of animal (Dog, Cat, or custom).
The name of the animal.
Adds the animal to the list with confirmation.
CreateAnimal():

Uses a switch expression to determine if the user selected Dog, Cat, or a custom animal.
If it's a custom animal, it calls CreateCustomAnimal().
CreateCustomAnimal():

Prompts the user for the custom sound of the animal and creates a CustomAnimal object.
6. Program Flow Summary
At Startup:

The user is asked to enter an animal type (Dog, Cat, or custom animal).
If the animal is custom, the user must also specify the sound it makes.
The user provides the animal’s name, and the animal is added to the list.
In the Loop:

The user can continue adding animals or type 'x' to exit.
At Exit:

The program prints all animals in the list with their names and sounds.
