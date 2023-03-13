namespace Hometask7.Hometask7_2
{
    internal class FirstUnit : Unit, IFlyable
    {
        public string Name { get; set; }

        public FirstUnit(char symbol, string name)
            : base(symbol)
        {
            Name = name;
        }

        public void Fly()
        {
            Console.WriteLine("I can fly! So I'm flying!");
        }

        public override void Move2()
        {
            Console.WriteLine($"{Name} isn't flying right now, but anyways it's moving.");
        }
    }
}
