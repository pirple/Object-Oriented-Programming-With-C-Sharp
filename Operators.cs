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
           //What are operators?
           //operators are characters that allow for certain actions or 
           //operations to take place
           
           //Equals = 
           //assignment
           int myInt = 10; 
           
           //comparing values == 
           if(myInt == 10)
           {
           Console.WriteLine("Im 10");
           }           
           //not equals != 
           if(myInt != 8)
           {
           Console.WriteLine("Im not 8");
           }
           //+ 
           myInt = myInt + 2; 
           Console.WriteLine(myInt);
           //-
           myInt = myInt - 2; 
           Console.WriteLine(myInt);
           //* 
           myInt = myInt * 2;
           Console.WriteLine(myInt);
           //   /
           myInt = myInt / 2;
           Console.WriteLine(myInt);
           
           //pre-incremention ++ -- 
           int i = 0; 
           Console.WriteLine(++i); //should print 1
           
           //post-incrementations
           Console.WriteLine(i++); //should still print 1
           Console.WriteLine(i); //should print 2
           
           // > < greater than and less than
           int A = 10;
           int B = 15;
           if(A > B)
           {
           Console.WriteLine("A is bigger");  
           }
           else
           {
           Console.WriteLine("B is Bigger");
           }  
           
           //>= <= greater than or equal to or less than and equal to 
           B = 5; 
           if(A >= B)
           {
           Console.WriteLine("A is bigger");  
           }
           else
           {
           Console.WriteLine("B is Bigger");
           }
           
           // +=, -=, *=, /= 
           
           int c = 10;
           c +=2; //prints 12
           c -=2; //prints 10
           c *=2; //prints 20
           c /=2; //prints 10
           
           //Modulo %
           //remainder
           
           int D = 21;
           int E = D % 5; 
           Console.WriteLine(E);
           
           //?:
          int NewInt = 0;
          // recipient = condition ? true : false; 
          NewInt = (E > 3) ? NewInt = 5 : NewInt = 2;
          Console.WriteLine(NewInt);

           //what are logical operators?
           //these allow for logical operations to take place. These are 
           // AND, OR, and NOT
           // && , ||, ! 
           
           bool boolA = true; 
           bool boolB = false;
           //&& 
           if( boolA && boolB)
           {
           Console.WriteLine("YAY!");
           }
           else
           {
           Console.WriteLine("OH NO!");
           }
           
           // ||
           if( boolA || boolB)
           {
           Console.WriteLine("YAY!");
           }
           else
           {
           Console.WriteLine("OH NO!");
           }
           
           //! 
            if( boolA && !boolB) //if boolA is true AND boolB is false
           {
           Console.WriteLine("YAY!");
           }
           else
           {
           Console.WriteLine("OH NO!");
           }
           
           //HOW to make comments //
           
           
           
        }
    }
}