using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDependencyObject.Model
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public static Person[] GetPersons()
        {
            Person[] people = new Person[]
            {
                new Person() {LastName = "Иванов", FirstName = "Иван"},
                new Person() {LastName = "Джекман", FirstName = "Хью"},
                new Person() {LastName = "Сидоров", FirstName = "Сидор"}
            };
            return people;
        }
    }
}
