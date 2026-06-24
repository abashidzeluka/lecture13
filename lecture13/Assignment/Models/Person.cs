using System;

namespace Assignment.Models
{
    internal abstract class Person
    {
        private string _name;
        private string _lastname;
        private int _age;
        

        public Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }

        public string Name
        {
            get 
            { 
                return _name;
            }
            set 
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty!");
                    return;
                }

                _name = value;
            }
        }

        public string LastName
        {
            get 
            { 
                return _lastname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Lastname cannot be empty!");
                    return;
                }

                _lastname = value;
            }
        }

        public int Age
        {
            get 
            { 
                return _age;
            }
            set
            {
                if (value < 18 || value > 100)
                {
                    throw new ArgumentException("Age must be more than 0 and less than 100");
                }
                
                _age = value;
            }
        }

        

    }
}
