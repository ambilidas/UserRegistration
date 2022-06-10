using System;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to User Registration Program");
            //UserEntry userEntryobj = new UserEntry();
            //userEntryobj.ValidationOfData();
            //ValidateForMSTest obj=new ValidateForMSTest();
            //Console.WriteLine(obj.FirstName("Athul"));

            UserRegistrationFactory userRegistrationFactoryobj=new UserRegistrationFactory();
            Console.WriteLine(userRegistrationFactoryobj.CreateUserRegistration("CustomExceptions", "CustomExceptions")); 
            Console.ReadKey();
        }
    }
}
