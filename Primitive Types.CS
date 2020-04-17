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
            //variables are declared once and can be changed later on 
            
            //Naming of varibales or constants 
            //start with letter
            //can be followed by number or _ 
            int myInt = 1;
            int my_Int = 2;
            int myInt1 = 3;     
            
            //constants are declared once and cannot be changed later on     
            const int A_CONST_INT = 100; 
            
            //integer
            //ints by default are 32 bits
            //can hold numbers from -2,147,483,648 to 2,147,483,647
            //by default signed 
            int anInt = 1;
            const int THE_CONST_INT = 2;
            
            //-----------------------------------------------------------
            
            //8 bit verions of an Int 
            //byte
            //unsigned by defualt
            //range is 0 to 255; 
            byte myByte = 120;
            const byte MY_CONST_BYTE = 255; 
            
            //16 bit version of an Int
            //Short 
            //range is -32,768 to 32,767
            //by defult signed
            short myShort = 32000;
            const short MY_CONST_Short = -32000;
            
            //64 bit version of an int
            //Long
            //range -9.2X10^18 to 9.2X10^18
            long myLong = 323424324324;
            const long MY_CONST_LONG = 3241321312313; 
            //-----------------------------------------------------------
            //unsigned version
            
            //uint, ulong, ushort
            uint myUint = 11232;
            ushort myUshort = 12232;
            ulong myUlong = 1232323; 
            
            //------------------------------------------------------------
            //signed version of byte
            //sbyte
            //range -128 to 127
            sbyte mySbyte = -120;
            
            
            //------------------------------------------------------------ 
            
            //float
            //floats are by default 32 bits 
            //they can hold approximately -3.4X10^38 to 3.4X10^38 
            //ends with f otherwise it will assume its a double
            //accurate to 7 decimal units 
            float aFloat = 2.5634523f; 
            const float MY_FLOAT = 2.1425f; 
            
            //double 
            //64 bits decimals 
            //accurate to 15-16 decimal units 
            double aDouble = 2.234234;
            const double MY_DOUBLE = 12.23424; 
            
            //char 
            //they hold a value at a time
            //letter to a symbol 
            char myChar = 'a';
            const char MY_CONST_CHAR = '-';
            
            //boolean 
            //bool holds the value of true or false
            bool myBool = true;
            const bool MY_CONST_BOOL = false;
            
            //overflowing is when you try to assign a type a value too large for the container
            // Example sbyte mybyte_ = 129;
            
            //scope is where you can access values from 
            int testInt = 10; 
            if(testInt == 10)  //checking if testInt is equal to 10 
             {
               Console.WriteLine(myInt); 
               Console.WriteLine("Im 10");
               myInt = 25;
               Console.WriteLine(myInt);
               int newInt = -1;
               bool myNewBool = true;
               if(myNewBool == true) // if(myNewBool) "for true"  if(!myNewBool) "for false"
               {
                newInt = -10;
                Console.WriteLine(newInt);
               }
               
             }
             //example of bad scope
            //newInt = 20;
            
            

        }
    }
}