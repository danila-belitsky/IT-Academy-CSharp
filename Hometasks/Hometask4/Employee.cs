using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    public class Employee
    {
        private string _name;
        private string _position;
        private int _salary;

        public string Name => _name;
        public string Position { get => _position; set => _position = value; }
        public int Salary { get => _salary; set => _salary = value; }

        public Employee(string name, string position, int salary)
        {
            _name = name;
            _position = position;
            _salary = salary;
        }
    }
}
