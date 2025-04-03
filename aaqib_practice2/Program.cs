using System;

namespace aaqib_practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //String fullName = "aaqib ahmed";
            //String phoneNumber = "12 345 6";
            //fullname=fullname.ToUpper();
            //fullname = fullname.ToLower()
            //;            Console.WriteLine(fullname);
            //phoneNumber = phoneNumber.Replace(" ", "-");
            //Console.WriteLine(phoneNumber);
            //String username = fullname.Insert(11, " khan");
            //Console.WriteLine(username);

            //Console.WriteLine(fullName.Length);
            //Console.WriteLine("enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if(age>=18)
            //{
            //    Console.WriteLine("you are eligible to vote");

            //}
            //else
            //{
            //    Console.WriteLine("you are inelegible to vote");
            //}
            string name = "aaqib";
            greet(name);
            greet(name);
            Console.ReadKey();

        }
        static void greet(String name)
        {
            Console.WriteLine("hey " + name + " how are you");
        }
    }
}
