using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//System.IO allows to read and write files and data streams 
//anything that has to do with files required system.IO

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //USE The File Class 

            string path = @"C:\temp\testText.txt";
            string path2 = @"C:\temp\text.txt";

            //File.Exists checks if there is a file of such name in such directory 
            if (File.Exists(path))
            {

                //File.Delete(path) deletes such file from the directory
                File.Delete(path);
            }

            //File.WriteAllText() 
            //creates the file, allows us to write to it and then closes the file
            //if the file exists it will replace it
            File.WriteAllText(path, "Hello!");

            //File.WriteAllLines()
            //creates the file, allows us to write 1 or more lines and then closes the file
            //replaces existing files
            File.WriteAllLines(path2, new string[] { "Hello!", "This is kind of neat!" });

            //editing the files -Appending to the files 
            //File.AppendAllText()
            //opens file, appends to it and then closes it 
            File.AppendAllText(path, " How's it going?");

            //reading the file
            //File.ReadAllTexts returns a string 
            string contents = File.ReadAllText(path2);
            Console.WriteLine("Contents is:" + contents);
            Console.WriteLine(File.ReadAllText(path));

            Console.ReadKey();

        }
    }
}