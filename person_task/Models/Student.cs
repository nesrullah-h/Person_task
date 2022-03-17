using System;
using System.Collections.Generic;
using System.Text;

namespace person_task
{
    class Student:Person
    {
        private int point;
        public int Point 
        { 
            get 
            { 
                return point; 
            } 
            set 
            { 
                if(value>= 0 && value <= 100)
                {
                    point = value; 

                }
            } 
        }
        public Student()
        {

        }
        public Student(int point,string name, string surname, int age):base ( name, surname, age)
        {
            this.point = point;


        }


    }
}
