using Hometask6.Hometask6_1;

namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IString> instruments = new() { new Guitar("The guitar is a fretted musical instrument that typically has six strings."),
                                                new Harp("The harp is a stringed musical instrument that has strings running at an angle to its soundboard."),
                                                new Violin("The violin is a wooden string instrument in the violin family.") };

            foreach (var instrument in instruments)
            {
                instrument.Play();
                Console.WriteLine();
            }
        }
    }
}