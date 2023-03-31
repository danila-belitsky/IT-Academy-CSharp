using static Hometask4.Hometask4_2.Methods;

namespace Hometask4.Hometask4_2
{
    public class Factory
    {
        private readonly List<Employee> _employees;

        public Factory()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee()
        {
            string name = GetString("Enter the employee's name: ");
            string surname = GetString("Enter the employee's surname: ");
            int age = GetInt("Enter the employee's age: ");
            string position = GetString("Enter the employee's position: ");
            int salary = GetInt("Enter the employee's salary: ");

            Employee employee = new Employee(name, surname, age, position, salary);

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
            Console.WriteLine($"    | {"Name",-20} | {"Position",-20} | {"Salary",-10}");

            for (int i = 0; i < _employees.Count; i++)
            {
                Console.WriteLine($"  {i + 1} | {_employees[i].Name,-15} | {_employees[i].Surname,-15} | {_employees[i].Age,-2} | {_employees[i].Position,-15} | {_employees[i].Salary,-5} $");
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
    }
}
