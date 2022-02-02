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

            Console.WriteLine("Tester Program");

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

        }//end Main()
    }//end class
}//end namespace
