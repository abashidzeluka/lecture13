using Assignment.Enums;
using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Models
{
    internal class Student : Person, IPrintable
    {
        private string _email;
        private string _phone;
        private float _gpa;
        private Faculty _faculty;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Email cannot be empty!");
                    return;
                }

                _email = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Phone cannot be empty!");
                    return;
                }

                _phone = value;
            }
        }

        public float GPA
        {
            get { return _gpa; }
            set
            {
                if (value < 0 || value > 4)
                {
                    Console.WriteLine("GPA must be between 0 and 4");
                    return;
                }

                _gpa = value;
            }
        }
        public Faculty Faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }


        public Student(string name, string lastname, int age, string email, string phone, float gpa, Faculty faculty) : base(name, lastname, age)
        {
            GPA = gpa;
            Faculty = faculty;
            Email = email;
            Phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"Student: {Name} {LastName}, Age: {Age}, Email: {Email}, Phone: {Phone}, GPA: {GPA}, Faculty: {Faculty}");
        }

        public override string? ToString()
        {   
            return $"Student: {Name} {LastName}, Age: {Age}, GPA: {GPA}, Faculty: {Faculty}";
        }

    }
    
}
