using System;

namespace ImplicitInterface
{
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
        /*void WriteFile(string text)
        {
            Console.Write(text);  //error: cannot implement method
        }*/
    }

    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string name)
        {
            Console.WriteLine("Writing to file " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo objfileInfo = new FileInfo();
            objfileInfo.ReadFile();
            objfileInfo.WriteFile("mydemo.txt");

        }
    }
}
