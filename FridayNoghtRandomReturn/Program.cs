using System;

namespace FridayNoghtRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomfood, randomdrink, randommovie;
            string[] foods = { "Chicken wings", "Pizza", "Sushi", "Popcorn", "Salad" };
            string[] drink = { "Apple juice", "Coca cola", "Fanta", "Sprite" };
            string[] movie = { "Titanic", "American pie", "Die hard", "Home alone" };

            randomfood = PickRandomElementFromArray(foods);
            randomdrink = PickRandomElementFromArray(drink);
            randommovie = PickRandomElementFromArray(movie);

            Console.WriteLine($"Tonight you will have some {randomfood} with some {randomdrink} and watch {randommovie};");
        }

        private static int GenerateRandomIndex(string[] somearray)

        {
            Random Rnd = new Random();
            int RandomIndex = Rnd.Next(0, somearray.Length);

            return RandomIndex;
        }

       
        private static string PickRandomElementFromArray(string[] SomeArray)
        {
            string RandomElement = SomeArray[GenerateRandomIndex(SomeArray)];
            return RandomElement;
        }

    }
}
