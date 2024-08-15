using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Manager : IEmployee, IManager, ITimeTrackable
    {
        protected string _name { get; set; }
        public Manager(string name)
        {
            _name = name;
        }
        public void Work()
        {
            // Manager-specific work implementation
            Console.WriteLine($"Manager {_name} is working.");
        }

        public void TimeIn()
        {
            // Manager-specific time-in implementation
            Console.WriteLine($"Manager {_name} clocked in.");
        }

        // Implement IManageable
        public void Manage()
        {
            // Manager-specific manage implementation
            Console.WriteLine($"Manager {_name} managed.");
        }
    }
}
