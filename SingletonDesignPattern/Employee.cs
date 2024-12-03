using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Employee
    {
        // Static variable to hold the single instance
        private static Employee _instance = null;

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Private constructor to prevent external instantiation
        private Employee()
        {
            Console.WriteLine("Singleton Instance Created!");
        }

        // Public method to provide global access to the instance
        public static Employee Instance
        {
            get
            {
                // Double-checked locking for thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Employee();
                        }
                    }
                }
                return _instance;
            }
        }

        // Example method
        public void DisplayMessage(string message)
        {
            Console.WriteLine($"Message from Singleton: {message}");
        }
    }
}
