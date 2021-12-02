using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationDemo
{
    [Serializable]
    public class Users
    {
        private string Name;

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        private string City;

        public string city
        {
            get
            {
                return City;
            }

            set
            {
                City = value;
            }
        }
    }
}
