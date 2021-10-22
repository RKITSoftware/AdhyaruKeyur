using System;
using System.Collections;

namespace HashTable
{
    class Student
    {
        Hashtable data = new Hashtable();

        #region Constructor
        public Student(Hashtable studentData)
        {
            this.data = studentData;
        }
        #endregion Constructor

        #region Get Studnet Data
        public Hashtable getStudents()
        {
            return this.data;
        }
        #endregion Get Studnet Data
    }
    class Program
    {
        static void Main(string[] args)
        {
            //hashtable has key and value.
            //below we have created hashtable.
            Hashtable student = new Hashtable();

            //we can add data using add method.
            student.Add(1, "Keyur Adhyaru");
            student.Add(2, "Om Joshi");
            student.Add(3, "Parth Jethani");

            //class object created.
            var objStudent = new Student(student);
            var studentData = objStudent.getStudents();

            foreach (DictionaryEntry i in studentData)
            {
                Console.WriteLine("Key is - {0} And Value is - {1}", i.Key, i.Value);
            }
            //Note : DictonaryEntry: is a class whose object represents the data in a combination of key & value pairs.
        }
    }
}
