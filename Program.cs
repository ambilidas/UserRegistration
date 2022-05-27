using System;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to User Registration Program");
            UserEntry userEntryobj = new UserEntry();
            userEntryobj.ValidationOfData();
            Console.ReadKey();
        }
    }
}
