namespace Hometask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task6();
            //Console.WriteLine(ExtraTask(263));
        }

        public static void Task1()
        {
            Console.Write("Введите значение bool: ");
            bool _bool = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Введите значение byte: ");
            byte _byte = Convert.ToByte(Console.ReadLine());

            Console.Write("Введите значение sbyte: ");
            sbyte _sbyte = Convert.ToSByte(Console.ReadLine());

            Console.Write("Введите значение char: ");
            char _char = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите значение decimal: ");
            decimal _decimal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите значение double: ");
            double _double = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение float: ");
            float _float = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите значение int: ");
            int _int = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение uint: ");
            uint _uint = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите значение long: ");
            long _long = Convert.ToInt64(Console.ReadLine());

            Console.Write("Введите значение ulong: ");
            ulong _ulong = Convert.ToUInt64(Console.ReadLine());

            Console.Write("Введите значение short: ");
            short _short = Convert.ToInt16(Console.ReadLine());

            Console.Write("Введите значение ushort: ");
            ushort _ushort = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Введите значение для object: ");
            object _object = Console.ReadLine();

            Console.Write("Введите значение string: ");
            string _string = Console.ReadLine();

            Console.Clear();

            List<object> list = new List<object>() { _bool, _byte, _sbyte, _char, _decimal, _double, _float, _int, _long, _ulong, _short, _ushort, _object, _string };

            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType(),15} = {item,5}");
            }
        }
        
        public static void Task2()
        {
            sbyte _sbyte = 5;

            // Implicit conversion

            short _short = _sbyte;
            int _int = _short;
            long _long = _int;
            float _float = _long;
            double _double = _float;

            // Explicit conversion

            _float = (float)_double;
            _long = (long)_float;
            _int = (int)_long;
            _short = (short)_int;
            _sbyte = (sbyte)_short;

        }
    
        public static void Task3()
        {
            int num = 1;

            object obj = num;   // Boxing
            num = (int)obj;     // Unboxing

        }
    
        public static void Task4()
        {
            var a = 1;
            a++;
            Console.WriteLine(a);
        }

        public static void Task5()
        {
            var a = 1;
            //a = "a";
            // Переменной при объявлении неявно задаётся тип "int", а переменной этого типа нельзя присвоить значение типа "string"
        }
    
        public static void Task6()
        {
            Console.WriteLine("\tИнгридиенты:");
            Console.WriteLine("500 гр.риса, 750 мл.воды,");
            Console.WriteLine("5 - 6 листов нори, соевый соус");
            Console.WriteLine("70 мл.рисового уксуса,");
            Console.WriteLine("3 ст.ложки сахара, 1 ст.ложка соли");
            Console.WriteLine("250 гр.рыбы(семга или тунец)");
            Console.WriteLine("1 огурец, сыр, крабовые палочки, креветки");

            Console.WriteLine("\nВ первую очередь нужно сварить 500г риса.");

            int rice;
            
            while (true)
            {
                Console.Write("\nСколько грамм риса у вас есть? ");
                rice = Convert.ToInt32(Console.ReadLine());
                
                if (rice < 500)
                {
                    Console.WriteLine("Этого мало, нужно хотя бы 500г. Купите ещё.");
                }
                else
                {
                    Console.WriteLine("Хорошо, сварим 500г риса");
                    break;
                }
            }

            Console.WriteLine("Разложим лист нори, покроем его рисом.");
            Console.WriteLine("Теперь добавим остальные ингридиенты.");

            Console.WriteLine("У вас есть сыр?");
            
            if (Console.ReadLine().ToLower() == "да")
            {
                Console.WriteLine("Нарезаем сыр и кладём на рис.");
            }
            else
            {
                Console.WriteLine("Тогда без сыра.");
            }

            Console.WriteLine("У вас есть авокадо?");

            if (Console.ReadLine().ToLower() == "да")
            {
                Console.WriteLine("Отрезаем немного и добавляем.");
            }
            else
            {
                Console.WriteLine("Может быть у вас есть огурец?");
                if (Console.ReadLine().ToLower() == "да")
                {
                    Console.WriteLine("Отрезаем немного и добавляем.");
                }
                else
                {
                    Console.WriteLine("В таком случае слудующий шаг.");
                }
            }

            Console.WriteLine("Сворачиваем в ролл, нарезаем и выкладываем.");
        }

        public static string ExtraTask(int cm) 
        {
            int result = cm / 100;

            return "Кол-во целых метров: " + result.ToString();
        }
    }
}