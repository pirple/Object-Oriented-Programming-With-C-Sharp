//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    //what are classes?
    //blueprints to creating an object
    //they allow the user to create their own type as objects
    public class Monster
    {
    //what can a class contain
    //data members - constants/variables
    //methods/functions
    
    //public class - can be accessed anywhere on this project 
    //public data members/methods- can be accessed anywhere where the class
    //was instantiated 
    public string name_;
    public int size_;
    public const int legs_ = 2; 
    
    //private data members/methods - can ONLY be accessed in the class 
    private int scare_;
    
    //static data members/methods- apply to the entire class rather than 
    //an instance of it 
    public static int nMonsters_;
    
    //default constructor -intiated all values 
    public Monster()
    {
    name_ = "default";
    size_ = 20;
    scare_ = 10;
    nMonsters_++; //increment number of monsters
    }
    
    //constructors
    public Monster(string name, int size, int scare)
    {
    name_ = name;
    size_ = size;
    scare_ = scare;
    nMonsters_++;  
    }
    
    //methods
    public void print()
    {
    Console.WriteLine("Monsters name: " + name_);
    Console.WriteLine("Monsters size: " + size_);
    Console.WriteLine("Monsters scare: " + scare_);
    }
    
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Monster Dinosour = new Monster();
            //public members 
            Console.WriteLine(Dinosour.name_);
            //can be changed
            Dinosour.name_ = "Rex";
            Console.WriteLine(Dinosour.name_);
            
            //change a const cannot be changed 
            // exmaple -- Dinosour.legs_ = 3;
            
            //private members cannot be accessed here 
            // example -- Console.WriteLine(Dinosour.scare_);
            
            Console.WriteLine(Monster.nMonsters_);
            //using non-default-constructor
            Monster Dragon = new Monster("Drako", 30, 25);
            Console.WriteLine(Dragon.name_);
            
            //static check 
            Console.WriteLine(Monster.nMonsters_);
            
            Monster Zombie = new Monster("Zombie", 6, 8);
            //call print
            Zombie.print();
            Dragon.print();
            Dinosour.print();
                
            Console.WriteLine(Monster.nMonsters_);
        }
    }
}