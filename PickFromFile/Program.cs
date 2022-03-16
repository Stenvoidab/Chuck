using System;
using System.IO;

namespace PickFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomfood, randomdrink, randommovie;
            randomfood = GetRandomFromFile("foods.txt");
            randomdrink = GetRandomFromFile("drinks.txt");
            randommovie = GetRandomFromFile("movies.txt");
            
            Console.WriteLine($"Tonight you will have some {randomfood} with some {randomdrink} and watch {randommovie};");
            
            
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
