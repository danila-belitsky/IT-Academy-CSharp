namespace Hometask6.Hometask6_1
{
    internal class Harp : IString
    {
        public string Description { get; set; }

        public void Play()
        {
            Console.WriteLine("*Harp sounds*");
            Console.WriteLine("Description: " + Description);
        }

        public Harp(string description)
        {
            Description = description;
        }
    }
}
