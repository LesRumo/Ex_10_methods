using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //methods
            SayHi();

            //method with parameters
            SayHiUser("Lee");

            //method with more parameters
            SayHiAge("Les", 567);

            Console.ReadLine();
        }

        //creating a method
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        //Method with one parameter
        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // method with many parameters
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
    
}
