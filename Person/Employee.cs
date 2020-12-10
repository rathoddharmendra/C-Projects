using System;

namespace MoshHamedaniProjects.Person
{
    public class Employee
    {
        public Employee()
        {

        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello! How are you doing today {FirstName} {SecondName}");
        }
    }
}
