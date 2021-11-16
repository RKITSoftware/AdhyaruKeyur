using System;

namespace ExplicitInterface
{
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    class FileInfo : IFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        //we cann't use public in explicit Interface
        void IFile.WriteFile(string name)
        {
            Console.WriteLine("Writing to file " + name);
        }

        public void printResult(String result)
        {
            Console.WriteLine(result + "\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFile objfile = new FileInfo();
            FileInfo objfileInfo = new FileInfo();

            //objfile.printResult("Explicit Interface Demo")//compile-time error 
            objfileInfo.printResult("Explicit Interface Demo");
            objfile.ReadFile();
            objfile.WriteFile("mydemo.txt");
        }
    }
}
