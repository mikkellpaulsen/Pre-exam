using System;

namespace func_action_linq
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string v1, string v2)
        {
            title = v1;
            name = v2;
        }

        public string title { get; set; }
        public string name { get; set; }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void write(string message)
        {
            Console.WriteLine(message + "Employee Kaldt gennem Delegate.");
        }
    }
}