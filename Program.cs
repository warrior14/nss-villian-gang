using System;

namespace VillainGang
{
    class Program
    {
        // args is an array of strings passed from the console when the program starts
        static void Main(string[] args)
        {
            
        // passing parameter to constructor    
        Evil venom = new Evil("Venom");
        Console.WriteLine($"Named Evil: {venom.Name}");


        // call a method on the class instance 
        venom.Reassemble();


        // using the object initializer 
        Evil namedWithInitializerEvil = new Evil() { Name = "Green Goblin"};
        Console.WriteLine($"Initializer Evil: {namedWithInitializerEvil.Name}");

        // relying on the default name in the overload of the constructor with no params
        Evil unknownEvil = new Evil();
        Console.WriteLine($"Unknown Evil: {unknownEvil.Name}");

        }
    }
}
