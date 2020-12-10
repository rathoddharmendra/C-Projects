using System;
using System.IO;

namespace MoshHamedaniProjects
{
    class Program
    {

        static void Main(string[] args)
        {
            var datetime = new DateTime(2020, 12, 11);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Second: " + now.Second);

            now.AddMinutes(2.2);
            Console.WriteLine("Minute: " + now.Minute);
            now.AddDays(-1);
            Console.WriteLine(now);
        }
    }
}
