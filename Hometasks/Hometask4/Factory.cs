﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    public class Factory
    {
        private List<Employee> _employees;

        public Factory()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee()
        {
            string name = GetString("Enter the employee's name: ");

            string position = GetString("Enter the employee's position: ");

            int salary = GetInt("Enter the employee's salary: ");

            Employee employee = new Employee(name, position, salary);

            _employees.Add(employee);

            Console.WriteLine("\nSuccessfully added. Press any button to continue...\n");
            Console.ReadKey();
        }

        public void RemoveEmployee()
        {
            _employees.RemoveAt(ChooseEmployeeNumber());

            Console.WriteLine("\nSuccessfully removed. Press any button to continue...\n");
            Console.ReadKey();
        }

        public int ChooseEmployeeNumber()
        {
            ShowListOfEmployees();

            int index;

            while (true)
            {
                index = GetInt("Enter the employee number: ");

                if (index <= 0 || index > _employees.Count)
                {
                    Console.WriteLine("Incorrect number!");
                }
                else
                {
                    break;
                }
            }

            return index - 1;
        }

        public void ShowListOfEmployees()
        {
            Console.WriteLine("List of employees:\n");

            for (int i = 0; i < _employees.Count; i++)
            {
                Console.WriteLine($"  {i + 1} | {_employees[i].Name, -20} | {_employees[i].Position, -20} | {_employees[i].Salary, -10} $");
            }
            Console.WriteLine("\n");
        }

        public void ChangeEmployeeSalary()
        {
            Employee employee = _employees[ChooseEmployeeNumber()];

            employee.Salary = GetInt("Enter the new salary: ");

            Console.WriteLine("\nSuccessfully changed. Press any button to continue...\n");
            Console.ReadKey();
        }

        public void ChangeEmployeePosition()
        {
            Employee employee = _employees[ChooseEmployeeNumber()];

            employee.Position = GetString("Enter the new position: ");

            Console.WriteLine("\nSuccessfully changed. Press any button to continue...\n");
            Console.ReadKey();
        }

        public static int GetInt(string message)
        {
            int num;
            string? input;

            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!int.TryParse(input, out num))
                {
                    Console.WriteLine("Input error!\n");
                }
                else if (num < 0)
                {
                    Console.WriteLine("Cannot be less than zero!\n");
                }
                else
                {
                    break;
                }
            }

            return num;
        }

        public static string GetString(string message)
        {
            string? input;

            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input error!\n");
                }
                else
                {
                    break;
                }
            }

            return input;
        }
    }
}
