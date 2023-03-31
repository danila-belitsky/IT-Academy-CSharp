namespace Hometask6.Hometask6_1
{
    internal class Violin : IString
    {
        public string Description { get; set; }

        public void Play()
        {
            Console.WriteLine("*Violin sounds*");
            Console.WriteLine("Description: " + Description);
        }

        public Violin(string description)
        {
            Description = description;
        }
    }
}
