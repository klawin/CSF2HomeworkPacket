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

            Console.WriteLine("STUDENTS");

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

            Console.WriteLine("\nVEHICLES");

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


            Console.WriteLine("\nCONTACT INFORMATION");

            ContactInfo ci1 = new ContactInfo();
            ci1.StreetAddress = "700 E 4th St";
            ci1.City = "Kansas City";
            ci1.State = "MO";
            ci1.Zip = "64106";
            ci1.Phone = "8167995001";
            ci1.Email = "kaylannguyen@outlook.com";

            Console.WriteLine("\nStreet Address: {0}" +
                "\nCity: {1}" +
                "\nState: {2}" +
                "\nZip: {3}" +
                "\nPhone: {4}" +
                "\nE-Mail: {5}", ci1.StreetAddress, ci1.City, ci1.State, ci1.Zip, ci1.Phone, ci1.Email);

            ContactInfo ci2 = new ContactInfo("6442 E 13th St", "Kansas City", "MO", "64126", "8167995001", "kaninn0106@gmail.com");
            Console.WriteLine(ci2);

            Console.WriteLine("\nCUSTOMER");

            Customer c1 = new Customer();
            c1.FirstName = "Kayla";
            c1.LastName = "Nguyen";
            c1.CustomerId = "12345";
            c1.ContactInformation = ci1;

            Console.WriteLine("\nName: {0}, {1}" +
                "\nCustomer ID: {2}" +
                "\nContact Info: \n{3}",c1.LastName, c1.FirstName, c1.CustomerId, c1.ContactInformation);

            Customer c2 = new Customer("Quentin", "Carter", "56132", ci2);
            Console.WriteLine(c2);

            Console.WriteLine("\nCREDIT CARD ACCOUNT");

            CreditCardAccount cc1 = new CreditCardAccount();
            cc1.AccountNumber = 1234567;
            cc1.Balance = 5000;
            cc1.AnnualInterestRate = 5;
            cc1.IsPastDue = false;
            cc1.CustomerInfo = c1;

            Console.WriteLine("\nCustomer Info: {0}" +
                "\nAccount Number: {1}" +
                "\nBalance: {2:c}" +
                "\nAnnual Interest Rate: {3}%" +
                "\nPast Due?: {4}", cc1.CustomerInfo, cc1.AccountNumber, cc1.Balance, cc1.AnnualInterestRate, cc1.IsPastDue ? "YES" : "NO");

            CreditCardAccount cc2 = new CreditCardAccount(c2, 7654321, -2.99m, 5, true);
            Console.WriteLine(cc2);

            Console.WriteLine("\nBOOK");

            Book b1 = new Book();
            b1.Title = "The Cellar";
            b1.Author = "Natasha Preston";
            b1.NumberOfPages = 368;

            Console.WriteLine("\nTitle: {0}\n" +
                "Author: {1}\n" +
                "Number of pages: {2}\n", b1.Title, b1.Author, b1.NumberOfPages);

            Book b2 = new Book("The Summer I Turned Pretty", "Jenny Han", 304);
            Console.WriteLine(b2);

        }//end Main()
    }//end class
}//end namespace
