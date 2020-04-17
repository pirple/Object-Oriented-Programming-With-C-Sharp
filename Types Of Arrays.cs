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