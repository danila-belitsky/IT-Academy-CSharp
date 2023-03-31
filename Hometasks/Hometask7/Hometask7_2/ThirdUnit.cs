namespace Hometask7.Hometask7_2
{
    internal class ThirdUnit : Unit, ISwimable
    {
        public bool IsSwimming { get; set; }
        public ThirdUnit(char symbol)
            : base(symbol)
        {
            IsSwimming = false;
        }

        public void Swim()
        {
            IsSwimming = true;
            Console.WriteLine("I'm swimming");
            IsSwimming = false;
        }

        public override void Move2()
        {
            Console.WriteLine("I'm moving, but I would like to swim instead!");
        }
    }
}
