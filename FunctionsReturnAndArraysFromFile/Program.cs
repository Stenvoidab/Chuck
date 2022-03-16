using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "Chicken wings", "Pizza", "Sushi", "Popcorn", "Salad" };
            Random Rnd = new Random();
            int RandomIndex = Rnd.Next(0,foods.Length);

            string RandomFood = foods[RandomIndex];
            Console.WriteLine($"Computer picked {RandomFood}.");

        }
        private static void DisplayRandomDrink()
        {
            string[] drink = { "Apple juice", "Coca cola", "Fanta", "Sprite" };
            Random Rnd = new Random();
            int RandomIndex = Rnd.Next(0, drink.Length);

            string Randomdrink = drink[RandomIndex];
            Console.WriteLine($"Computer picked {Randomdrink}.");
        }
        private static void DisplayRandomMovie()
        {
            string[] movie = { "Titanic", "American pie", "Die hard", "Home alone" };
            Random Rnd = new Random();
            int RandomIndex = Rnd.Next(0, movie.Length);

            string Randommovie = movie[RandomIndex];
            Console.WriteLine($"Computer picked {Randommovie}.");
        }
    }

}
