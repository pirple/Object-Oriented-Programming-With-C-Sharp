//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{

    //enum
    //value type
    //used to declare a list of constant ints 
    
    //example 
    //Days of the week
    enum Day
    {
     Monday,
     Tuesday,
     //...
    }
    
    enum Direction
    {
    Left,                   //Left, as first item it will be assigned to
    Up,                           //0 
    Right,                        //Left = 1, Up = 2, Right = 100, Down 123
    Down                          //Left = 1,as first item...the rest will 
                                  //follow the number..Up would be 2..
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
         
        Direction dir = new Direction();
        dir = Direction.Down;

         if(dir == Direction.Left)
         {
         Console.WriteLine("Go Left");
         }
         else if(dir == Direction.Up)
         {
         Console.WriteLine("Go Up");
         }
         else if(dir == Direction.Right)
         {
         Console.WriteLine("Go Right");
         }
         else if (dir == Direction.Down)
         {
         Console.WriteLine("Go Down");
         }
        }
    }
}