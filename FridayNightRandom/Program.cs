﻿using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                DisplayRandomDrink();
                DisplayRandomFood();
                DisplayRandomMovie();

            }

            public static int GenerateRandomIndex(string[] someArray)
            {
                
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, someArray.Length);

                return randomIndex;

            }

            public static void DisplayRandomDrink()

            {
                string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
                
                Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
            }

            public static void DisplayRandomMovie()

            {
                string[] movie = { "Visa hing 2", "Visa hing 1", "Annabelle", "Mägedel on silmad" };

                Console.WriteLine($"Computer picked: {movie[GenerateRandomIndex(movie)]}");


            private static void DisplayRandomFood()

            {
                 string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };

                    Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");

            }

        }
    }

}
