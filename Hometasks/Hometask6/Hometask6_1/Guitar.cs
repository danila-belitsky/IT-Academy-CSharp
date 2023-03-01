namespace Hometask6.Hometask6_1
{
    internal class Guitar : IString
    {
        public string Description { get; set; }

        public void Play()
        {
            Console.WriteLine("*Guitar sounds*");
            Console.WriteLine("Description: " + Description);
        }
        public Guitar(string description)
        {
            Description = description;
        }
    }
}
