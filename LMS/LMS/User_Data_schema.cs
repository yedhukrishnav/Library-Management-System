using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS
{
    public class User_Data_schema
    {
        private int _userId;
        private string _fullName;
        private string _accountType;
        private string _phoneNumber;
        private string _email;
        private int _age;
        private string _password;
        private string _accountStatus;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string AccountStatus
        {
            get { return _accountStatus; }
            set { _accountStatus = value; }
        }
    }
}