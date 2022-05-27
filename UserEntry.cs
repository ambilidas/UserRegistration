using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class UserEntry
    {
        public void ValidationOfData()
        {
            Console.Write("Please Enter First Name:");
            var fname=Console.ReadLine();
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
        }
    }
}
