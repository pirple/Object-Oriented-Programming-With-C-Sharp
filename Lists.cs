//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //Single Dimensional Array
        //a reference type that can store multiple values 
        //can be accessed through indexing
        
        //declaring it
        int[] myArray;

        //initiating 
        //as we declare it
        int[] myNewArray = new int[10]; //0-9 used to access 
        
        //indexes start at 0
        
        //after declaring 
        myArray = new int[5]; //0-4
        myArray[0] = 234;
        myArray[1] = 5; 
        myArray[2] = 6;
        myArray[3] = 8;
        myArray[4] = 15;
        //myArray[5] = 9; DO NOT DO 
        Console.WriteLine(myArray[0]);
        
        //multidimensional arrays
        //declaring a 2Darray
        int[,] A2DArray = new int[2,2];        
        
        //declare a 2d array and inititalizing
        int[,] my2DArray = new int[,] {{1,2},{3,4}};
        
        //access with indexes
        Console.WriteLine("my2DArray[0,1] is: " + my2DArray[0,1]);
        
        //3D array
        int[,,] my3DArray = new int[2,2,3] {{{1,2,3},{4,5,6}},{{7,8,9},{10,11,12}}};
        Console.WriteLine("my3DArray[1,0, 2] is: " + my3DArray[1,0,2]);
        
        //Jagged Arrays
        //These are arrays that hold other arrays that can be different sizes
        int[][] myJagArray = new int[3][];
        myJagArray[0] = new int[3] {1, 2, 3};
        myJagArray[1] = new int[7] {4, 5, 6, 7, 8, 9, 10 };
        myJagArray[2] = new int[1] {11}; 
        
        //accessing a jagged array
        Console.WriteLine("my Jag Array[1][6] is: " + myJagArray[1][6]);
        
        //alternate way of initializing our jagged arrays
        char[][] myCharJagArray = new char[][]
        {
        new char[] {'h','e','l','l','o'},
        new char[] {'c','o','o','l'},
        new char[] {'b','y','e'}    
        };
        
        Console.WriteLine("my Char jag Array of [2][1] is: " + myCharJagArray[2][1]);
        
        //strings, chars, bool...whatever type can be stored in an array
        char[] myCharArray = new char[5];
        myCharArray[0] = 'h';
        myCharArray[1] = 'e';
        myCharArray[2] = 'l';
        myCharArray[3] = 'l';
        myCharArray[4] = 'o';
        
        for(int i = 0; i < 5; i++)
        {
        Console.WriteLine(myCharArray[i]);
        }
        
        //Lists
        //used to store multiple values 
        //the difference between a list and an array is that a list has 
        //dinamic memory and an array has a fixed memory allocation
        
        //declaring one
        
        List<int> myList = new List<int>();
        
        //add items we use Add
        
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        
        Console.WriteLine("my First List Item is: " + myList[0]);
        
        //we can also add an entire array to a list 
        //we use AddRange
        Console.WriteLine("myList Size is: " + myList.Count);
        myList.AddRange(myArray);
        Console.WriteLine("myList Size is: " + myList.Count);
        Console.WriteLine("myList's fourth item is : " + myList[3]);
        
        //Removing items from the list
        //Remove or RemoveAt
        
        //Remove
        //chosing a specifit item in the list
        List<string> Bosses = new List<string>();
        Bosses.Add("Dragon");
        Bosses.Add("Dinosour");
        Bosses.Add("Gorrilla");
        Bosses.Add("Rat");
                   
        Bosses.Remove("Rat");
        Console.WriteLine("Bosses Size is: " + Bosses.Count);
        
        //RemoveAt
        //Removes an item at a location using indexing
        Bosses.RemoveAt(1);
        Console.WriteLine("Bosses Size is: " + Bosses.Count);
        
        //the ability to combine two lists
        //they must be the same type
        List<string> Monsters = new List<string>();
        Monsters.Add("Megalodon");
        Monsters.Add("Aliens");
        Monsters.Add("Giant");
        
        //use Addrange
        Monsters.AddRange(Bosses);
        Console.WriteLine("Monsters Size is: " + Monsters.Count);
        
        for(int i = 0; i < 5; i ++) //
        {
        Console.WriteLine(Monsters[i]);
        }

        //Strings
        //strings are an array of characters
        //we can access through indexing but cannot change them
        string myString = "hello";
        Console.WriteLine("The last letter of Hello is: " + myString[4]);
        
        //BAD example 
        // DO NOT DO! myString[0] = 'Y';

        }
    }
}