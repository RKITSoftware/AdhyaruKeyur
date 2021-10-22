using System;
using System.Collections;

namespace QueueDemo
{
    class Student
    {
        Queue data = new Queue();

        #region Constructor
        public Student(Queue studentData)
        {
            this.data = studentData;
        }
        #endregion Constructor

        #region Get Studnet Data
        public Queue getStudents()
        {
            return this.data;
        }
        #endregion Get Studnet Data

        #region Check String available
        public Boolean isContains(string data)
        {
            //return true or false if queue has the string.
            return this.data.Contains(data);
        }
        #endregion Check String available
    }

    class Program
    {
        static void Main(string[] args)
        {
            //queue has key and value.
            //below we have created queue.
            Queue student = new Queue();

            //we can add data using add method.
            student.Enqueue("Keyur Adhyaru");
            student.Enqueue("Om Joshi");
            student.Enqueue("Parth Jethani");

            //class object created.
            var objStudent = new Student(student);
            var studentData = objStudent.getStudents();

            foreach (var i in studentData)
            {
                Console.WriteLine("Value is : {0}", i);
            }

            Console.WriteLine("Check the Keyur String is Present or Not : {0}", objStudent.isContains("Keyur Adhyaru"));
        }
    }
}
