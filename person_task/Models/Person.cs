using System;
using System.Collections.Generic;
using System.Text;

namespace person_task
{
    class Person
    {
        private string name;
        private string surname;
        private int age;
        public string Name 
        {
            get
            {
                return name;
            }
            set 
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    name = value;
                }
                else
                {
                    name="bele olmaz"; 

                }
            }

        }
        public string Surname 
        {
            get 
            {
                return surname;
            }
            set 
            {
                if (value.Length >= 3 && value.Length <= 35)
                {
                    surname = value;

                }
                else
                {
                    surname="bele olmaz";

                }
            } 
        }
        public int Age 
        {
            get 
            { 
                return age;
            }
            set 
            {
                if (value > 0)
                {
                    age = value;

                }
                else
                {
                    Console.WriteLine("Yas menfi olmaz");

                }
            } 
        }

        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name:{name}\nSurname:{surname}\nAge:{age}");
        }


    }
}
