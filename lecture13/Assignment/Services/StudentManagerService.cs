using Assignment.Enums;
using Assignment.Helpers;
using Assignment.Models;
using System;


namespace Assignment.Services
{
    internal class StudentManagerService
    {

        public StudentManagerService()
        {
            FillData();
        }


        public Student[] students = new Student[0];

        private void FillData() 
        {
            ArrayHelper.Add(ref students, new Student("John", "Doe", 20, "john.doe@email.com", "555456265", 3.8f, Faculty.IT));
            ArrayHelper.Add(ref students, new Student("Jane", "Smith", 21, "jane.smith@email.com", "577123456", 3.9f, Faculty.Medicine));
            ArrayHelper.Add(ref students, new Student("Michael", "Johnson", 22, "mike.j@email.com", "599987654", 3.2f, Faculty.Business));
            ArrayHelper.Add(ref students, new Student("Emily", "Davis", 19, "emily.d@email.com", "551234567", 3.5f, Faculty.Design));
            ArrayHelper.Add(ref students, new Student("David", "Brown", 23, "david.b@email.com", "593112233", 2.8f, Faculty.IT));
            ArrayHelper.Add(ref students, new Student("Sarah", "Miller", 20, "sarah.m@email.com", "555998877", 4.0f, Faculty.Medicine));
            ArrayHelper.Add(ref students, new Student("James", "Wilson", 21, "james.w@email.com", "574554433", 3.1f, Faculty.Business));
            ArrayHelper.Add(ref students, new Student("Anna", "Taylor", 22, "anna.t@email.com", "591667788", 3.7f, Faculty.Design));
            ArrayHelper.Add(ref students, new Student("Robert", "Anderson", 20, "robert.a@email.com", "558334455", 3.4f, Faculty.IT));
            ArrayHelper.Add(ref students, new Student("Linda", "Thomas", 19, "linda.t@email.com", "595001122", 3.6f, Faculty.Medicine));
        }

        public void PrintAllStudents()
        {
            foreach (var student in students)
            {
                student.Print();
            }
        }

        public void BestStudent()
        {
            Student best = students[0];
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GPA > best.GPA)
                {
                    best = students[i];
                }
                
            }
            Console.WriteLine("The best student is: ");
            best.Print();
        }

        public void AllGPAaverage()
        {
            float sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].GPA;
            }

            float average = sum / students.Length;
            Console.WriteLine("Average GPA: " + average);
        }

        public void FindByLastName()
        {
            Console.Write("Enter last name: ");
            string find = Console.ReadLine().ToLower().Trim();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].LastName.ToLower().Contains(find))
                {
                    students[i].Print();
                }
            }
        }

        public void SortByGPA()
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1 - i; j++)
                {
                    if (students[j].GPA < students[j + 1].GPA)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }

            // print sorted students
            foreach (var student in students)
            {
                student.Print();
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                if (age <= 16)
                {
                    Console.WriteLine("Age must be greater than 16");
                    return;
                }

                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                if (!email.Contains("@"))
                {
                    Console.WriteLine("Invalid email, must contain @");
                    return;
                }

                Console.Write("Enter phone: ");
                string phone = Console.ReadLine();

                Console.Write("Enter GPA: ");
                float gpa = float.Parse(Console.ReadLine());

                if (gpa < 0 || gpa > 4.0f)
                {
                    Console.WriteLine("GPA must be between 0 and 4.0");
                    return;
                }

                Console.Write("Enter faculty (IT, Business, Design, Medicine): ");
                Faculty faculty = Enum.Parse<Faculty>(Console.ReadLine(), true);

                ArrayHelper.Add(ref students, new Student(name, lastName, age, email, phone, gpa, faculty));
                Console.WriteLine("Student added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.Message);
            }

        }

        public void DeleteStudnet()
        {
            Console.Write("Enter student email to delete: ");
            string email = Console.ReadLine();
            if(!email.Contains("@"))
            {
                Console.WriteLine("Email must contain @, try again");
                return;
            }

            for (int i = 0; i < students.Length; i++)
            {
                if (email == students[i].Email)
                {
                    ArrayHelper.Remove(ref students, i);
                    Console.WriteLine("Student deleted successfully!");
                    return;
                }
            }
            Console.WriteLine("Student with that email not found.");


        }
    }
}
