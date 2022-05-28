using System;

namespace Constructors
{
    internal class Person
    {

        public string SecondName { get; protected set; }
        public string Name { get; protected set; }
        public int Age { get; protected set; }

        public Person(string secondName, string name, int age)
        {
            if (age > 0 && age < 150)
            {
                Age = age;
            }
            SecondName = secondName;
            Name = name;
        }



        //public string FullName
        //{
        //    get
        //    {
        //        return SecondName + " " + Name;
        //    }
        //}

        //public string ShortName
        //{
        //    get
        //    {
        //        return $"{SecondName} {Name.Substring(0, 1)}.";
        //    }
        //}
    }
}
