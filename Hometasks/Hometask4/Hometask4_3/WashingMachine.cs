using System.Drawing;

namespace Hometask4.Hometask4_3
{
    public class WashingMachine : Appliance
    {
        private readonly string _instruction = "Put the clothes in.";
        private int _washingTime;

        public int WashingTime
        {
            get => _washingTime;
            set
            {
                if (value > 0 && value >= 60)
                {
                    _washingTime = value;
                }
            }
        }
        public string Instruction { get => _instruction; }

        public override void Launch()
        {
            _isEnabled = true;

            Console.WriteLine(Instruction + "\nPress any button to start...");
            Console.ReadKey();

            for (int i = _washingTime; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Remaining time: {i} minutes");
                Thread.Sleep(50);
            }

            Console.WriteLine("The washing machine has finished washing clothes.");
        }

        public override void Shutdown()
        {
            _isEnabled = false;
            Console.WriteLine("The washing machine turned OFF.");
        }

        public WashingMachine(string model)
            : base(model)
        {
        }
    }
}