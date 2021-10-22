using System;
using System.Collections;

namespace StackDemo
{
    //generic Collection : Stack.
    class Addition
    {
        Stack numList = new Stack();

        #region Constructor
        public Addition(Stack numberList)
        {
            this.numList = numberList;
        }
        #endregion Constructor

        #region Add All Numbers Given in the Stack.
        public int sum()
        {
            var ans = 0;
            foreach (object i in numList)
            {
                ans += Convert.ToInt32(i);
            }
            return ans;
        }
        #endregion Add All Numbers Given in the Stack.
    }
    class Program
    {
        static void Main(string[] args)
        {
            //define stack object.
            Stack numbers = new Stack();

            //push method is used to add the item in the stack.
            numbers.Push(10);
            numbers.Push(40);
            numbers.Push(20);
            numbers.Push(30);

            //object Created.
            var objAddition = new Addition(numbers);
            Console.WriteLine("Sum of All Numbers is : {0}", objAddition.sum());
        }
    }
}
