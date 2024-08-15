using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Employee : IEmployee, ITimeTrackable
    {
        protected string _name {  get; set; }
        public Employee(string name)
        {
            _name = name;
        }
        public void Work()
        {
            // Employee-specific work implementation
            Console.WriteLine($"Employee {_name} is working.");
        }

        public void TimeIn()
        {
            // Employee-specific time-in implementation
            Console.WriteLine($"Employee {_name} clocked in.");
        }
    }
}
