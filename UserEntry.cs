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
            Regex regex = new Regex(firstname);
            if (regex.IsMatch(fname))
            {
                Console.WriteLine("Your name : " + fname);
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Entered name is not valid!!");
            }
        }
    }
}
