using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
    
        }


        private static int GenerateRandomIndex(string[] somearray)
            
        {
            Random Rnd = new Random();
            int RandomIndex = Rnd.Next(0, somearray.Length);

            return RandomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "Chicken wings", "Pizza", "Sushi", "Popcorn", "Salad" };

            
            Console.WriteLine($"Computer picked {foods[GenerateRandomIndex(foods)]}.");

        }
        private static void DisplayRandomDrink()
        {
            string[] drink = { "Apple juice", "Coca cola", "Fanta", "Sprite" };
            
            Console.WriteLine($"Computer picked {drink[GenerateRandomIndex(drink)]}.");
        }
        private static void DisplayRandomMovie()
        {
            string[] movie = { "Titanic", "American pie", "Die hard", "Home alone" };
            
            Console.WriteLine($"Computer picked {movie[GenerateRandomIndex(movie)]}.");
        }
    }


}
