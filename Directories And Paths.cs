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

            //Direcotory - Folders

            string dirPath = @"C:\temp\newDirectory";

            //Cannot exists 
            if (Directory.Exists(dirPath))
            {
                //Deleting
                //two ways
                //1 IF the directory is Empty
                //Directory.Delete(newPath);

                //2 IF the directory ISNT empty
                Directory.Delete(dirPath, true);

            }
            Directory.CreateDirectory(dirPath);

            //Path Class
            //allow us to make changes to the string path that lead to directories or filess 

            string newPath = @"C:\temp\newDirectory\ourText.txt";

            File.WriteAllText(newPath, "WOW this is really cool!");

            //gets directory name
            string dirName = Path.GetDirectoryName(newPath);
            Console.WriteLine("Directory Name: " + dirName);

            //gets file extension
            string fileExt = Path.GetExtension(newPath);
            Console.WriteLine("File Extension: " +  fileExt);

            //gets File Name
            string fileName = Path.GetFileName(newPath);
            Console.WriteLine("File Name: " + fileName);

            //gets file name without extention
            string file_woExt = Path.GetFileNameWithoutExtension(newPath);
            Console.WriteLine("File Name/No Extension: " + file_woExt);

            //get files root directory
            string root = Path.GetPathRoot(newPath);
            Console.WriteLine("Root Directory: " + root);

            //change file extension 
            string newFileRes = Path.ChangeExtension(newPath, ".new");
            Console.WriteLine("new File: " + newFileRes);


            Console.ReadKey();

        }
    }
}