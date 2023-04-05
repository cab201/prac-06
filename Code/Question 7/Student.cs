using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Student
    {
        private string name;
        private string id;
        private bool isValid = true;

        public bool IsValid
        {
            get
            {
                return isValid;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set // If the value being assigned has two parts, it is considered valid
            {
                string[] parts = value.Split(" ");
                if (parts.Length < 2)
                {
                    this.name = "Invalid Name";
                    this.isValid = false;
                } else
                {
                    this.name = value;
                }
            }
        }

        // Student ID: start with the character 'n', and must be 10 characters long.
        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                bool startWithN = value[0] == 'n';
                bool validLength = value.Length == 10;
                if (startWithN && validLength)
                {
                    this.id = value;
                } else
                {
                    this.id = "Invalid ID";
                    this.isValid = false;
                }
            }
        }

        public Student(string name, string id)
        {
            Name = name;
            Id = id;
        }


        public void Display()
        {
            Console.WriteLine("{0} has id {1}", name, id);
        }

        //private void SetName(string name)
        //{
        //    // Check if the name has two parts
        //    string[] parts = name.Split(" ");
        //    if (parts.Length < 2)
        //    {
        //        this.name = "Invalid Name";
        //    }
        //    else
        //    {
        //        this.name = name;
        //    }
        //}
    }
}
