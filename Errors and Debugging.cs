using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    class Program
    {
        //multiplies x and y
        static int multiply(int x, int y)
        {
            int result = x * y;
            return result;
        }
        //divides x by y
        static int divide(int x, int y)
        {
            int result = x / y;
            return result;
        }

        static void check()
        {
            Console.WriteLine("its working!");
        }
        static void Main(string[] args)
        {
            int myintX = 10;
            int myintY = 30;

            //res = 10 * 30
            int result = multiply(myintX, myintY);
            //newRes = (300 * 30)/ 10
            int newResult = divide(multiply(result, myintY), myintX);
            //finaltest = 900 * (300 * 900)
            int finalTest = multiply(newResult, multiply(result, newResult));

            while(finalTest > 5)
            {
                check();
                Console.WriteLine("The number {0} is quite big, lets drop it a bit", finalTest);
                int testInt = 3;
                finalTest = divide(finalTest, testInt);
                if(finalTest < 600 && finalTest > 5 )
                {
                    Console.WriteLine("THIS IS SILLY");
                    //other code 
                }

            }
            Console.WriteLine("Final Number is: " + finalTest);

            //debugging tools for visual studio
            //F10 next- move on to the next line
            //F11 step in- to a function 
            //F9 step out 

            Console.ReadKey();
        }
    }
}
