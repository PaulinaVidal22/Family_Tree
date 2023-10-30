using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public int Age {get;set;}
        public string Name {get;set;}
        public string Gender {get; set;}

        public Person (int age, string name, string gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
