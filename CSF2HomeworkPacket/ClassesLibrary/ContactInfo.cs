using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        //FIELDS
        private string _streetAddress, _city, _state, _zip, _phone, _email;
        //PROPERTIES
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        //CONSTRUCTORS
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public ContactInfo()
        {

        }

        //METHOD
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\nStreet Address: {0}" +
                "\nCity: {1}" +
                "\nState: {2}" +
                "\nZip: {3}" +
                "\nPhone: {4}" +
                "\nE-Mail: {5}", StreetAddress, City, State, Zip, Phone, Email);
        }

    }//end ContactInfo
}//end namespace
