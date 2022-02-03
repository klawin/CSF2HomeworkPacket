using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //FIELDS
        private string _customerId;
        private string _firstName;
        private string _lastName;
        
        //PROPERTIES
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        public ContactInfo ContactInformation { get;set; }

        //CONSTRUCTORS
        public Customer(string firstName, string lastName, string customerId, ContactInfo contactInformation)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = customerId;
            ContactInformation = contactInformation;
        }
        //METHODS
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\nName: {0}, {1}" +
                "\nCustomer ID: {2}" +
                "\nContact Info: \n{3}", LastName, FirstName, CustomerId, ContactInformation);
        }
        public Customer()
        {

        }

    }//end Customer
}//end namespace
