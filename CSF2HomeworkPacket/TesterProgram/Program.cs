using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tester Program";

            Console.WriteLine("Students");

            Student s1 = new Student();
            s1.FirstName = "Kayla";
            s1.LastName = "Nguyen";
            s1.Id = "12345";
            s1.Gpa = 4.0f;

            Console.WriteLine("\nStudent: {0}, {1}\n" +
                "ID: {2}\n" +
                "GPA: {3:n1}", s1.LastName, s1.FirstName, s1.Id, s1.Gpa);

            Student s2 = new Student("Quentin", "Carter", "54321", 3.8f);
            Console.WriteLine(s2);

            Console.WriteLine("\nVehicles");

            Vehicle v1 = new Vehicle();
            v1.Make = "Honda";
            v1.Model = "CR-V";
            v1.Year = 2011;
            v1.Weight = 3000;

            Console.WriteLine("\nMake: {0}" +
                "\nModel: {1}" +
                "\nYear: {2}" +
                "\nWeight: {3} lbs", v1.Make, v1.Model, v1.Year, v1.Weight);

            Vehicle v2 = new Vehicle("Chevrolet", "Cruze", 2013, 2800f);
            Console.WriteLine(v2);

            Console.WriteLine("\nLogin");

            Login l1 = new Login();
            l1.UserName = "student";
            l1.Password = "password";

            Console.WriteLine("\nUsername: {0}" +
                "\nPassword: {1}", l1.UserName, l1.Password);

            Login l2 = new Login("Student","Password");
            Console.WriteLine(l2);

        }//end Main()
    }//end class
}//end namespace
