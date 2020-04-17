//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //modifying strings           
            //string class allows us to use replace and remove
            string testString = "Hello, my name is Fredy";
            
            //Replace can be used to replace words with others
            //Replace replaces every instance of that character/word
            string resultString = testString.Replace("Fredy", "Hector");
            Console.WriteLine(testString);
            Console.WriteLine(resultString);
            //Replace can be used a different way 
            string resString2 = testString.Replace("e", "i");
            Console.WriteLine(resString2);
            
            //Remove removes a list of characters from a starting point as 
            //an index
            string removeString = testString.Remove(17,6); 
            Console.WriteLine(removeString);
            
            //appending strings
            testString = testString + " and I am a CS major";
            Console.WriteLine(testString);
            
            //PROBLEMS 
            //we create a new instance of a string everytime we modify
            //which causes our program to run slower and use more memmory
            //than needed 
            
            //Solution
            //StringBuilder 
            //to use it we need to include System.Text
            StringBuilder mySB = new StringBuilder("Hello World", 20);
            Console.WriteLine(mySB);
            Console.WriteLine("mySB capacity is: " + mySB.Capacity);
            
            //we can also set a capacity
            //what we would like the string builder to hold
            
            //Methods
            //Append adds to the end of the stringbuilder 
            mySB.Append(" is our first Program!");
            Console.WriteLine(mySB);
            Console.WriteLine("mySB capacity is: " + mySB.Capacity);
            
            //Insert adds a string to a certain location using indexes
            mySB.Insert(25, "small ");
            Console.WriteLine(mySB);
            
            //Remove removes a list of character starting at a certain location
            mySB.Remove(25, 6);
            Console.WriteLine(mySB);
            
            //Replace replaces characters/words with characters or words 
            mySB.Replace("our", "my");
            Console.WriteLine(mySB);
            mySB.Replace("o", "z");
            Console.WriteLine(mySB);
            mySB.Replace("i", "NOT");
            Console.WriteLine(mySB);
        }