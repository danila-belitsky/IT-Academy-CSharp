namespace Hometask4.Hometask4_3
{
    public class DishwashMachine : Appliance
    {
        private int _dishAmount;
        private int _currentMode = 0;

        public int CurrentMode { get => CurrentMode; }
        public int DishAmount
        {
            get => _dishAmount;
            set
            {
                if (value > 0)
                {
                    _dishAmount = value;
                }
            }
        }

        public override void Launch()
        {
            _isEnabled = true;

            Console.WriteLine("The dishwasher is ready to work.\nPress any button to start...");
            Console.ReadKey();

            for (int i = 1; i < 5; i++)
            {
                _currentMode = i;
                Console.WriteLine($"Washing mode: {_currentMode}");
                Thread.Sleep(100);
            }

            Console.WriteLine("The dishwasher has finished washing the dishes.");
        }

        public override void Shutdown()
        {
            _isEnabled = false;
            _currentMode = 0;

            Console.WriteLine("The dishwasher turned OFF.\n");
        }

        public DishwashMachine(string model, int currentMode)
            : base(model)
        {
            _currentMode = currentMode;
        }
    }
}
