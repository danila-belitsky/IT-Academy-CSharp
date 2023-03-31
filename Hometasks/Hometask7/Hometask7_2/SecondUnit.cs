namespace Hometask7.Hometask7_2
{
    internal class SecondUnit : Unit, IJumpable
    {
        public int ExtraJumps { get; set; }

        public SecondUnit(char symbol, int jumps)
            : base(symbol)
        {
            ExtraJumps = jumps;
        }

        public void Jump()
        {
            Console.WriteLine("jump, jump..");
        }

        public override void Move2()
        {
            for (int i = 0; i <= ExtraJumps; i++)
            {
                Jump();
            }
        }
    }
}
