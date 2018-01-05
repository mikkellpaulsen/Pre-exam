using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static func_action_linq.Manager;

namespace func_action_linq
{
    public delegate void NotifyEmployeeHandler(string type);
    public class Manager
    {
        public List<Employee> emplooyes = new List<Employee>();
        public string Name { get; set; }

        public event NotifyEmployeeHandler ShiftNotify;

        public void write(string message)
        {
            Console.WriteLine(message + "Manager Kaldt gennem Delegate.");
           
        }
    }
}
