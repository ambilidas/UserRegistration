using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidateForMSTest
    {
        public ValidateForMSTest()
        {
            //default constructor
        }
        public string message;
        public string firstname = "^[A-Z]{1}[a-z]{2,}$";
        string lastname = "^[A-Z]{1}[a-z]{2,}$";
        string mailid = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        string phonenumber = "^[91]{2}[\\s][0-9]{10}$";
        string password_reg = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$";

        public ValidateForMSTest(string message)
        {
            this.message = message;
        }
        public string FirstName(string message)
        {
            Console.Write("Please Enter First Name:");
            var fname = Console.ReadLine();
            Regex regex1 = new Regex(firstname);
            if (regex1.IsMatch(fname))
            {
                return fname;
                
            }
            else
            {
                return null;
            }
        }
        public string LastName(string message)
        {
            Console.Write("Please Enter Last Name:");
            var lname = Console.ReadLine();
            Regex regex2 = new Regex(lastname);
            if (regex2.IsMatch(lname))
            {
                return lname;

            }
            else
            {
                return null;
            }
        }
        public string MailId(string message)
        {
            Console.Write("Please Enter mail id:");
            var email = Console.ReadLine();
            Regex regex3 = new Regex(mailid);
            if (regex3.IsMatch(email))
            {
                return email;

            }
            else
            {
                return null;
            }
        }
        public string PhoneNumber(string message)
        {
            Console.Write("Please Enter phone number:");
            var phonenum = Console.ReadLine();
            Regex regex4 = new Regex(phonenumber);
            if (regex4.IsMatch(phonenum))
            {
                return phonenum;

            }
            else
            {
                return null;
            }
        }
        public string PassWord(string message)
        {
            Console.Write("Please Enter password:");
            var password = Console.ReadLine();
            Regex regex4 = new Regex(password_reg);
            if (regex4.IsMatch(password))
            {
                return password;

            }
            else
            {
                return null;
            }
        }

    }
}
