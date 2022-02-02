using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //FIELDS
        private string _userName;
        private string _password;

        //PROPERTIES
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //CONSTRUCTORS
        public Login(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public Login()
        {

        }

        //METHOD
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\nUsername: {0}" +
                "\nPassword: {1}", UserName, Password);
        }

    }//end Login
}//end namespace
