using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserEntry
    {
        public void ValidationOfData()
        {
            //first name validation
            Console.Write("Please Enter First Name:");
            var fname = Console.ReadLine();
            string firstname = "^[A-Z]{1}[a-z]{2,}$";

            Regex regex1 = new Regex(firstname);
            if (regex1.IsMatch(fname))
            {
                Console.WriteLine("Your name : " + fname);
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Entered name is not valid!!");
            }
            //last name validation
            Console.Write("Please Enter Last Name:");
            var lname = Console.ReadLine();
            string lastname = "^[A-Z]{1}[a-z]{2,}$";

            Regex regex2 = new Regex(lastname);
            if (regex2.IsMatch(lname))
            {
                Console.WriteLine("Your last name : " + lname);
                Console.WriteLine("Last name is valid");
            }
            else
            {
                Console.WriteLine("Entered last name is not valid!!");
            }
            //email validation
            Console.Write("Please Enter a Valid Email Id: ");
            var email = Console.ReadLine();
            string mailid = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex regex3 = new Regex(mailid);
            if (regex3.IsMatch(email))
            {
                Console.WriteLine("Your mail Id : " + email);
                Console.WriteLine("Mail Id is valid");
            }
            else
            {
                Console.WriteLine("Entered Email Id is not valid!!");
            }
            //Mobile number validation
            Console.Write("Enter Mobile number with country code: ");
            var phonenum = Console.ReadLine();
            string phonenumber = "^[91]{2}[\\s][0-9]{10}$";
            Regex regex4 = new Regex(phonenumber);
            if (regex4.IsMatch(phonenum))
            {
                Console.WriteLine("Mobile number is valid");
            }
            else
            {
                Console.WriteLine("Mobile number is Invalid!!");
            }

            //Password validation
            Console.Write("Set your password: ");
            var password = Console.ReadLine();
            string password_reg = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$";
            Regex regex5 = new Regex(password_reg);
            if (regex5.IsMatch(password))
            {
                Console.WriteLine("your password is valid");
            }
            else
            {
                Console.WriteLine("password is Invalid!! try another one");
            }

        }
    }
}
