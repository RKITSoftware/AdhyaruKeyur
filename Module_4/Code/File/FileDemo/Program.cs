using System;
using System.IO;
using System.Linq;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "fileDemo.txt";
            string copyPath = "fileDemoCopy.txt";
            string dummyLines = "This is first line.\n" +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";

            //use to create or overwrite file.
            var objFile = File.Create(path);

            //use to close the file.
            objFile.Close();

            //Deletes the specified file.
            File.Delete(path);

            //Creates or opens a file for writing UTF-8 encoded text.
            File.CreateText(copyPath);

            //use to check file.
            if (File.Exists(copyPath))
            {
                Console.WriteLine("File Created - {0}", copyPath);
            }
            else
            {
                Console.WriteLine("File Not Found !!");
            }

            //append the text
            File.AppendAllText(path, dummyLines);

            string someText = "C# Corner is a community of software and data developers";
            File.WriteAllText(path, someText);

            // Read entire text file content in one string  
            string text = File.ReadAllText(path);
            Console.WriteLine("File in String Format - " + text);

            // Write file using StreamWriter  
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Monica Rathbun");
                writer.WriteLine("Vidya Agarwal");
                writer.WriteLine("Mahesh Chand");
                writer.WriteLine("Vijay Anand");
                writer.WriteLine("Jignesh Trivedi");
            }

            // Read a text file line by line.
            Console.WriteLine("\n Read Line by Line");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
                Console.WriteLine(line);


            // An array of strings  
            string[] authors = {"Mahesh Chand", "Allen O'Neill", "David McCarter","Raj Kumar", "Dhananjay Kumar"};
            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            File.WriteAllLines(path, authors);

            Console.WriteLine("\n Read Using Stream Reader");
            // Read file using StreamReader. Reads file line by line    
            using (StreamReader file = new StreamReader(path))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }

            //Get when the file was accessed last time 
            DateTime lastAccessTime = File.GetLastAccessTime(path);
            Console.WriteLine($"\nlast File has Access at {lastAccessTime}.");

            //get when the file was written last time
            DateTime lastWriteTime = File.GetLastWriteTime(path);
            Console.WriteLine($"\nlast File has Written at {lastWriteTime}.");

            // Move file to new location
            //File.Move(@"C:\DummyFile.txt", @"D:\DummyFile.txt");

            //Open file and returns FileStream for reading bytes from the file
            //FileStream fs = File.Open(@"D:\DummyFile.txt", FileMode.OpenOrCreate);


        }
    }
}
