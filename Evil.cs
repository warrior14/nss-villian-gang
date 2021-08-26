using System; 
using System.Collections.Generic;
using VillianGang.Modes;


namespace VillianGang
{
    public class Evil 
    {
        public string Name { get; set; }

        public Evil()
        {
            Name = "Unamed Villian Gang";
        }

        public Evil(string name)
        {
            Name = name;
        }

        // Write a method that Adds a villian to the Villian Gang 
        // Write a method that lists all of the Villian Gang


        public void Reassemble()
        {
            Console.WriteLine($"{Name} Assemble!");
        }
    }
}