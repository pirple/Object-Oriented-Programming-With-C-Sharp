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
        //Control Flow
        //how your program 
        //loops, statements, and functions can alter the flow of your program
        //VERY important to know how your progam flows
        //knowing your control flow can be easily used to fix problems in your code

        //Random class
        //allows us to regerate random numbers 
        
        //declare a random number
        //use Random
        Random randInt = new Random();
        
        //initiate it
        //use next keyword
        //3 possible uses
        
        //default 
        int test = randInt.Next();
        //generates a non-negative 32bit integer
        
        int test2 = randInt.Next(55);
        //generates a non-negative 32bit integer from 0 - 55
        
        int test3 = randInt.Next(-100,100);
        //generates numbers from -100 to 100...X-Y 
        
        Console.WriteLine("Test1: " + test + ", Test2: " + test2 + ", test3: " + test3);
        
        
          int q = 10;
          int c = 11;
          
          //if statemnts
          //checks for a condition and does something according to the 
          //result 
          
          if(test2 == 10) // if this is true 
          {
              Console.WriteLine("Im 10");//do this 
          }
              else if(test2 == 11) //else check for this condition
          {
              Console.WriteLine("Im 11");//do this
          }
          else if(test2 == 0)//we can have multiple else ifs....
          {
              int Sum = c + q;
          }
          else //if the condition is not true
          {
              Console.WriteLine("Im not 10");
          }
          
          //switch statements
          //used to replace multiple else ifs-
          
          switch(c)
          {
          case 10:
              Console.WriteLine("Im 10");
              break;
          case 11:
              Console.WriteLine("Im 11");
              break;
          case 12:
              Console.WriteLine("Im 12");
              break;
          default: 
              Console.WriteLine("Im not 10");
              break;
          }
          
          //for loops
          //AVOID infinite Loops
          int x = 0;
          for (int i = 0; i < 10; i++)
          {
              x += i;
              Console.WriteLine(i);
              Console.WriteLine("The sum is: " + x);
          
              if(i == 7)
              {
                  Console.WriteLine("YOU ARE A WINNER!");
              }
          }
          
          //while loops
          bool go = true;
          int check = 0;
          
          while(go) //prints continue until check reaches 13 
          {
              Console.WriteLine("continue");

              if(check == 13)//check to stop 
              {
                  go = false;
              }
          
              check++;
          }

          do
          {
              Console.WriteLine("OKAY");
              check--;
              if(check == 0)//check to stop 
              {
                  go = true;
              }
          
          }while(!go);//condition        
        }
    }
}