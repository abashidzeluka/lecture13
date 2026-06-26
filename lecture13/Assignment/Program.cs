using Assignment.Helpers;
using Assignment.Models;
using Assignment.Services;
using System.Threading.Channels;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentManagerService stServ = new StudentManagerService();

            

            foreach (var item in stServ.students)
            {
                Console.WriteLine(item);
            }


            string chooser = "1";
            while (chooser != "8")
            {
                Console.WriteLine("\n--- menu ---");

                Console.WriteLine("1.Show all students");

                Console.WriteLine("2.Finding the best student");

                Console.WriteLine("3.Calculating GPA average");

                Console.WriteLine("4.Search for a student by last name");

                Console.WriteLine("5.Sorting students by GPA");

                Console.WriteLine("6.Add a new student");

                Console.WriteLine("7.Delete student");

                Console.WriteLine("8.Exit the program");

                Console.WriteLine();
                Console.Write("Choose a number: ");
                chooser = Console.ReadLine();

                switch (chooser)
                {
                    case "1":
                        stServ.PrintAllStudents();
                        break;
                    case "2":
                        stServ.BestStudent();
                        break;
                    case "3":
                        stServ.AllGPAaverage();
                        break;
                    case "4":
                        stServ.FindByLastName();
                        break;
                    case "5":
                        stServ.SortByGPA();
                        break;
                    case "6":
                        stServ.AddStudent();
                        break;
                    case "7":
                        stServ.DeleteStudnet();
                        break;
                    case "8":
                        Console.WriteLine("The application is complete!");
                        break;
                    default: Console.WriteLine("Invalid choose!"); break;
                }
            }



        }
    }
}
