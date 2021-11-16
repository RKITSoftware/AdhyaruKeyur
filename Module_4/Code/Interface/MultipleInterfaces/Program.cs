using System;

namespace MultipleInterfaces
{
    interface IFile
    {
        void ReadFile();
    }

    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }

    class FileInfo : IFile, IBinaryFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }

        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File");
        }

        public void printResut(string text)
        {
            Console.WriteLine(text + "\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFile objfile = new FileInfo();
            IBinaryFile objBinaryFile = new FileInfo();
            FileInfo objFileInfo = new FileInfo();

            objFileInfo.printResut("Multiple Interface Demo");

            objfile.ReadFile();
            //objfile.OpenBinaryFile(); //compile-time error 
            //objfile.printResut("Demo"); //compile-time error 

            objBinaryFile.OpenBinaryFile();
            objBinaryFile.ReadFile();

            //objBinaryFile.printResut("Demo"); //compile-time error 
            //objFileInfo.ReadFile(); //compile-time error 
            //objFileInfo.OpenBinaryFile(); //compile-time error 
        }
    }
}
