using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Pavel";
            var lastName = "Haikvch";
            var age = 16;
            var p = new Person(lastName, name, age);
            //p.Name = "Pavel";
            //p.SecondName = "Haikvch";
            Console.WriteLine($"Name: {p.Name}.");
            Console.WriteLine($"Second Name: {p.SecondName}.");
            Console.WriteLine($"Age: {p.Age} years old.");
            //Console.WriteLine("Full Name: " + p.FullName);
            //Console.WriteLine("Short Name: " + p.ShortName);
            //Console.ReadKey();

        }
    }
}
