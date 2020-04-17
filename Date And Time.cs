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
        //What is DateTime
        //a class that gives us access to date and time
        DateTime myDate = DateTime.Now;
        
        DateTime mySecondDate = new DateTime(2000 ,12, 24);
        
        //.ToString()
        Console.WriteLine(myDate.ToString());
        
        //.ToShortDateString()
        Console.WriteLine(myDate.ToShortDateString());
        
        //.ToShortTimeString()
        Console.WriteLine(myDate.ToShortTimeString());
        
        //.ToLongDateString()
        Console.WriteLine(myDate.ToLongDateString());
        
        //.ToLongTimeString()
        Console.WriteLine(myDate.ToLongTimeString());
        
        //mathematical functions- add and subtracts
        Console.WriteLine(myDate.AddYears(5).ToShortDateString());
        
        //subtract hours
        Console.WriteLine(myDate.AddHours(-6).ToLongTimeString());
        
        //access
        //.month , .day .hours...so on
        Console.WriteLine(myDate.Month.ToString());
        
        //Convers trings to DateTime
        //Parse
        DateTime testDate = DateTime.Parse("2000/12/24");
        Console.WriteLine(testDate.ToString());
        
        //TimeSpan 
        //Allows us to see what the time difference is between two dates 
        //use Subtract 
        //getting difference bettween today and testDate
        TimeSpan daysPassed = DateTime.Now.Subtract(testDate);
        Console.WriteLine(daysPassed.TotalDays);
    
        }
    }
}