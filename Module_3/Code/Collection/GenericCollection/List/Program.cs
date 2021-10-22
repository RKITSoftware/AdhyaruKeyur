using System;
using System.Collections.Generic;

namespace List
{
    //generic Collection : List.
    class Addition
    {
        List<int> numList = new List<int>();

        #region Constructor
        public Addition(List<int> numberList)
        {
            this.numList = numberList;
        }
        #endregion Constructor

        #region Add All Numbers Given in the List.
        public int sum()
        {
            var ans = 0;
            foreach(var i in numList)
            {
                ans += i;
            }
            return ans;
        }
        #endregion Add All Numbers Given in the List.
    }
    class Program
    {
        static void Main(string[] args)
        {
            //define list object.
            List<int> numbers = new List<int>();

            //add items to list
            numbers.Add(10);
            numbers.Add(40);
            numbers.Add(20);
            numbers.Add(30);

            //object Created.
            var objAddition = new Addition(numbers);
            Console.WriteLine("Sum of All Numbers is : {0}", objAddition.sum());
        }
    }
}
