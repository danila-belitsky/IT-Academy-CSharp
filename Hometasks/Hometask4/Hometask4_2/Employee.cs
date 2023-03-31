namespace Hometask4.Hometask4_2
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        private int _age;
        private string _position;
        private int _salary;

        public string Name => _name;
        public string Surname => _surname;
        public int Age
        { 
            get => _age;
            set
            {
                if (value > 0 && value < 120)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Incorrect value!");
                }
            }
        }

        public string Position { get => _position; set => _position = value; }
        public int Salary { get => _salary; set => _salary = value; }


        public Employee(string name, string surname, int age, string position, int salary)
        {
            _name = name;
            _surname = surname;
            Age = age;
            _position = position;
            _salary = salary;
        }
    }
}
