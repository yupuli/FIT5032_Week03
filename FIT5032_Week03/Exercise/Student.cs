using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week03.Exercise
{
    public class Student
    {
        public string Name
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        }
        public Student(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public class ExampleDictionary
        {
            public void Example()
            {
                Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
                Student s1 = new Student("James", "0426568971");
                Student s2 = new Student("Karsa", "0426531785");

                studentDictionary.Add(1, s1);
                studentDictionary.Add(2, s2);

                Student result = new Student("", "");

                studentDictionary.TryGetValue(1, out result);
            }
        }
    }
}