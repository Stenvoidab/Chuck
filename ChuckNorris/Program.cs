using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string RandomJoke;
            RandomJoke = GetRandomFromFile("chuck.txt");
            Console.WriteLine($"{RandomJoke}");
        }

        private static int GenerateRandomIndex(string[] somearray)

        {
            Random Rnd = new Random();
            int RandomIndex = Rnd.Next(0, somearray.Length);

            return RandomIndex;
        }

        private static string GetRandomFromFile(string FileName)
        {
            string filepath = $@"C:\Users\...\OneDrive\Töölaud\TTK\programeerimine\Nädal 8 - failid-20220314\{FileName}";
            string[] DataFromFile = File.ReadAllLines(filepath);
            string RandomElement = DataFromFile[GenerateRandomIndex(DataFromFile)];

            return RandomElement;
        }
    }
}
