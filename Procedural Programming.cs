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
        //adds two integers and returns the result
        static int add(int x , int y)
        {
            int result = x + y; 
            //printInt(result);  
            return result;  
              
        }
        
        //prints out an integer 
        static void printInt(int x)
        {
            Console.WriteLine(x);        
        }
        
        //prints out welcome
        static void printIntro()
        {
            Console.WriteLine("Welcome!");
        }

        public static void Main(string[] args)
        {
            //procedural programming
            //is based on making calls to functions/routines/subroutines
            
            printIntro();
            //add and print
            int res = add(5, 15);
            printInt(res);
            
            //keep reusing them 
            int newRes = add(res, -12);
            printInt(newRes);
   
        }
    }
}