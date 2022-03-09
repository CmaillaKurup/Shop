using System;

namespace Shop
{
    public class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
    }
}