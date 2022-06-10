using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegistrationFactory
    {
        public object CreateUserRegistration(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(pattern, className);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type userRegistrationType = executing.GetType(className);
                    return Activator.CreateInstance(userRegistrationType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.NO_SUCH_METHOD, "constructor not found");
            }
        }
    }


    public class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            Null_Message, Empty_Message, NO_SUCH_CLASS, NO_SUCH_METHOD,INVALID_ENTRY
        }
        //creating variable Type of ExceptionType
        ExceptionType type;

        public CustomExceptions(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
        public string ValidationFirstName()
        {
            try
            {
                //first name validation
                Console.Write("Please Enter First Name:");
                var fname = Console.ReadLine();
                string firstname = "^[A-Z]{1}[a-z]{2,}$";

                Regex regex1 = new Regex(firstname);
                if (regex1.IsMatch(fname))
                {
                    return fname;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_ENTRY, "first name is not valid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.Null_Message, "first name not be Null");

            }
        }
        public string ValidationLastName()
        {
            try
            {
                //last name validation
                Console.Write("Please Enter Last Name:");
                var lname = Console.ReadLine();
                string lastname = "^[A-Z]{1}[a-z]{2,}$";

                Regex regex2 = new Regex(lastname);
                if (regex2.IsMatch(lname))
                {
                    return lname;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_ENTRY, "last name is not valid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.Null_Message, "last name not be Null");

            }
        }
        public string ValidationEmail()
        {
            try
            {
                //email validation
                Console.Write("Please Enter a Valid Email Id: ");
                var email = Console.ReadLine();
                string mailid = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                 @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

                Regex regex3 = new Regex(mailid);
                if (regex3.IsMatch(email))
                {
                    return email;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_ENTRY, "email is not valid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.Null_Message, "email not be Null");
            }
        }
        public string ValidationPhoneNumber()
        {
            try
            {
                //Mobile number validation
                Console.Write("Enter Mobile number with country code: ");
                var phonenum = Console.ReadLine();
                string phonenumber = "^[91]{2}[\\s][0-9]{10}$";
                Regex regex4 = new Regex(phonenumber);
                if (regex4.IsMatch(phonenum))
                {
                    return phonenumber;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_ENTRY, "Phone number is not valid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.Null_Message, "phone number not be Null");
            }
        }
        public string ValidationPassword()
        {
            try
            {
                //Password validation
                Console.Write("Set your password: ");
                var password = Console.ReadLine();
                string password_reg = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$";
                Regex regex5 = new Regex(password_reg);
                if (regex5.IsMatch(password))
                {
                    return password_reg;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_ENTRY, "Password is not valid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.Null_Message, "password not be Null");
            }
        }
    }
}