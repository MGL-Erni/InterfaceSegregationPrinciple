using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Admin : IEmployee, IAdmin, ITimeTrackable
    {
        protected string _name { get; set; }
        public Admin(string name)
        {
            _name = name;
        }
        public void Work()
        {
            // Admin-specific work implementation
            Console.WriteLine($"Admin {_name} is working.");
        }

        public void TimeIn()
        {
            // Admin-specific time-in implementation
            Console.WriteLine($"Admin {_name} clocked in.");
        }

        public void DeleteUser()
        {
            // Admin-specific delete user implementation
            Console.WriteLine($"Admin {_name} deleted a user.");
        }
    }
}
