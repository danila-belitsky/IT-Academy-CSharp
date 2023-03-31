using System.Numerics;

namespace Hometask7.Hometask7_2
{
    public abstract class Unit
    {
        protected int _count;
        public int Id { get; }
        public char Symbol { get; set; }
        public Vector2 Position { get; set; }

        public Unit(char symbol)
        {
            Id = _count;
            Symbol = symbol;
            Position = new Vector2(0f, 0f);
            _count++;
        }

        public void Move()
        {
            Random random = new Random();

            Console.CursorVisible = false;

            for (int i = 0; i < 6; i++)
            {
                Position = new Vector2(random.Next(0, 100), random.Next(0, 15));
                Console.SetCursorPosition((int)Position.X, (int)Position.Y);
                Console.Write(Symbol);
                Thread.Sleep(500);
                Console.Clear();
            }

            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = true;
        }

        public abstract void Move2();
    }
}
