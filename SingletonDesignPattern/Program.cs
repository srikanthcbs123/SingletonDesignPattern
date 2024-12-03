using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the Employee instance
            Employee singleton1 = Employee.Instance;
            singleton1.DisplayMessage("Hello, World!");

            // Get the Employee instance again
            Employee singleton2 = Employee.Instance;
            singleton2.DisplayMessage("This is the same instance.");

            // Confirm that both references point to the same instance
            Console.WriteLine($"Are both instances equal? {singleton1 == singleton2}");
            Console.ReadKey();
        }
    }
}
